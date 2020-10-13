using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damageable : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    private int health;
    
    // Start is called before the first frame update
    void Awake()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        //custom particles vonkjes bij de auto
        //custom particles van vuur bij de barrel
        health -= damage;
        if(health <= 0)
            Destroy(gameObject);
    }
}
