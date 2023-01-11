using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject arCamera, Scope;
    [SerializeField] private GameObject[] Randomtarget;
    [SerializeField] private GameObject bullet;

    [SerializeField] private Bullet ScriptBullet;

    

    private RaycastHit hit;

    private float RandomTime;


    private void Start()
    {
        RandomTime = Random.Range(1, 3);
    }

    private void Update()
    {
        RandomTime -= Time.deltaTime;
        if(RandomTime <= 0)
        {
            createEnemy();
            RandomTime = Random.Range(1, 3);
        }
    }

    public void DoShoot()
    {
        GameObject newBullet = Instantiate(bullet, arCamera.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
        newBullet.GetComponent<Rigidbody>().AddForce(arCamera.transform.forward * 1500);
        Destroy(newBullet, 1f);
        
    }


    private void createEnemy()
    {
        int posArray = Random.Range(0, 5);

        float posX = Random.Range(-5, 5);
        float posY = Random.Range(3, 4);
        float posZ = Random.Range(2, 4);

        Vector3 posEnemy = new Vector3(posX, posY, posZ);
        Instantiate(Randomtarget[posArray], posEnemy, Quaternion.Euler(0, -179.802f,0));
    }


   
    
}
