using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightSaber : MonoBehaviour
{
    bool active;
    GameObject laser;
    Vector3 fullSize;



    // Start is called before the first frame update
    void Start()
    {
        laser = transform.Find("SingleLine-LightSaber").gameObject;
        fullSize = laser.transform.localScale;
        laser.transform.localScale = new Vector3(fullSize.x, 0, fullSize.z);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(HandInputHandler.)
        {
            active = !active;
        }
        */



        LaserController();
    }

    private void LaserController()
    {
        if (laser.transform.localScale.y < fullSize.y && active)
        {
            laser.SetActive(true);
            laser.transform.localScale += new Vector3(0, 0.0001f, 0);
        }
        else if (laser.transform.localScale.y > 0 && !active)
        {
            laser.transform.localScale += new Vector3(0, -0.0001f, 0);
        }
        else if (!active)
        {
            laser.SetActive(false);
        }
    }
}
