using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the same GameObject
        animator = GetComponent<Animator>();
        
    }

    void OnMouseDown()
    {
        // Check if the Animator component is found
        if (animator != null)
        {
            // Trigger the animation
            animator.SetTrigger("RollDie");
            
        }
        
    }
}

