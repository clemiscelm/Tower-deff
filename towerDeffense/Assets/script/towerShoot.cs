using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerShoot : MonoBehaviour
{

    public GameObject projectile;

    public TowerRotate TowerRotate;
    public bool readyToShoot = true;
    public float start;
    public float cd = 5.0f;

    private void Update()
    {
        shooting();
    }
    void Start()
    {
        TowerRotate = GetComponentInParent<TowerRotate>();
        start = Time.deltaTime;
    }

    // Update is called once per frame
    public void shooting()
    {
        if(TowerRotate.target != null && readyToShoot)
        {
            start = Time.deltaTime;
            Instantiate(projectile, this.transform.position, this.transform.rotation);
            readyToShoot = false;
            StartCoroutine(wait());
        }
    }

   IEnumerator wait()
    {
        yield return new WaitForSeconds(cd);
        readyToShoot = true;
    }
}
