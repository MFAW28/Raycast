using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorParticleSystem : MonoBehaviour
{
    public ParticleSystem particleColor;

    public Color Redcolor;
    public Color Bluecolor;

    private Color StartColor
    {
        set
        {
            var main = particleColor.main;
            main.startColor = value;
        }
    }

    void Start()
    {
        StartColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartColor = Redcolor;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartColor = Bluecolor;
        }
    }
}
