using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner2 : MonoBehaviour
{
    public GameObject enemy;
    public int totalenemyspwan;
    public float intervel;
    public float counter;
    public int enemiesToSpawn;



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
        intervel -= 1.8f;

    }

    private void stopEnemies()
    {
        if (totalenemyspwan >= enemiesToSpawn)
        {
            Destroy(gameObject);
        }
    }
}
