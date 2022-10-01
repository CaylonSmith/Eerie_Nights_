using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   

    [SerializeField] public int health;
    public int damage;
    [SerializeField] public EnemyData data;
    public playerData pdata;


    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Awake()
    {

        setValues();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

   

   
        

    private void setValues()
    {
       
        health = pdata.hp;
      

    }
}
