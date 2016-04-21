using UnityEngine;
using System.Collections;

public class LevelManangement : MonoBehaviour
{

    public GameObject currentCheckpoint;
    private Player_Controller player;
    public GameObject blood;
    public GameObject respawnParticle;
    public float respawnDelay;

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

    public IEnumerator RespawnPlayerCo ()
    {
        Instantiate(blood, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        Debug.Log("respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);

    }
}
