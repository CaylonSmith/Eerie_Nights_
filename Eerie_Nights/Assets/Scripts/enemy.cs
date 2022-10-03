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
    public int expp;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        pdamage = Myplayer.GetComponent<Player>().pdamage;
       
    }
    private void Awake()
    {

     
        setEnemyValues();
    
    }


        // Update is called once per frame
        void Update()
    {
        chase();

        player = GameObject.FindGameObjectWithTag("player");



        expp = player.GetComponent<Player>().pExp;


        if (health <= 0)
        {
            GameObject newExp = Instantiate(Exp, transform.position, Quaternion.identity);

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
            health -= pdamage;
        }

    }
        private void setEnemyValues()
        {
            damage = data.damage;
            speed = data.speed;
            health = data.hp;
        player = GameObject.FindGameObjectWithTag("player");
        playerhealth = playerdater.hp;
        }






    public void buyDameupgrade()
    {
        if (expp>= Damageupgrade)
        {


            expp -= Damageupgrade;

            pdamage++;
            Damageupgrade += 2;


        }

    }






}
