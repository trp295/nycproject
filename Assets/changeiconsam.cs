using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeiconsam : MonoBehaviour
{
    Image samanthaUI_dark;
    public Sprite light;
    public GameObject player;

    void Start()
    {
        samanthaUI_dark = GetComponent<Image>();
    }

    void Update()
    {
        if (player.GetComponent<dialogue_script>().talk_samantha) 
        {
             samanthaUI_dark.sprite = light;

        }
    }
}
