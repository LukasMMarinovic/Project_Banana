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

    public CameraControl cam;

    public HealthManager hpManager;

 

    // Use this for initialization
    void Start ()
    {
        cam = FindObjectOfType<CameraControl>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
  

        player = FindObjectOfType<Player_Controller>();

        hpManager = FindObjectOfType<HealthManager>();
        

}



    public void Respawn()
    {
        StartCoroutine(RespawnPlayerCo());
    }

    ///respawns the player 
    public IEnumerator RespawnPlayerCo ()
    {
        //hides player model
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        cam.isBeingFollowed = false;
        
        //displays blood
        Instantiate(blood, player.transform.position, player.transform.rotation);


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

        hpManager.FullHealth();
        hpManager.isDead = false;

        cam.isBeingFollowed = true;

        //displays respawn particle
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);

        
       
    }
}
