using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 5f;
    
    void Update()
    {
        transform.position += transform.forward * enemySpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "EnemyDestroyed")
        {
            this.gameObject.SetActive(false);

            Debug.Log("Enemigo destruido");
        }

        if(collider.gameObject.tag == "Bullet")
        {
            this.gameObject.SetActive(false);

            Debug.Log("Enemigo destruido");
        }
    }

}
