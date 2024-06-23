using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private GameObject player;
    private Health Health;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player != null)
        {
            Health = player.GetComponent<Health>();
        }
    }

    //Obstacle to remove from game and if the player collides with it
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            if (Health != null)
            {
                Health.TakeDamage(1);
            }
        }
    }
}
