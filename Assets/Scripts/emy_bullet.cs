using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emy_bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)

    {
        Mk2 mk2 = hitInfo.GetComponent<Mk2>();
        if (mk2 != null)
        {
            mk2.TakeDamage(20);
        }
        Destroy(gameObject);
    }
}
