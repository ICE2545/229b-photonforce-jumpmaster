using UnityEngine;

public class Bullet : MonoBehaviour
{
    /*public EnemyHealth enemyHealth;
    public int damage = 1;*/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //delete object 
        Destroy(gameObject,2f);
    }
    
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(target.gameObject);
            //enemyHealth.takedamage(damage);
        }
    }
}
