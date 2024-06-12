using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    public float timer = 0;
    private float i = 0;
    public Material materialDay;
    public Material materialNight;
    public bool isNight;
    // Start is called before the first frame update
    void Start()
    {
        if (isNight)
        {
            RenderSettings.skybox = materialNight;
        }
        else
        {
            RenderSettings.skybox = materialDay;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (i < timer)
        {
            i += Time.deltaTime;
        }
        else
        {
            i = 0;
            isNight = !isNight;
            if (isNight)
            {
                RenderSettings.skybox = materialNight;
            }
            else
            {
                RenderSettings.skybox = materialDay;
            }
        }

    }
}
