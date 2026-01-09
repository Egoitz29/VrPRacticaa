using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destructible d = collision.collider.GetComponent<Destructible>();

        if (d != null)
        {
            d.Break();
        }

        Destroy(gameObject);
    }
}
