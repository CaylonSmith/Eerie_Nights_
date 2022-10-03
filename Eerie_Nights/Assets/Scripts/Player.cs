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
    public int pdamage;
    public TextMeshProUGUI textMesh;
    public weapon _weapon;
    public int shmorecost;
    public int jumpupcost;
    public PlayerMovement pMOvement;
    public GameObject MyEnemy;
    public int Damageupgrade;
    public enemy _emmmy;
    public bool PlayerUpgradedDam = false;
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



    public void buyShootmore()
    {
        if (pExp >= shmorecost)
        {



            pExp -= shmorecost;
            _weapon.startTimebtwShots -= 0.3f;
            shmorecost += 2;


        }

    }



    public void buyJumpupgrade()
    {
        if (pExp >= jumpupcost)
        {



            pExp -= jumpupcost;
            pMOvement.jumpingPower += 0.8f;
            jumpupcost += 2;


        }

    }

    public void buyDameupgrade()
    {
        if (pExp >= Damageupgrade)
        {


            pExp -= Damageupgrade;
           
            pdamage += 1;
            Damageupgrade += 2;


        }

    }


    private void setPlayerValues()
    {


        pdamage = playerdata.damage;

        playerhealth = playerdata.hp;
    }
}
   

