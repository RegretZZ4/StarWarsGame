using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    bool velzero;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LaserDestroy", 20f);
        velzero = false;
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
            if (LaserCollision.bouncedLaser == true)
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

            }
        }
    }

    void VelocityZero()
    {
        rb.velocity = Vector3.zero;
        Debug.LogError("ciao");


    }


}
