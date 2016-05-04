using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{

    public int enemyHealth;
    public GameObject deathEffect;
    public int bananasOnDeath;

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
            ScoreManagement.AddBanana(bananasOnDeath);
            Destroy(gameObject);

        }
	}
    public void giveDamage(int damageGiven)
    {
        enemyHealth -= damageGiven;
    }
}
