//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Health : MonoBehaviour
//{
//    [SerializeField]
//    private float startingHealth;
//    public float currentHealth { get; private set; }
//    private Animator anim;
//    private bool dead;

//    private void Awake()
//    {
//        currentHealth = startingHealth;
//        anim = GetComponent<Animator>();
//    }

//    public void TakeDamage(float _damage)
//    {
//        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

//        if (currentHealth > 0)
//        {
//            if (anim != null)
//            {
//                anim.SetTrigger("hurt");
//            }
//        }
//        else
//        {
//            if (!dead)
//            {
//                if (anim != null)
//                {
//                    anim.SetTrigger("die");
//                }
//                dead = true;
//            }
            
//        }
//    }

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.E))
//            TakeDamage(1);
//    }


//} //class
