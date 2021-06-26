using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeiconcallie : MonoBehaviour
{
    Image callieUI_dark;
    public Sprite light;
    public GameObject player;

    void Start()
    {
        callieUI_dark = GetComponent<Image>();
    }

    void Update()
    {
        if (player.GetComponent<dialogue_script>().talk_callie) 
        {
             callieUI_dark.sprite = light;

        }
    }
}
