using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public Transform firePoint;
    public GameObject shieldPrefab;
    

    public void ShieldOn()
    {
        var passShield = Instantiate(shieldPrefab);
        StartCoroutine(destroyShield(passShield));
    }

    IEnumerator destroyShield(GameObject passShield)
    {
        yield return new WaitForSeconds(2);

        Destroy(passShield);
    }

}
