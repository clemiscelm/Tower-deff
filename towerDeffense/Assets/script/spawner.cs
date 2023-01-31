using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject zombies;

    public int latance = 3;
    public float time;
    public int nbSpawn = 10;
    public int nbSpawned = 0;


    void Update()
    {
       
        time += Time.deltaTime;

        if (time >= latance && nbSpawn > nbSpawned)
        {
            Instantiate(zombies);
            time = 0;
            nbSpawned++;
        }
        
        

    }




}
