using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float shootTimer;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        shootTimer = 3f;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(shootTimer);

        timer += Time.deltaTime;

        if(timer >= 300f)
        {
            shootTimer = 2f;
        }

        if(timer >= 600f)
        {
            shootTimer = 1f;
        }
        // se difficolta livello = 1, velocita' = 3
        // se diff lv == 2, velocita' = 2
        // se diff lv == 3, velocita' = 1
    }
}
