using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogue_script : MonoBehaviour
{

    public bool talk_alberto = false;
    public bool talk_samantha = false;
    public bool talk_joanna = false;
    public bool talk_callie = false;

    public bool cottoncandyget = false;
    public bool baseballget = false;
    public bool ticketget = false;
    public bool phoneget = false;

    
    public TextMeshProUGUI textbox_display;
    public GameObject cottoncandyUI;
    public GameObject baseballUI;
    public GameObject ticketUI;
    public GameObject phoneUI;

 

    void Start()
    {
      cottoncandyUI.SetActive(false);
      baseballUI.SetActive(false);
      ticketUI.SetActive(false);
      phoneUI.SetActive(false);

    }

    void FixedUpdate()
    {
    
       
    }

    void Update()
    {
        
        
    }

    void OnClick()
    {
		
	}

    void showText()
    {
        
    }

    //this will get called when the player collides with another object with a collider on it
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Alberto")
        {
            if (ticketget == false) 
            {
                textbox_display.text = "I've never ridden The Cyclone before. We should get tickets!";
                
            } else 
            {
                talk_alberto = true;
                textbox_display.text = "Oh great, you got the tickets! Thanks!";
                ticketUI.SetActive(false);
            }
            
            
        } 
        if (collision.gameObject.name == "Samantha")
        {
            if (baseballget == false)
            {
                textbox_display.text = "A fly ball went out of the stadium. I wonder where it went.";

            } else
            {
                talk_samantha = true;
                textbox_display.text = "Wow! You found the ball! Nice!";
                baseballUI.SetActive(false);
                
            }

        } 
        if(collision.gameObject.name == "Callie")
        {
            if (cottoncandyget == false) 
            {
                textbox_display.text = "I'm so hungry!";
            } else 
            {
                talk_callie = true;
                textbox_display.text = "Hurray! Thank you!";
                cottoncandyUI.SetActive(false);

            }
            
            

        } 
        if(collision.gameObject.name == "Joanna")
        {
            if (phoneget == false)
            {
                textbox_display.text = "Hey, I think I dropped my phone somewhere. Can you help me look for it?";

            } else
            {
                talk_joanna = true;
                textbox_display.text = "Thank goodness! Where did you find it?";
                phoneUI.SetActive(false);
            }

        } 
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Alberto")
        {
            
            textbox_display.text = "";
            
            
        } 
        if (collision.gameObject.name == "Samantha")
        {
            
            textbox_display.text = "";

        } 
        if(collision.gameObject.name == "Callie")
        {
        
            textbox_display.text = "";

        } 
        if(collision.gameObject.name == "Joanna")
        {
            
            textbox_display.text = "";

        } 
    }
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.name == "cottoncandy")
        {
            Debug.Log("Collected!");
            Destroy(collider2D.gameObject); //destroys object when we collide with it
            cottoncandyUI.SetActive(true);
            cottoncandyget = true;
            
        }
        if(collider2D.gameObject.name == "baseballitem")
        {
            
            Destroy(collider2D.gameObject); //destroys object when we collide with it
            baseballUI.SetActive(true);
            baseballget = true;
            
        }
        if(collider2D.gameObject.name == "ticket")
        {
            
            Destroy(collider2D.gameObject); //destroys object when we collide with it
            ticketUI.SetActive(true);
            ticketget = true;
            
        }
        if(collider2D.gameObject.name == "phone")
        {
            
            Destroy(collider2D.gameObject); //destroys object when we collide with it
            phoneUI.SetActive(true);
            phoneget = true;
            
        }
    }
    
}
