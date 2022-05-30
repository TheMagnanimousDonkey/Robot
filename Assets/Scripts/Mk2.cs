using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mk2 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public int maxHealth = 100;
    public GameObject deathEffect;
    public HealthBar healthBar;
    public int currentHealth;


    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(currentHealth);


    }

    //Take Damage

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        //gameObject.SetActive(false);
        // Destroy(gameObject);
        gameObject.transform.position = new Vector2(225f, 25f);
        StartCoroutine(Delay());


    }

    IEnumerator Delay()
    {

        yield return new WaitForSeconds(2);


        SceneManager.LoadScene("Hub");

    }
}

