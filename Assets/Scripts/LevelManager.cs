using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private FileData fileData;
    private PlayerStats playerStats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fileData = FindFirstObjectByType<FileData>();
        playerStats = FindFirstObjectByType<PlayerStats>();
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


    public void ExitGame() 
    {
        Application.Quit();
    }

    public void StartGame() 
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadGame() 
    {
        fileData.Load();
        GoToSavedLevel();
    }


    public void GoToSavedLevel() 
    {
        switch (playerStats.currentGameLevel) 
        {
            case 1:
                SceneManager.LoadScene("Level_1");
                break;
            case 2:
                SceneManager.LoadScene("Level_2");
                break;
            case 3:
                SceneManager.LoadScene("Level_3");
                break;
            default:
                SceneManager.LoadScene("Level_1");
                break; 
        }
    }
}
