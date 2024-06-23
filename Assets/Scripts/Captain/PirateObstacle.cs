using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PirateObstacle : MonoBehaviour
{

    private GameObject player;
    private Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player != null)
        {
            playerHealth = player.GetComponent<Health>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            if (playerHealth != null)
            {
                SceneManager.LoadScene("Cannoneer");
            }
        }
    }
}
