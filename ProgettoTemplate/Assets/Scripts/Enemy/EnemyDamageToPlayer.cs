using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageToPlayer : MonoBehaviour
{
    public static int damage = 5;
    float range = 100f;



    //[SerializeField] Camera enemyCamera;

    

    int randomHit;

    float timer;

    bool playerHit;


    //Rigidbody rigidbody;
    [SerializeField] GameObject startPos;
    [SerializeField] GameObject laser_prefab;



    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        playerHit = false;


        //startPos = GameObject.FindGameObjectWithTag("LaserPos");
        // lineRenderer.GetComponent<LineRenderer>();

        

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > GameManager.shootTimer)
        {
            timer = 0;

            randomHit = Random.Range(0, 100);

            if(randomHit > 50 && randomHit < 90)
            {
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        
        RaycastHit hit;

        if (Physics.Raycast(startPos.transform.position, startPos.transform.forward, out hit, range))
        {
            Debug.Log("SPARA DRONE");
            LaserCollision.bouncedLaser = false;
            Debug.Log("SHOOT: " + hit.transform);

            GameObject laser = GameObject.Instantiate(laser_prefab, this.transform.position, transform.rotation) as GameObject;
            //  laser.GetComponent<>
            laser.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f);
            if(hit.transform.tag == "Player")
            {
                PlayerLifeManager.hitted = true;
                playerHit = true;


            }

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
            if (other.gameObject.tag == "enemyLaser")
            {
                var opposite = -rigidbody.velocity;
            //var opposite = laser.GetComponen
            //laser.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f);
                rigidbody.AddForce(opposite * Time.deltaTime);
            }

        */
        
    }

    /*
    void OnDrawGizmos()
    {
        GameObject target;

        target = GameObject.Find("Player");
        // Draw a yellow sphere at the transform's position

        if (playerHit)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, target.transform.position);
            playerHit = false;
        }
        
    }
    */
}
