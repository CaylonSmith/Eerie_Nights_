using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaen : MonoBehaviour
{
    public GameObject enemy;
    public int totalenemyspwan;
    public float intervel;
    public float counter;
    public int enemiesToSpawn;
    public GameObject spwner;


    // Update is called once per frame
    void Update()
    {
        stopEnemies();
        count();

        if (counter >= intervel)
        {
            spwanEnemy();
            counter -= intervel;


        }



    }



    private void count()
    {
        counter += 0.8f * Time.deltaTime;
    }

    private void spwanEnemy()
    {
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0), Quaternion.identity);
        totalenemyspwan += 1;
        goEnemies();
        intervel -= 35f;
        
    }

    private void stopEnemies()
    {
        if (totalenemyspwan >= enemiesToSpawn)
        {
            Destroy(gameObject);
        }
    }

    private void goEnemies()
    {
        spwner.SetActive(true);
    }
}
