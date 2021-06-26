using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scr : MonoBehaviour
{
    Image joannaUI_dark;
    public Sprite light;
    public GameObject player;

    void Start()
    {
        joannaUI_dark = GetComponent<Image>();
    }

    void Update()
    {
        if (player.GetComponent<dialogue_script>().talk_joanna) 
        {
             joannaUI_dark.sprite = light;

        }
    }
}
