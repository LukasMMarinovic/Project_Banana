using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{
    Text text;
    public int timer;


    // Use this for initialization
    void Start ()
    {
        text = GetComponent<Text>();
        timer = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += 1;
        text.text = "" + timer;
	}
}
