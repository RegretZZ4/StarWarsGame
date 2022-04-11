using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollision : MonoBehaviour
{

    public static bool bouncedLaser;
    // Start is called before the first frame update
    void Start()
    {
        bouncedLaser = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemyLaser")
        {
           // Debug.LogWarning("lightsaber");
            var rigidbody = other.gameObject.GetComponent<Rigidbody>();
            var opposite = -rigidbody.velocity;
            rigidbody.AddForce(opposite * 100f);


            bouncedLaser = true;
        }


        


    }

    
    
    

}
