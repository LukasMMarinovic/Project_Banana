using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{

    public int enemyHealth;
    public GameObject deathEffect;
    public int bananasOnDeath;

    public GameObject Banana;




    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(enemyHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            DropBanana(transform, bananasOnDeath);
            Destroy(gameObject);

        }
	}
    public void giveDamage(int damageGiven)
    {
        enemyHealth -= damageGiven;
    }


    public void DropBanana(Transform point, int bananasToDrop)
    {
        while(bananasToDrop > 0)
        {
            Instantiate(Banana, transform.position, transform.rotation);
            bananasToDrop--;
        }
    }


}
