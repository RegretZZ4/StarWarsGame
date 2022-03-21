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
        if (other.gameObject.tag == "destroy")
        {
            Destroy(this.gameObject);
        }
    }
}
