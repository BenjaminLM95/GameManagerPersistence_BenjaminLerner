using UnityEngine;

public class StatsUpgrade : MonoBehaviour
{
    private PlayerStats playerStats; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStats = FindFirstObjectByType<PlayerStats>(); 
    }

   
    public void IncreaseMaxHealth() 
    {
        playerStats.maxHealth++; 
    }

    public void RecoverHealth() 
    {
        playerStats.health++; 
    }

    public void IncreaseExperience() 
    {
        playerStats.experience += 10; 
    }

    public void IncreaseLevel() 
    {
        playerStats.level++;
    }

    public void IncreaseScore() 
    {
        playerStats.score += 10; 
    }

    public void IncreaseStrength() 
    {
        playerStats.strenght++; 
    }

    public void IncreaseDefense() 
    {
        playerStats.defense++; 
    }
}
