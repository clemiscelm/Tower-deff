using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onselect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tower;
    public Material videMat, baseMat, occupMat;
    public towerManager towerManager;
    public GameObject player;


    private void Start()
    {
        towerManager = GetComponent<towerManager>();
        player = GameObject.FindGameObjectWithTag("Player");
        if(towerManager == null)
            towerManager = player.GetComponent<towerManager>();
    }
    private void OnMouseOver()
    {
        if(tower != null)
            this.GetComponent<MeshRenderer>().material = occupMat;

        else
        {
            this.GetComponent<MeshRenderer>().material = videMat;

            if (Input.GetMouseButtonDown(0))
            {
                

                if (towerManager.towerSelect != null)
                    tower = (GameObject)Instantiate(towerManager.towerSelect, this.transform.position, this.transform.rotation);
                else
                    print("pas de tower select");
            }
        }


    }
    private void Update()
    {
        if (towerManager == null)
            towerManager = GetComponent<towerManager>();
    }
    private void OnMouseExit()
    {
        this.GetComponent<MeshRenderer>().material = baseMat;
    }
}
