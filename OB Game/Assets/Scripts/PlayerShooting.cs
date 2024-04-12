using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerShooting : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject firePoint;
    public GameObject bullet;
    
    public float fireRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Shoot();
        }
    }
    void Update()
    {
    }
    void Shoot()
    {
        Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
    }
    
}
