using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerManager : MonoBehaviour
{
    public GameObject[] towerGun;
    public GameObject[] towerLazer;
    public GameObject[] towerMachineGun;
    public GameObject[] towerRocket;
    int towerGunLvl = 0;
    int towerLazerLvl = 0;
    int towerMachineGunLvl = 0;
    int towerRocketLvl = 0;
    public GameObject towerSelect;


    public void chooseGun()
    {
        towerSelect = towerGun[towerGunLvl];
    }

    public void chooseLazer()
    {
        towerSelect = towerLazer[towerLazerLvl];
    }

    public void chooseMachineGun()
    {
        towerSelect = towerMachineGun[towerMachineGunLvl];
    }

    public void chooseRocket()
    {
        towerSelect = towerRocket[towerRocketLvl];
    }

}
