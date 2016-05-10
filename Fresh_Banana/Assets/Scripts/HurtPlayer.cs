using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

    public int damageToGive;
    public int heartsLost;
    public HealthManager hpManager;

    // Use this for initialization
    void Start ()
    {
        hpManager = FindObjectOfType<HealthManager>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {

           hpManager.HurtPlayer(damageToGive);

            if (HealthManager.playerHealth > 0)
            {
                var player = other.GetComponent<Player_Controller>();
                player.knockbackCount = player.knockbackLength;
                if (other.transform.position.x < transform.position.x)
                {
                    player.knockbackRight = true;

                }
                else
                {
                    player.knockbackRight = false;
                }
            }
        }
    }
    /*void OnTriggerStay2D(Collider2D other)
      {
        if (other.name == "player")
        {
            HealthManager.HurtPlayer(damageToGive);
        }
      }*/
    
}
