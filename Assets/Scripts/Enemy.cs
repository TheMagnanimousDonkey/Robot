using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
  
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    { 
        Instantiate(deathEffect, transform.position,Quaternion.identity);
        //gameObject.SetActive(false);
        // Destroy(gameObject);
        gameObject.transform.position = new Vector2(25f,25f);
        StartCoroutine(Delay());
        

    }

    IEnumerator Delay()
    {
       
        yield return new WaitForSeconds(2);
        
        Debug.Log("Why?");
        SceneManager.LoadScene("Hub");

    }
}
