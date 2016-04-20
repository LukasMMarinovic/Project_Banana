using UnityEngine;
using System.Collections;

public class LevelManangement : MonoBehaviour
{

    public GameObject currentCheckpoint;
    private Player_Controller player;

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
        Debug.Log("respawn");
        player.transform.position = currentCheckpoint.transform.position;

    }
}
