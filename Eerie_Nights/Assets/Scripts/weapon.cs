using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public GameObject _projectile;

    public Transform shotPoint;
    public float timebtwShots;
    public float startTimebtwShots;
    public float speed;






    // Update is called once per frame
    void Update()
    {
       


        if (timebtwShots <= 0)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Instantiate(_projectile, shotPoint.position, transform.rotation);

               

                timebtwShots = startTimebtwShots;
            }
            
        }
        else
        {
            timebtwShots -= Time.deltaTime;
        }
    }


   
}
