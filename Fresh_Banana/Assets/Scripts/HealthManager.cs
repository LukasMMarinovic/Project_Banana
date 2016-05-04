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

    //public string startingHP;
    //public string playerHP;

    // Use this for initialization
    void Start ()
    {
        
        text = GetComponent<Text>();
       // playerHP = startingHP;
        playerHealth = startingPlayerHealth;
        manageLevel = FindObjectOfType<LevelManangement>();
        isDead = false;

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(playerHealth <= 0 && !isDead)
        {
            Debug.Log("0");
            playerHealth = 0;
            manageLevel.Respawn();
            isDead = true;

        }

        text.text = "" + playerHealth;

	}

    public static void HurtPlayer(int damage)
    {
        playerHealth -= damage;

    }

    public void fullHealth()
    {
        playerHealth = startingPlayerHealth;
    }
}
