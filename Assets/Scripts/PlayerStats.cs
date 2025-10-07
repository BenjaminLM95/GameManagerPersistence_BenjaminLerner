using UnityEngine;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    [Header("Player stats")]
    public int maxHealth;
    public int health;
    public int level; // This is the level of the player
    public int experience;
    public int score;
    public int defense; 
    public int strenght;
    public int currentLevelScene; 

    private int currentHP;
    public TextMeshPro healthText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetStartingStats();
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)  // avoid the player having negative health
            health = 0;

        if(health > maxHealth)  // Avoid having more hp than the max
            health = maxHealth;


        if(health != currentHP) 
        {
            currentHP = health;
            DisplayText();
        }

    }

    public void SetStartingStats() 
    {
        //Setting the starting values when start the game
        maxHealth = 10;
        health = maxHealth;
        currentHP = health;
        level = 1;
        experience = 0;
        score = 0;
        defense = 0;
        currentLevelScene = 1; 
        DisplayText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If it get hit by the enemy's bullet, loses health and score
        if (collision.gameObject.CompareTag("EnemyBullet")) 
        {
            health -= 2;
            GettingScore(-5); 
            Destroy(collision.gameObject);
        }
    }

    public void GettingScore(int value) 
    {
        score += value; 

        if(score < 0) 
        {
            score = 0;
        }
    }

    public void GettingExperience(int value) 
    {
        experience += value;       

    }

    public void DisplayText() 
    {
        //Displaying the player health
        healthText.text = "HP: " + health + " / " + maxHealth; 
    }
}
