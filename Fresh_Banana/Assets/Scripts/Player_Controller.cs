using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;



    public float checkRadius;
    public LayerMask consideredAsGround;
    private bool onGround;
    public Transform checker;
    public Vector2 groundCheck;

    public bool hasJumped2;



    // Use this for initialization
    void Start()
    {

    }





    // Update is called once per frame
    void Update()
    {

        groundCheck = checker.position;
        onGround = Physics2D.OverlapCircle(groundCheck, checkRadius, consideredAsGround);

        //jump on keypress
        if (onGround)
        {
            hasJumped2 = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !hasJumped2 && !onGround)
        {
            Jump();
            hasJumped2 = true;
        }




        //move right
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        //move left
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }


    ///moves character up to jumpheight
    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }



}   

