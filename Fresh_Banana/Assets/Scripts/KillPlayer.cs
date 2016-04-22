using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{
    public LevelManangement manageLevel;
    

    // Use this for initialization
    void Start ()
    {
        manageLevel = FindObjectOfType<LevelManangement>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    //kills player on collision with trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
      
            manageLevel.Respawn();

        }
    }



}
