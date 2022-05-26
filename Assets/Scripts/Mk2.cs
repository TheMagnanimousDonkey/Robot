using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mk2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float delay;
    [SerializeField] Transform groundCheckTransform;
    [SerializeField] LayerMask playerMask;
    private Rigidbody2D body;
    private Weapon w;
    public Animator animator;
    public Transform firePoint;
    public GameObject bulletPrefab;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
       

    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        animator.SetFloat("Movement", Mathf.Abs(body.velocity.x));
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            
            StartCoroutine(ShotDelay());
            
            }

        if (Physics2D.OverlapCircleAll(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            
            return;

        }
        
        if(Input.GetKey(KeyCode.W))
        body.velocity = new Vector2(body.velocity.x,speed);

    }

    IEnumerator ShotDelay()
    {
        
        animator.SetBool("Shoot", true);
        yield return new WaitForSeconds(delay);
        Shoot();
        animator.SetBool("Shoot", false);
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

