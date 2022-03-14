
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    int randomNum;

    float timer;

    [SerializeField] GameObject prefab_ref;
    [SerializeField] Transform lookAt_Player;
    GameObject enemy;

    int spawnWait = 3;

    GameObject findObj;
    

    private void Start()
    {
        randomNum = 0;
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnWait)
        {
            timer = 0;
            RandomGen();
        }
    }


    void RandomGen()
    {
        //Random random = new Random();
        randomNum = Random.Range(0, 3);
        Debug.Log(randomNum);

        if (randomNum == 0)
        {
            findObj = GameObject.Find("SpawnHolder_0");
            Debug.Log(findObj.name);

            enemy = prefab_ref;

            randomNum = Random.Range(0, 4);
            Instantiate(enemy, findObj.transform.position + new Vector3(randomNum, 0, 0), Quaternion.identity);
            enemy.transform.LookAt(lookAt_Player);


        }
        if (randomNum == 1)
        {
            findObj = GameObject.Find("SpawnHolder_1");
            Debug.Log(findObj.name);
            enemy = prefab_ref;

            randomNum = Random.Range(0, 4);
            Instantiate(enemy, findObj.transform.position + new Vector3(0, 0, randomNum), Quaternion.identity);

        }

        if (randomNum == 2)
        {
            findObj = GameObject.Find("SpawnHolder_2");
            Debug.Log(findObj.name);

            enemy = prefab_ref;

            randomNum = Random.Range(0, 4);
            Instantiate(enemy, findObj.transform.position + new Vector3(0, 0, randomNum), Quaternion.identity);


        }

    }
}