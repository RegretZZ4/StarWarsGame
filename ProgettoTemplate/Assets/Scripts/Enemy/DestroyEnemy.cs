using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestroyEnemy : MonoBehaviour
{
    bool hitted;
    // Start is called before the first frame update
    void Start()
    {
        hitted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        RaycastHit sphereHit;
        if (other.gameObject.tag == "destroy")
        {
            //OnDrawGizmosSelected();
            if (Physics.SphereCast(this.transform.position, 5f, this.transform.forward, out sphereHit, 100f) && !hitted)
            {
                Debug.Log("SPHERE CAST !! " + sphereHit.transform);

                //damage to player
                hitted = true;

            }

            Destroy(this.gameObject, 0.2f);
        }

        
        
    }

}
