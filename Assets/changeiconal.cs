using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeiconal : MonoBehaviour
{
    Image albertoUI_dark;
    public Sprite light;
    public GameObject player;

    void Start()
    {
        albertoUI_dark = GetComponent<Image>();
    }

    void Update()
    {
        if (player.GetComponent<dialogue_script>().talk_alberto) 
        {
             albertoUI_dark.sprite = light;

        }
    }
}
