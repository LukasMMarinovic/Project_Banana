using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManagement : MonoBehaviour
{

    public static int bananasCollected;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        bananasCollected = 0;

    }

    void Update()
    {
        if (bananasCollected < 0)
        {
            bananasCollected = 0;

        }

        text.text = "" + bananasCollected;


    }

    public static void AddBanana(int bananasToAdd)
    {
        bananasCollected += bananasToAdd;

    }
    public static void ResetBananas()
    {
        bananasCollected = 0;
    }
}
