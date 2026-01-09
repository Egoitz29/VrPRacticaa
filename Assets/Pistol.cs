using UnityEngine;


public class Pistol : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float bulletLifetime = 5f;

    public AudioClip clip;
    private AudioSource source;

    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private int handsHolding = 0;

    private void Start()
    {
        source = GetComponent<AudioSource>();

        grabInteractable.selectEntered.AddListener(_ => handsHolding++);
        grabInteractable.selectExited.AddListener(_ => handsHolding--);
    }

    public void FireBullet()
    {
        if (handsHolding < 2)
        {
            Debug.Log("Necesitas las DOS manos para disparar");
            return;
        }

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        source.PlayOneShot(clip);

        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }

        Destroy(bullet, bulletLifetime);
    }
}
