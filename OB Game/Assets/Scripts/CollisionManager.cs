using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public ParticleSystem explodeParticles;
    PlayerHealth playerHP;

    void Start()
    {
        playerHP = GetComponent<PlayerHealth>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grav":
                OnCrash();
                break;
            case "Projectile":
                OnHit(collision.gameObject);
                break;
            default:
                print("Hit UFO");
                break;
        }
    }
    void OnCrash()
    {
        explodeParticles.Play();
        print("played particle effect");
    }
    void OnHit(GameObject projectile)
    {
        playerHP.LoseHealth(projectile.GetComponent<BulletController>().damage);
    }

    void Update()
    {
        
    }
}
