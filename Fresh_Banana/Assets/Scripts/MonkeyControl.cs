using UnityEngine;
using System.Collections;

public class MonkeyControl : MonoBehaviour
{
    public float moveSpeed;
    public bool movingRight;

    public float checkRadius;
    public LayerMask consideredAsWall;
    public LayerMask consideredAsPlayer;
    private bool onWall;
    public Transform wallChecker;
    public Vector2 wallCheck;

    private bool notAtEdge;
    public Transform edgeChecker;
    public Vector2 edgeCheck;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {

        edgeCheck = edgeChecker.position;
        notAtEdge = Physics2D.OverlapCircle(edgeCheck, checkRadius, consideredAsWall);



        wallCheck = wallChecker.position;
        onWall = (Physics2D.OverlapCircle(wallCheck, checkRadius, consideredAsWall));

        if(onWall || !notAtEdge)
        {
            movingRight = !movingRight;
        }




        if (movingRight)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        else
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
