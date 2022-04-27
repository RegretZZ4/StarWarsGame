using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyLaser : MonoBehaviour
{
    bool velzero;

    public bool hittedBySaber;

    GameObject imageHit;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LaserDestroy", 20f);
        velzero = false;
        hittedBySaber = false;

        imageHit = GameObject.FindGameObjectWithTag("RedSignal");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaserDestroy()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
            {
            if (hittedBySaber == true)
            {
                //var rigidbodyEnemy = other.gameObject.GetComponent<Rigidbody>();

                rb = other.gameObject.GetComponent<Rigidbody>();
                //var oppositeEnemy = -rigidbodyEnemy.velocity;

                //rigidbody.AddExplosionForce(100f, transform.position, 1f, 3f);

                //rigidbodyEnemy.AddForce(oppositeEnemy * 10000f);
                rb.AddForce(-transform.forward * 200f);
                //velzero = true;

                Invoke("VelocityZero", 0.5f);

                
                

                Debug.LogWarning("triggerEnemy");

                LaserCollision.bouncedLaser = false;
                hittedBySaber = false;

            }

        }


        if(other.gameObject.tag == "saber")
        {
            hittedBySaber = true;
        }

           
    }

    void VelocityZero()
    {
        if(rb != null)
        {
            rb.velocity = Vector3.zero;
        }


    }




}
