using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody2D rb;
    public int damage = 10;
    [Header("Movement")]
    public float bulletSpeed = 20;
    public float range = 2;
    public float GravStrength = 10;
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
        ApplyGravity();
    }
    void ApplyGravity()
    {
        GameObject[] gravObjects;
        gravObjects = GameObject.FindGameObjectsWithTag("Grav");
        for (int i = 0; i < gravObjects.Length; i++)
        {
            Vector2 objectPos = new Vector2(gravObjects[i].transform.position.x, gravObjects[i].transform.position.y);
            Vector2 gravVector = objectPos - new Vector2(rb.transform.position.x, rb.transform.position.y);
            float gravDistance = gravVector.magnitude;
            rb.velocity += Mathf.Pow(1.0f / gravDistance, 2.0f) * gravVector.normalized * GravStrength * Time.fixedDeltaTime;
        }
    }
}
