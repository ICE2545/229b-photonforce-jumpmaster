using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletPrefab;
    
    //variable for test bullet's force
    [SerializeField] private float force = 20f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //spawn bullet at shootpoint
            Rigidbody2D shootbullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            //addforce to bullet(for test if bullet can shoot)
            shootbullet.AddForce(transform.right * force, ForceMode2D.Impulse);
        }
    }
}
