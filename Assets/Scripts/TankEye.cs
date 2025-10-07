using UnityEngine;

public class TankEye : MonoBehaviour
{
    public GameObject tankEye;
    private Vector3 tankEyePosition; 
       

    // Update is called once per frame
    void Update()
    {
        // Get the position where the bullet will be shot
        tankEyePosition = tankEye.transform.position;

        transform.position = tankEyePosition;


    }
}
