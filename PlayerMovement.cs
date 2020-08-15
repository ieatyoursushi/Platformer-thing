using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //important variables
    public GameObject Player;
    public Rigidbody2D playerRB;
    public GameObject Portal;

    private float jumpForce = 6.5f;
    public float fallMultiplier = 2.5f;
    public float timer;


    bool Ground;
    bool jumping;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ground = true;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        Ground = false;
    }
    void jump()
    {
        playerRB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        jumping = true;

          
       
    }


    public void TransFormRotate()
    {
        transform.Rotate(Vector3.back * 5.5f);
    }
    public void rotate()
    {
        if (Time.timeScale == 0)
        {

        }
        else
        {
            TransFormRotate();
        }
    }
    void ResetRotation()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);

    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            

            if (Ground == true)
            {
                jump();
                ResetRotation();
            }
            else
            {

            }

        }
        else
        {

        }

        if(Ground == false)
        {
            ResetRotation();
        }
        if (Ground == true)
        {
            ResetRotation();

        }


        if (playerRB.velocity.y < 0)
        {
            playerRB.velocity += Vector2.up *
            Physics2D.gravity.y *
            (fallMultiplier - 1) *
            Time.deltaTime;
        }

    }
}
