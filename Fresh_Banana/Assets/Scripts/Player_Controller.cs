using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        }

        //move right
        {
        }

        //move left
        {
        }
    }
}
