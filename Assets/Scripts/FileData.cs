using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class FileData : MonoBehaviour
{
    public PlayerStats playerStats;
    public GameObject playerObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStats = FindFirstObjectByType<PlayerStats>();
        playerObject = GameObject.Find("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStats == null)
            playerStats = FindFirstObjectByType<PlayerStats>();

        if(playerObject == null)
            playerObject = GameObject.Find("Player");
    }

    public void Save() 
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerData.dat");

        PlayerData playerData = new PlayerData();       
        playerData.maxHealth = playerStats.maxHealth;
        playerData.health = playerStats.health;
        playerData.level = playerStats.level;
        playerData.experience = playerStats.experience;
        playerData.score = playerStats.score;
        playerData.currentGameLevel = playerStats.currentGameLevel; 
        playerData.playerPos = playerObject.transform.position;

        Debug.Log("Data saved"); 

        binaryFormatter.Serialize(file, playerData);
        file.Close(); 
    }


    public void Load() 
    {
        if(File.Exists(Application.persistentDataPath + "/PlayerData.dat")) 
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerData.dat", FileMode.Open);
            PlayerData data = (PlayerData)binaryFormatter.Deserialize(file);
            file.Close();

            playerStats.maxHealth = data.maxHealth;
            playerStats.health = data.health;
            playerStats.level = data.level;
            playerStats.experience = data.experience;
            playerStats.score = data.score;
            playerObject.transform.position = data.playerPos;

            Debug.Log("Data Loaded"); 
        }
    }
}
