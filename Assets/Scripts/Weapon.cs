using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public EnergyBar energyBar;
    public int currentEnergy;
    public int maxEnergy = 4;


    public void Start()
    {
        InvokeRepeating("AddEnergy", 3f, 3f);
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(currentEnergy);
    }
    public void Shoot()
    {
        Debug.Log("here");
        if (currentEnergy > 0)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            currentEnergy -= 1;
            energyBar.SetEnergy(currentEnergy);
        }

    }

    void AddEnergy()
    {
        if(currentEnergy < 4)
        currentEnergy++;
        energyBar.SetEnergy(currentEnergy);
    }
}
