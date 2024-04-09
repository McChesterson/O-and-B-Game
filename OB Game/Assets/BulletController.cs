using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 20;
    Rigidbody2D rb;
    public float range = 2;
    float rangeRemaining = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rangeRemaining += 1 * Time.deltaTime;
        if (rangeRemaining >= range)
        {
            Destroy(gameObject);
        }
    }
}
