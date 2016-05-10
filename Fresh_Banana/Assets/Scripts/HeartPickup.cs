using UnityEngine;
using System.Collections;

public class HeartPickup : MonoBehaviour {


    private Player_Controller player;
    public GameObject heartPickup;

    public HealthManager hpManager;


    // Use this for initialization
    void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        player = FindObjectOfType<Player_Controller>();
        hpManager = FindObjectOfType<HealthManager>();

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player_Controller>() == null)
        {
            return;

        }
        Destroy(gameObject);
        hpManager.AddHeart();
        Instantiate(heartPickup, player.transform.position, player.transform.rotation);
    }
}
