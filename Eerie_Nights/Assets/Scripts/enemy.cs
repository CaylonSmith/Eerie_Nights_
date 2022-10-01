using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] public int damage;
    [SerializeField] public float speed;
    public int pdamage;
    [SerializeField] public int health;

    [SerializeField] public EnemyData data;

    public playerData playerdater;

    public int playerhealth;

    public Player _player;


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

        if (health <= 0)
        {
            Destroy(gameObject);
        }



        if (playerhealth <= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("player"));
        }
    }

   private void chase()
    {
       transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("projectile"))
        {
            health -= pdamage;
        }
        else if (collider.CompareTag("player"))
        {
            Debug.Log("pie");
            playerdater.hp -= damage;
        }
    }

    private void setEnemyValues()
    {
        damage = data.damage;
        speed = data.speed;
        health = data.hp;
        pdamage = playerdater.damage;
        playerhealth = playerdater.hp;
    }
}