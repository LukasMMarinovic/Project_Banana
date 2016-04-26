using UnityEngine;
using System.Collections;

public class LevelManangement : MonoBehaviour
{

    public GameObject currentCheckpoint;
    private Player_Controller player;
    public GameObject blood;
    public GameObject respawnParticle;
    public float respawnDelay;

    public int lostBananas;


    


    // Use this for initialization
    void Start ()
    {
        
}
	
	// Update is called once per frame
	void Update ()
    {
        player = FindObjectOfType<Player_Controller>();
	}

    public void Respawn()
    {
        StartCoroutine(RespawnPlayerCo());
    }

    ///respawns the player 
    public IEnumerator RespawnPlayerCo ()
    {
        

        //displays blood
        Instantiate(blood, player.transform.position, player.transform.rotation);
        //hides player model
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        //removes bananas from score
        ScoreManagement.AddBanana(-lostBananas);

        //prevents camera sliding after death
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //logs respawn
        Debug.Log("respawn");
        //creates a small pause allowing the user to take in what just happened
        yield return new WaitForSeconds(respawnDelay);

        //places model at current spawnpoint
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        //displays respawn particle
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);

        
       
    }
}
