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
        // This causes the bullet to ignore collisions with the firing gameObject, but we need something to turn it back on
        // after a frame or two if we want to to be able to come back and hit us.
        GameObject firedBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        Physics2D.IgnoreCollision(firedBullet.GetComponent<CircleCollider2D>(), gameObject.GetComponent<PolygonCollider2D>(), true);
        
    }
    
}
