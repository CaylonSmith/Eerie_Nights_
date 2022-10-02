using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class experiance : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {

      

        if (collider.CompareTag("player"))
        {
          
            Destroy(gameObject);
        }

    }
   
}
