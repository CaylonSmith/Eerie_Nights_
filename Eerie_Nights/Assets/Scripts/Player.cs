using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int playerhealth;
    public int Enemydamage;
    public float pExp;
    public playerData playerdata;
    public int pdamage;
    public TextMeshProUGUI textMesh;
    public weapon _weapon;
    public int shmorecost;
    public int jumpupcost;
    public int speedcost;
    public PlayerMovement pMOvement;
    public GameObject MyEnemy;
    public int Damageupgrade;
    public enemy _emmmy;
    public bool PlayerUpgradedDam = false;
    public int maxUpgrade;
    public int setUpgradeMax;
    public string shopButtons;
    public int maxUpgrade1;
    public int maxUpgrade2;
    public int maxUpgrade3;
    public int maxUpgrade4;
    public TextMeshProUGUI _maxUpgrade1;
    public TextMeshProUGUI _maxUpgrade2;
    public TextMeshProUGUI _maxUpgrade3;
    public TextMeshProUGUI _maxUpgrade4;
    public TextMeshProUGUI shmorecost_;
    public TextMeshProUGUI jumpupcost_;
    public TextMeshProUGUI speedcost_;
    public TextMeshProUGUI DamageupgradeCost_;
    public TextMeshProUGUI _playerhealth;
    public int totalEnemiesToKill = 54;
    

    private void Awake()
    {


        setPlayerValues();
    }
    private void Update()
    {

       if (maxUpgrade >= setUpgradeMax)
        {
            Destroyshop(shopButtons);
        }

        if (playerhealth <= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("player"));
            SceneManager.LoadScene(2);
        }

        updatehealth_exp();

        updateAbilities();

        checkEnemies();

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
            pExp += 0.5f;
         
        }



    }



    public void buyShootmore()
    {
        if (pExp >= shmorecost)
        {


            maxUpgrade += 1;

            pExp -= shmorecost;
            _weapon.startTimebtwShots -= 0.5f;
            shmorecost += 1;
            maxUpgrade4 += 1;

        }

    }



    public void buySpeed()
    {
        if (pExp >= speedcost)
        {


            maxUpgrade += 1;
            pExp -= speedcost;
            pMOvement.speed+=0.8f;
            speedcost += 1;
            maxUpgrade2 += 1;


        }

    }



    public void buyJumpupgrade()
    {
        if (pExp >= jumpupcost)
        {
            maxUpgrade += 1;


            pExp -= jumpupcost;
            pMOvement.jumpingPower += 0.8f;
            jumpupcost += 1;
            maxUpgrade3 += 1;

        }

    }





    public void buyDameupgrade()
    {
        if (pExp >= Damageupgrade)
        {
            maxUpgrade += 1;

            pExp -= Damageupgrade;
           
            pdamage += 1;
            Damageupgrade += 1;
            maxUpgrade1 += 1;

        }

    }


    private void setPlayerValues()
    {


        pdamage = playerdata.damage;

        playerhealth = playerdata.hp;
    }




   

    private void Destroyshop(string tag)
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("shop");
        foreach ( GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
        }
    }


    private void updatehealth_exp()
    {
        textMesh.text = pExp.ToString();


        _playerhealth.text = playerhealth.ToString();
    }



    private void updateAbilities()
    {
        DamageupgradeCost_.text = Damageupgrade.ToString();
        _maxUpgrade1.text = maxUpgrade1.ToString();

        speedcost_.text = speedcost.ToString();
        _maxUpgrade2.text = maxUpgrade2.ToString();

        jumpupcost_.text = jumpupcost.ToString();
        _maxUpgrade3.text = maxUpgrade3.ToString();

        shmorecost_.text = shmorecost.ToString();
        _maxUpgrade4.text = maxUpgrade4.ToString();
    }


    private void checkEnemies()
    {
        if (totalEnemiesToKill <=0)
        {
            SceneManager.LoadScene(3);
        }
    }

}
   

