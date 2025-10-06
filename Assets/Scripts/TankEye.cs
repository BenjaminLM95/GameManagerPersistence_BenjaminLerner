using UnityEngine;

public class TankEye : MonoBehaviour
{
    public GameObject tankEye;
    private Vector3 tankEyePosition; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tankEyePosition = tankEye.transform.position;

        transform.position = tankEyePosition;


    }
}
