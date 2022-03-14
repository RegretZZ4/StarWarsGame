using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //[SerializeField] Transform player;
    GameObject player;
    [SerializeField] NavMeshAgent nv_enemy;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        nv_enemy.SetDestination(player.transform.position);
    }
}
