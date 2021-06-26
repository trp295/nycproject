using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public bool gameStarted = false;
    public bool won = false;

    public Button startButton; 
    public GameObject player;
    public TextMeshProUGUI textbox_display;

    

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;  
        } else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<dialogue_script>().talk_alberto) 
        {
            if (player.GetComponent<dialogue_script>().talk_samantha) 
        {
            if (player.GetComponent<dialogue_script>().talk_joanna) 
        {
            if (player.GetComponent<dialogue_script>().talk_callie) 
        {
            
            won = true;

        }
            

        }
            

        }
            

        }

        if (won)
        {
            textbox_display.text = "You Won!";
        }

    }

    public void StartTheGame() 
    {
        if (!gameStarted)
        {
            gameStarted = true;
            Destroy(startButton.gameObject);
        }
    }

    


}