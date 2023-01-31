using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombies : MonoBehaviour
{

    int pv = 15;

    public void getHit(int nb)
    {
        if(pv < nb)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            print("finish");
            Destroy(gameObject);
        }
    }
}
