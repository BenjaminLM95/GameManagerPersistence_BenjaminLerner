using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // References
    private FileData fileData;
    private PlayerStats playerStats;
    public GameObject playerUI;
    public GameObject menuUI; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fileData = FindFirstObjectByType<FileData>();
        playerStats = FindFirstObjectByType<PlayerStats>();
        playerUI.gameObject.SetActive(false); 
        menuUI.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            SceneManager.LoadScene("MainMenu");
            playerUI.gameObject.SetActive(false);
            menuUI.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            SceneManager.LoadScene("Level_1");
            playerUI.gameObject.SetActive(true);
            menuUI.gameObject.SetActive(false);
            playerStats.currentLevelScene = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            SceneManager.LoadScene("Level_2");
            playerUI.gameObject.SetActive(true);
            menuUI.gameObject.SetActive(false);
            playerStats.currentLevelScene = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            SceneManager.LoadScene("Level_3");
            playerUI.gameObject.SetActive(true);
            menuUI.gameObject.SetActive(false);
            playerStats.currentLevelScene = 3;
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
        menuUI.gameObject.SetActive(false);
    }

   public void LoadResumeGame() 
    {
        fileData.Load();

        //Make the player jump into the last scene saved
        switch (playerStats.currentLevelScene) 
        {
            case 1:
                SceneManager.LoadScene("Level_1");
                playerUI.gameObject.SetActive(true);
                menuUI.gameObject.SetActive(false);
                break;
            case 2:
                SceneManager.LoadScene("Level_2");
                playerUI.gameObject.SetActive(true);
                menuUI.gameObject.SetActive(false);
                break;
            case 3:
                SceneManager.LoadScene("Level_3");
                playerUI.gameObject.SetActive(true);
                menuUI.gameObject.SetActive(false);
                break;
            default:
                SceneManager.LoadScene("Level_1");
                playerUI.gameObject.SetActive(true);
                menuUI.gameObject.SetActive(false);
                break;
        }
    }
            
}
