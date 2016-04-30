using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;
    private float moveVelocity;
    public float jumpHeight;


    public float checkRadius;
    public LayerMask consideredAsGround;
    private bool onGround;
    public Transform checker;
    public Vector2 groundCheck;
    public bool hasJumped2;


    private Animator animationT;

    public Transform projectileStart;
    public GameObject spatBanana;


    // Use this for initialization
    void Start()
    {
        animationT = GetComponent<Animator>();
        

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

        moveVelocity = 0f;
        //move right
        if (Input.GetKey(KeyCode.D))
        {          
            moveVelocity = moveSpeed;
        }
        //move left
        if (Input.GetKey(KeyCode.A))
        {            
            moveVelocity = -moveSpeed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        //plays run and idle animations
        animationT.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        animationT.SetBool("OnGround", onGround);
        
        //flips player based on travel direction
        if(GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }   
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (ScoreManagement.bananasCollected > 0)
            {
                Instantiate(spatBanana, projectileStart.position, projectileStart.rotation);
                ScoreManagement.bananasCollected -= 1;
            }
        }

    }

        
    ///moves character up to jumpheight
    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }



} 

