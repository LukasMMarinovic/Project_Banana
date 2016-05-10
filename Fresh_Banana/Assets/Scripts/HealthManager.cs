using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int startingPlayerHealth;
    public static int playerHealth;
    Text text;
    private LevelManangement manageLevel;

    public bool isDead;

    public string startingHP;
    public string playerHP;

    // Use this for initialization
    void Start ()
    {
        
        text = GetComponent<Text>();

        
        playerHP = startingHP;
        playerHealth = startingPlayerHealth;
        manageLevel = FindObjectOfType<LevelManangement>();
        isDead = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(playerHealth <= 0 && !isDead)
        {
            
            playerHealth = 0;
            manageLevel.Respawn();
            isDead = true;

        }

        text.text = "" + playerHP;

	}

    public void HurtPlayer(int damage)
    {
        playerHealth -= damage;
        for (int K = 0; K < damage; K++)
        {
            playerHP = playerHP.Remove(playerHP.Length - 5);
        }
    }




    public void FullHealth()
    {
        playerHealth = startingPlayerHealth;
		playerHP = startingHP;
    }

    public void AddHeart()
    {
        playerHealth += 1;
        playerHP += " [||]";
    }
}

