using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    public float destroyForce = 5f;

    public void Break()
    {
        if (destroyedVersion != null)
        {
            GameObject destroyed = Instantiate(
                destroyedVersion,
                transform.position,
                transform.rotation
            );

            foreach (Rigidbody rb in destroyed.GetComponentsInChildren<Rigidbody>())
            {
                rb.AddExplosionForce(destroyForce, transform.position, 2f);
            }
        }

        Destroy(gameObject);
    }
}
