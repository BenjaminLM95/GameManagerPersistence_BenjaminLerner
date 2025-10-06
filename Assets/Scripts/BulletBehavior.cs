using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public Vector2 bulletMovement;    
    private PlayerController playerController;

    private float bulletSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        playerController = FindFirstObjectByType<PlayerController>();
        bulletMovement = playerController.GetBulletMovement().normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(bulletMovement.x, bulletMovement.y, 0f) * Time.deltaTime * bulletSpeed; 
        
    }
}
