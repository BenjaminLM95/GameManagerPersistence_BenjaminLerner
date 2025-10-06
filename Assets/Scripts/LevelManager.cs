using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            SceneManager.LoadScene("Level_1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            SceneManager.LoadScene("Level_2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            SceneManager.LoadScene("Level_3"); 
        }


    }
}
