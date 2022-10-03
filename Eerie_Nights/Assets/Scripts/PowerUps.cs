using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{




    public weapon _weapon;
    public float shootingtime;
    public int shmorecost;
    public int jumpUpgradeCost;
    public GameObject PlayerM;












    public int Exp;

    private void Awake()
    {

   
      
       

    }

    // Update is called once per frame
    void Update()
    {

        Exp = PlayerM.GetComponent<Player>().pExp;
    }







    public void buyShootmore()
    {
        if (Exp >= shmorecost)
        {

           

            Exp -= 1;
            shootingtime -= 3;
            shmorecost += 1;
           

        } 

    }


    void jumpUpgrade()
    {
        if (Exp > jumpUpgradeCost)
        {
            shootingtime += 0.5f;

        }

    }











}
