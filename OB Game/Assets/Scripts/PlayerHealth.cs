using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseHealth(int amount)
    {
        currentHealth -= amount;
        print(gameObject.name + " lost " + amount + " health\ncurrent health = " + currentHealth);
    }
}
