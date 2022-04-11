using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //[SerializeField] Transform player;
    GameObject player;
    [SerializeField] NavMeshAgent nv_enemy;

    GameObject lookAt;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        lookAt = GameObject.FindGameObjectWithTag("lookAt");
    }

    // Update is called once per frame
    void Update()
    {
        nv_enemy.SetDestination(player.transform.position);
        
        this.transform.LookAt(lookAt.transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "saber")
        {

            Destroy(this.gameObject);
        }
    }


    /*

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.LogWarning("robot distrutto");
            Destroy(this.gameObject);
        }
    }

    

    */


}
