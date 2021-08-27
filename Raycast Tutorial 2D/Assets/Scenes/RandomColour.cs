using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    private SpriteRenderer colorPlayer;

    void Start()
    {
        colorPlayer = GetComponent<SpriteRenderer>();
        colorPlayer.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
