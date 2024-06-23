using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;


    // Start is called before the first frame update
    void Start()
    {
        totalHealthBar.fillAmount = health.currentHealth / health.startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealthBar.fillAmount = health.currentHealth / health.startingHealth;
    }
}
