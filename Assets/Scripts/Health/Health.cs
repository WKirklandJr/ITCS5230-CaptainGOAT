using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    public float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        Debug.Log("Starting Health: " + startingHealth);
        Debug.Log("Current Health: " + currentHealth);
        anim = GetComponent<Animator>();
    }

    // Method to take damage and update current health
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            if (anim != null)
            {
                anim.SetTrigger("hurt");
            }
        }
        else
        {
            if (!dead)
            {
                if (anim != null)
                {
                    anim.SetTrigger("die");
                }
          

                // Check the tag of the GameObject and load the appropriate scene
                if (CompareTag("Player"))
                {
                    
                    dead = true; 
                }
                else if (CompareTag("Enemy"))
                {
                    // Load the scene for enemy's defeat
                    SceneManager.LoadScene("Captain"); 
                }
            }
            
        }

        Debug.Log($"{gameObject.name} took {_damage} damage. Current health: {currentHealth}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TakeDamage(1);
    }


} //class
