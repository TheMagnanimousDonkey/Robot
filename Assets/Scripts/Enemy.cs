using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public GameObject deathEffect;
    public HealthBar healthBar;
    public int currentHealth;

     void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(currentHealth);
    }
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
        Instantiate(deathEffect, transform.position,Quaternion.identity);
        //gameObject.SetActive(false);
        // Destroy(gameObject);
        gameObject.transform.position = new Vector2(225f,25f);
        StartCoroutine(Delay());
        

    }

    IEnumerator Delay()
    {
       
        yield return new WaitForSeconds(2);
        
        
        SceneManager.LoadScene("Hub");

    }
}
