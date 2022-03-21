using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageToPlayer : MonoBehaviour
{
    public static int damage = 5;
    float range = 100f;

 
    [SerializeField] Camera enemyCamera;

    int randomHit;

    float timer;



    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
       // lineRenderer.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3)
        {
            timer = 0;

            randomHit = Random.Range(0, 5);

            if(randomHit == 2)
            {
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(enemyCamera.transform.position, enemyCamera.transform.forward, out hit, range))
        {
            Debug.Log("SHOOT: " + hit.transform);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        RaycastHit sphereHit;
        if (other.gameObject.tag == "destroy")
        {
            //OnDrawGizmosSelected();
            if (Physics.SphereCast(this.transform.position, 5f, this.transform.forward, out sphereHit, range))
            {
                Debug.Log("SPHERE CAST !! " + sphereHit.transform);
                
                

            }
            Invoke("DestroyEnemy", 0.3f);



        }
    }

    void DestroyEnemy()
    {
        Destroy(this.transform.parent.gameObject);
    }

    void OnDrawGizmos()
    {
        GameObject target;

        target = GameObject.Find("Player");
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, target.transform.position);
    }
}
