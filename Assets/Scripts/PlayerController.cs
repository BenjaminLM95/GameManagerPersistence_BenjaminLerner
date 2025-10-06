using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Variables")]
    private float horizontal;
    private float vertical;
    [SerializeField] private float speedMov = 3f;
    [SerializeField] private float sprintSpeed = 5;
    [SerializeField] private bool canMove = true;
    [SerializeField] private bool canRotate = true;


    [Header("Shoot Abilities")]
    public GameObject bulletPrefab;
    public GameObject muzzleObject;
   

    private Rigidbody2D body;

    public Vector2 vectorLookAt;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (canMove)
        {
            body.linearVelocity = new Vector2(horizontal * speedMov, vertical * speedMov);
        }


        if (canRotate)
        {
            if (Input.GetKey(KeyCode.U))
            {
                transform.Rotate(0.0f, 0.0f, 90.0f * Time.deltaTime, Space.World);
            }
            else if (Input.GetKey(KeyCode.I))
            {
                transform.Rotate(0.0f, 0.0f, -90.0f * Time.deltaTime, Space.World);
            }
        }
               

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ShootABullet(); 
        }
     
    }

    public void ShootABullet() 
    {
        GameObject tempBullet = Instantiate(bulletPrefab, muzzleObject.transform.position, Quaternion.identity);
        Destroy(tempBullet, 1.6f);

    }

    public Vector2 GetBulletMovement() 
    {        
        return (transform.position - muzzleObject.transform.position) * -1;
    }

    
}
