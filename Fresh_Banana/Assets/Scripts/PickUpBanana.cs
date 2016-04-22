using UnityEngine;
using System.Collections;

public class PickUpBanana : MonoBehaviour
{

    public int bananasToAdd;

    //public GameObject BananaPickup;
    //private Player_Controller player;

    ///determines if the player is activating the trigger
    /// and "eats" the banana while adding to the score
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player_Controller>() == null)
        {
            return;

        }
        ScoreManagement.AddBanana(bananasToAdd);
        //Instantiate(BananaPickup, player.transform.position, player.transform.rotation);
        Destroy(gameObject);

    }


	// Use this for initialization
	void Start ()
    {
        //player = FindObjectOfType<Player_Controller>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
