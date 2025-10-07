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
    public int currentGameLevel; // This is the level of the game

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
        if (health < 0)
            health = 0;

        if(health > maxHealth)
            health = maxHealth;


        if(health != currentHP) 
        {
            currentHP = health;
            DisplayText();
        }

    }

    public void SetStartingStats() 
    {
        maxHealth = 10;
        health = maxHealth;
        currentHP = health;
        level = 1;
        experience = 0;
        score = 0;
        DisplayText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
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

        if(experience >= 100) 
        {
            level++;
            experience = experience % 100; 
        }

    }

    public void DisplayText() 
    {
        healthText.text = "HP: " + health + " / " + maxHealth; 
    }
}
