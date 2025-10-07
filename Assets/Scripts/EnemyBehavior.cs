using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private PlayerStats playerStats; 

    public GameObject bullet;

    private float shotCooldown = 2.25f;
    private float timeCount = 0;

    [SerializeField] private float maxHealth;
    [SerializeField] private float health; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Player");
        playerStats = FindFirstObjectByType<PlayerStats>();
        maxHealth = 6;
        health = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;

        if(timeCount> shotCooldown)  
        {
            ShootAtPlayer();
            timeCount = 0;
        }

        if (health <= 0)
        {
            health = 0;
            playerStats.GettingScore(20);
            playerStats.GettingExperience(20); 
            Destroy(this.gameObject);
        }

        if (health > maxHealth)
            health = maxHealth;

    }

    public void ShootAtPlayer() 
    {
        if(target != null) 
        {
            GameObject tempBullet = Instantiate(bullet, transform.position + (target.transform.position - transform.position).normalized, Quaternion.identity);
            Destroy(tempBullet, 3f); 
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= 2;
            Destroy(collision.gameObject);
        }
    }

}
