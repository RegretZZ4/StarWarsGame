using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestroyEnemy_Special : MonoBehaviour
{
    bool hitted;
    int contHit;
    // Start is called before the first frame update
    void Start()
    {
        hitted = false;
        contHit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(LaserCollision.bouncedLaser);
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
            GameManager.scorePlayer -= 30;
        }

        if (other.gameObject.tag == "enemyLaser")
        {
            if (LaserCollision.bouncedLaser)
            {
                contHit++;
                if (contHit >= 4)
                {
                    contHit = 0;
                    Destroy(this.gameObject);

                    LaserCollision.bouncedLaser = false;

                }
            }
        }



    }

}
