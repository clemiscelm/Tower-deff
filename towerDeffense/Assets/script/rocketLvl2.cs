using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketLvl2 : MonoBehaviour
{

    public Transform target;
    public float range = 15f;
    public float speedRotate = 13f;

    public Transform partToRotate;
    public float x;
    
    void Start()
    {
        InvokeRepeating("updateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
            return;

        Vector3 dir = target.position - this.transform.position;

        Quaternion rot = Quaternion.LookRotation(dir);

        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, rot, Time.deltaTime * speedRotate).eulerAngles;

        partToRotate.rotation = Quaternion.Euler(x, rotation.y, 0);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);   
    }

    public void updateTarget()
    {
        GameObject[] ennemis = GameObject.FindGameObjectsWithTag("ennemis");

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnnemi = null;

        foreach(GameObject ennemy in ennemis)
        {
            float dist = Vector3.Distance(this.transform.position, ennemy.transform.position);
            if (dist < shortestDistance)
            {
                shortestDistance = dist;
                nearestEnnemi = ennemy;
            }
        }

        if (nearestEnnemi != null && shortestDistance <= range)
        {
            target = nearestEnnemi.transform;
        }
        else
            target = null;
    }
   
}
