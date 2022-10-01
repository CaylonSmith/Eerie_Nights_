using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        

    }

    private void Update()
    {
        transform.position +=transform.right * Time.deltaTime * speed;


       
    }


   void DestroyProjectile()
    {
        
        Destroy(gameObject);
    }

   

}
