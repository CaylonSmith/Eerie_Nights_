using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] public int damage;
    [SerializeField] public float speed;

    [SerializeField] public int health;

    [SerializeField] public EnemyData data; 


    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Awake()
    {

        player = GameObject.FindGameObjectWithTag("player");
        setEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        chase();
    }

   private void chase()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("projectile"))
        {
            
        }
    }

    private void setEnemyValues()
    {
        damage = data.damage;
        speed = data.speed;
        health = data.hp;
    }
}
