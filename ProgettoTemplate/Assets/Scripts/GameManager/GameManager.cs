using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static float shootTimer;

    public static int scorePlayer;

    [SerializeField] TMP_Text score_int;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        shootTimer = 3f;
        timer = 0f;

        scorePlayer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score_int.text = scorePlayer.ToString();

        timer += Time.deltaTime;

        if(timer >= 100f)
        {
            shootTimer = 2f;
        }

        if(timer >= 200f)
        {
            shootTimer = 1f;
        }
        // se difficolta livello = 1, velocita' = 3
        // se diff lv == 2, velocita' = 2
        // se diff lv == 3, velocita' = 1
    }
}
