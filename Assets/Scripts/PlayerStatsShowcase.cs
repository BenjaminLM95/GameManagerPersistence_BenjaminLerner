using UnityEngine;
using TMPro;

public class PlayerStatsShowcase : MonoBehaviour
{
    public TextMeshProUGUI statsUI; 

    private PlayerStats playerStats;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStats = FindFirstObjectByType<PlayerStats>();
        ShowcaseText(); 
    }

    // Update is called once per frame
    void Update()
    {
        ShowcaseText(); 
    }

    public void ShowcaseText() 
    {
        statsUI.text = "HP: " + playerStats.health + " / " + playerStats.maxHealth + " Level: " + playerStats.level + " EXP: " + playerStats.experience
            + " Score: " + playerStats.score; 
    }
}
