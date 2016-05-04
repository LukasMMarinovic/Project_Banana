using UnityEngine;
using System.Collections;

public class SpatBananaControl : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public GameObject impactParticle;
    public Player_Controller player;

    public int damage;



    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<Player_Controller>();

        if (player.transform.localScale.x < 0)
        {
            rotationSpeed = -rotationSpeed;
            speed = -speed;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().angularVelocity = rotationSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D (Collider2D other)
    {

        if (other.tag =="Enemy")
        {
            other.GetComponent<EnemyHealth>().giveDamage(damage); 

        }
        Instantiate(impactParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
