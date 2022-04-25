
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    int randomNum;

    float timer;
    float timer_specialEnemy;

    [SerializeField] GameObject prefab_ref;
    [SerializeField] GameObject specialEnemy_ref;
    
    //[SerializeField] Transform lookAt_Player;
    
    GameObject enemy;

    int spawnWait = 3;

    GameObject findObj;
    

    private void Start()
    {
        randomNum = 0;
        timer = 0;
        timer_specialEnemy = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        timer_specialEnemy += Time.deltaTime;

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
        // Debug.Log(randomNum);

        if (timer_specialEnemy < 30)
        {

            if (randomNum == 0)
            {
                findObj = GameObject.Find("SpawnHolder_0");
                //  Debug.Log(findObj.name);

                enemy = prefab_ref;

                randomNum = Random.Range(0, 4);
                Instantiate(prefab_ref, findObj.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                //enemy.transform.LookAt(lookAt_Player);


            }
            if (randomNum == 1)
            {
                findObj = GameObject.Find("SpawnHolder_1");
                Debug.Log(findObj.name);
                //enemy = prefab_ref;

                randomNum = Random.Range(0, 4);
                Instantiate(prefab_ref, findObj.transform.position + new Vector3(0, 0, 0), Quaternion.identity);

            }

            if (randomNum == 2)
            {
                findObj = GameObject.Find("SpawnHolder_2");
                Debug.Log(findObj.name);

                enemy = prefab_ref;

                randomNum = Random.Range(0, 4);
                Instantiate(prefab_ref, findObj.transform.position + new Vector3(0, 0, 0), Quaternion.identity);


            }
        }
        else
        {
            timer_specialEnemy = 0;

            if (randomNum == 0)
            {
                findObj = GameObject.Find("SpawnHolder_0");
                //  Debug.Log(findObj.name);

                enemy = specialEnemy_ref;

                randomNum = Random.Range(0, 4);
                Instantiate(specialEnemy_ref, findObj.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                //enemy.transform.LookAt(lookAt_Player);


            }
            if (randomNum == 1)
            {
                findObj = GameObject.Find("SpawnHolder_1");
                Debug.Log(findObj.name);
                
                enemy = specialEnemy_ref;

                randomNum = Random.Range(0, 4);
                Instantiate(specialEnemy_ref, findObj.transform.position + new Vector3(0, 0, 0), Quaternion.identity);

            }

            if (randomNum == 2)
            {
                findObj = GameObject.Find("SpawnHolder_2");
                Debug.Log(findObj.name);

                enemy = specialEnemy_ref;

                randomNum = Random.Range(0, 4);
                Instantiate(specialEnemy_ref, findObj.transform.position + new Vector3(0, 0, 0), Quaternion.identity);


            }
        }

    }
}