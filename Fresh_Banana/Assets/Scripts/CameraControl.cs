using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    public Player_Controller player;

    public bool isBeingFollowed;
    public float xOffset;
    public float yOffset;



	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<Player_Controller>();
        isBeingFollowed = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (isBeingFollowed)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
        }
	}
}
