using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Health : MonoBehaviour
{

    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }


  

    private void Awake()
    {
        currentHealth = startingHealth;
    }


    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //player hurt

        }
        else
        {
            //player dead
        }

    }

   
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    TakeDamage(1);
        //}

    }

    public void RefillHealth()
    {
        currentHealth = startingHealth; // Set current health back to maximum
    }


}

