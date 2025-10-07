using UnityEngine;

public class EnemyBulletBehavior : MonoBehaviour
{
    private GameObject playerObject;
    private Vector3 bulletMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.Find("Player");  
        bulletMovement = (transform.position - playerObject.transform.position) * -1;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletMovement * Time.deltaTime; 
    }



}
