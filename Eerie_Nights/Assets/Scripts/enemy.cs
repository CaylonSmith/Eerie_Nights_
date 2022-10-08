using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] public int damage;
    [SerializeField] public float speed;
    public int pdamage;
    [SerializeField] public int health;
    public GameObject Exp;
    [SerializeField] public EnemyData data;
    public int playerhealth;
    public playerData playerdater;
    public GameObject Myplayer;
    public int Damageupgrade;
    public float expp;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      
        player = GameObject.FindGameObjectWithTag("player");

    }
    private void Awake()
    {

     
        setEnemyValues();
    
    }


        // Update is called once per frame
        void Update()
    {
        chase();





        expp = player.GetComponent<Player>().pExp;


        if (health <= 0)
        {
            GameObject newExp = Instantiate(Exp, transform.position, Quaternion.identity);
            playerhealth += 1;
            Destroy(gameObject);

        }




        //  if (playerhealth <= 0)
        //{
        //  Destroy(GameObject.FindGameObjectWithTag("player"));
        //}
    }

    private void chase()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("projectile"))
        {
            pdamage = GameObject.FindGameObjectWithTag("player").GetComponent<Player>().pdamage;
            health -= pdamage;
        }

    }
        private void setEnemyValues()
        {
            damage = data.damage;
            speed = data.speed;
            health = data.hp;
     
        playerhealth = playerdater.hp;
        }






    public void buyDameupgrade()
    {
        if (expp>= Damageupgrade)
        {


            expp -= Damageupgrade;
            pdamage = Myplayer.GetComponent<Player>().pdamage;
            pdamage++;
            Damageupgrade += 2;


        }

    }






}
