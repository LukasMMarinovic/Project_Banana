using UnityEngine;
using System.Collections;

public class BearTrap : MonoBehaviour
{

    private Animator animationBT; 
    public LevelManangement manageLevel;

    public bool triggered;

    public bool hasRespawned;

    public int damageToGive;


    public HealthManager hpManager;

    // Use this for initialization
    void Start ()
    {
        
        animationBT = GetComponent<Animator>();      
        manageLevel = FindObjectOfType<LevelManangement>();
        hpManager = FindObjectOfType<HealthManager>();


    }
	
	// Update is called once per frame
	void Update ()
    {
        animationBT.SetBool("on", triggered);
        animationBT.SetBool("hasRespawned", hasRespawned);
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            hasRespawned = false;
            triggered = true;
            
            hpManager.HurtPlayer(damageToGive);
 


        }
    }
  void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "player")
        {
            hasRespawned = true;
            triggered = false;
        }

        }


}
