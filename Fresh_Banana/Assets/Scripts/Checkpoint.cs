using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public LevelManangement manageLevel;



    // Use this for initialization
    void Start()
    {

        manageLevel = FindObjectOfType<LevelManangement>();

    }

    // Update is called once per frame
    void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            manageLevel.currentCheckpoint = gameObject;
            Debug.Log("Activated Checkpoint" + transform.position);
        }
    }
}
