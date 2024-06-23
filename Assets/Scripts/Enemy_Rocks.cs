using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Rocks : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerShip")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }

} // class
