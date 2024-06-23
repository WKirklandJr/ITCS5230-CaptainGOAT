using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Transform currentCheckpoint;
    private Health playerHealth;
    private UIManager uiManager;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        CheckHealth();
    }


    public void CheckHealth()
    {
        if (playerHealth.currentHealth == 0)
        {
            
            if (GetComponent<PlayerShipMovement>() != null)
            {
                GetComponent<PlayerShipMovement>().enabled = false;
                uiManager.GameOver();
                Destroy(this.gameObject);
                return;
            }
            else
            {
                uiManager.GameOver();
                return;
            }
        }
    }


} //class
