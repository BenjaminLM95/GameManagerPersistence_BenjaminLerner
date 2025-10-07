using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private FileData fileData;
    private PlayerStats playerStats;
    public GameObject playerUI; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fileData = FindFirstObjectByType<FileData>();
        playerStats = FindFirstObjectByType<PlayerStats>();
        playerUI.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            SceneManager.LoadScene("MainMenu");
            playerUI.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            SceneManager.LoadScene("Level_1");
            playerUI.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            SceneManager.LoadScene("Level_2");
            playerUI.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            SceneManager.LoadScene("Level_3");
            playerUI.gameObject.SetActive(true);
        }


    }


    public void ExitGame() 
    {
        Application.Quit();
    }

    public void StartGame() 
    {
        SceneManager.LoadScene("Level_1");
        playerUI.gameObject.SetActive(true);
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
                playerUI.gameObject.SetActive(true);
                break;
            case 2:
                SceneManager.LoadScene("Level_2");
                playerUI.gameObject.SetActive(true);
                break;
            case 3:
                SceneManager.LoadScene("Level_3");
                playerUI.gameObject.SetActive(true);
                break;
            default:
                SceneManager.LoadScene("Level_1");
                playerUI.gameObject.SetActive(true);
                break; 
        }
    }
}
