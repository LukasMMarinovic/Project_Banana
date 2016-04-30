using UnityEngine;
using System.Collections;

public class SpatBananaControl : MonoBehaviour
{

    public float speed;
    public Player_Controller player;

    public GameObject enemyDeathParticle;
    public GameObject impactParticle;

    public int bananasEarned;

	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<Player_Controller>();

        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D (Collider2D other)
    {

        if (other.tag =="Enemy")
        {
            Instantiate(enemyDeathParticle, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManagement.AddBanana(bananasEarned);

        }
        Instantiate(impactParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
