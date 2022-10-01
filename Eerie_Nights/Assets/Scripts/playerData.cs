using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "scriptableObjects/Player", order = 1)]


public class playerData : ScriptableObject
{
    public int hp;
    public int damage;
    public float speed;
    public float jumpingPower;
     


}
