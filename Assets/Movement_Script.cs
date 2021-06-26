using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour
{
    
    public float movementSpeed = 600f;
    public Rigidbody2D playerRB;
    public GameObject manager;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); //get a reference to the Rigidbody2D component on this player game object
    
        
    }

    void FixedUpdate()
    {
        if (manager.GetComponent<GameManager>().gameStarted) {
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            ///move player to the left
            playerRB.AddForce(Vector2.left * movementSpeed);
            //playerRB.velocity = new Vector2(-1,playerRB.velocity.y) * movementSpeed; //or Vector2.left
            //Vector2.left is a short way of writing Vector2(-1, 0);

        } else if (Input.GetKey(KeyCode.RightArrow))
          {
            //move the player to the right
            playerRB.AddForce(Vector2.right * movementSpeed);
            //playerRB.velocity = new Vector2(1,playerRB.velocity.y) * movementSpeed; //or Vector2.right

            //Vector2.right is a short way of writing Vector2(1, 0);

        } else if (Input.GetKey(KeyCode.UpArrow))
          {
            //move the player up
            playerRB.AddForce(Vector2.up * movementSpeed);
                

        } else if (Input.GetKey(KeyCode.DownArrow))
          {
           //move the player down
            playerRB.AddForce(Vector2.down * movementSpeed);
                

        }
       }
            
    }


    // Update is called once per frame
    void Update()
    {
        if (manager.GetComponent<GameManager>().gameStarted) {
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            //transform.Translate(Vector3.right *movementSpeed);
            GetComponent<Animator>().Play("Walk_Right");
        }

        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.left *movementSpeed);
            GetComponent<Animator>().Play("Walk_Left");

        }

        else if(Input.GetKey(KeyCode.UpArrow))
        {
            //transform.Translate(Vector3.up *movementSpeed);
            GetComponent<Animator>().Play("Walk_Up");

        }

        else if(Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate(Vector3.down *movementSpeed);
            GetComponent<Animator>().Play("Walk_Down");

        }

        else
        {
            GetComponent<Animator>().Play("Idle");
        }
        }

    }

    
}
