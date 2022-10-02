using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public int playerhealth;
    public int Enemydamage;
    public int pExp;
    public playerData playerdata;
    public TextMeshProUGUI textMesh;

    



    private void Awake()
    {
       
        setPlayerValues();
    }
    private void Update()
    {



        if (playerhealth <= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("player"));
        }


        textMesh.text = pExp.ToString();
        Debug.Log(Enemydamage);

    }



    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("enemy"))
        {

            Enemydamage = collider.GetComponent<enemy>().damage;

            Debug.Log("pie");
            playerhealth -= Enemydamage;

        }


        if (collider.CompareTag("exp"))
        {
            pExp += 1;
         
        }



    }


    private void setPlayerValues()
    {



    
        playerhealth = playerdata.hp;
    }
}
   

