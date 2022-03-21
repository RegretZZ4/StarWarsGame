using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeManager : MonoBehaviour
{
    public static int health;
    public static bool hitted;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
       // hitted = false;

    }

    // Update is called once per frame
    void Update()
    {
        HealthUpdate();
    }

    void HealthUpdate()
    {
        //if hitted by Enemy
        // health =- 10

        if (hitted)
        {
            health -= EnemyDamageToPlayer.damage;

            Debug.LogWarning("PLAYER HEALTH: " + health);

            hitted = false;
        }
    }
}
