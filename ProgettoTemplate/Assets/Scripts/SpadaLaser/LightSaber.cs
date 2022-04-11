using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightSaber : MonoBehaviour
{
    bool active;
    GameObject laser;
    Vector3 fullSize;

    bool isActive;
    int countActive;

    //public static Vector3 posUpdated;

    

    // Start is called before the first frame update
    void Start()
    {
        laser = transform.Find("SingleLine-LightSaber").gameObject;
        fullSize = laser.transform.localScale;
        laser.transform.localScale = new Vector3(0, 0, 0);

        isActive = false;
        countActive = 0;

        //HandInputHandler = GameObject.Find("XR Origin_custom").GetComponent<HandInputHandler>();
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

        //LaserController();

        

    }

    public void LaserController()
    {
        
        laser.SetActive(true);
        laser.transform.localScale = new Vector3(0.15f, 0.05f, 0.15f);
        countActive++;

        //posUpdated = this.transform.position;
            
        
    }



    public void ColliderDisable()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        laser.SetActive(true);
        //laser.GetComponent<CapsuleCollider>().enabled = false;
    }

    public void ColliderEnable()
    {
        //this.gameObject.GetComponent<BoxCollider>().enabled = true;
        
        if(countActive == 2)
        {
            if (laser.transform.localScale.y > 0)
            {
                laser.transform.localScale = new Vector3(0, 0, 0);
            }
            laser.SetActive(false);
            countActive = 0;
        }


        
        //laser.GetComponent<CapsuleCollider>().enabled = true;
    }

    public void KinematicFalse()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
    }

    public void KinematicTrue()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

}
