using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rBody;
    public GameObject bulletPrefab;
    public Transform[] gunPosition;
    public int ammoType;
    private SFXManager sfxManager;
    
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Direction = speed * Input.GetAxis("Horizontal") * Vector3.right;

        Vector3 Velocity = Direction * speed;
        
        rBody.velocity = Velocity;

        if(Input.GetButtonDown("Jump"))
        {
            foreach (Transform position in gunPosition)
            {
                GameObject bullet = PoolManager.Instance.GetPooledObjects(ammoType, position.position, position.rotation);
                bullet.SetActive(true);
            }

            sfxManager.BulletSound();
        }
    }
}
