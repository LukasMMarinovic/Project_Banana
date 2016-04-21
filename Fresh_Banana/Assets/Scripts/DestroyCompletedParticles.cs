using UnityEngine;
using System.Collections;

public class DestroyCompletedParticles : MonoBehaviour
{

    private ParticleSystem selectedParticleSystem;
	// Use this for initialization
	void Start ()
    {
        selectedParticleSystem = GetComponent<ParticleSystem>();

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (selectedParticleSystem.isPlaying)
        {
            return;
        }
        Destroy(gameObject);
	}
}
