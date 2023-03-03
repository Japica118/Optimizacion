using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private Rigidbody rBody;
   [SerializeField] private float bulletSpeed = 5f;

   void Start()
   {
        rBody = GetComponent<Rigidbody>();
   }

    // Update is called once per frame
    void FixedUpdate()
    {
        rBody.velocity = transform.forward * bulletSpeed;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Enemy")
        {
            this.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.tag == "BulletDestroyed")
        {
            this.gameObject.SetActive(false);
        }
    }

}
