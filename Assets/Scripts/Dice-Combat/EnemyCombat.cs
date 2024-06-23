using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public Health playerHealth;  // Reference to the player's Health script
    public DiceController diceController; // Reference to the DiceController script
    public TurnManager turnManager; // Reference to the TurnManager script
    private Animator anim;

    private bool canTakeTurn = false;

    private void Start()
    {
        if (GetComponent<Animator>() != null)
        {
            anim = GetComponent<Animator>();
        }
    }

    void Update()
    {
        if (canTakeTurn)
        {
            float enemyRoll = diceController.RollDiceValue();
            Debug.Log("Enemy rolled: " + enemyRoll);

            // Apply damage to the player's health
            playerHealth.TakeDamage(enemyRoll);
            canTakeTurn = false;

            // End the enemy's turn
            if (anim != null)
            {
                Attack();
            }
            turnManager.EndEnemyTurn();
        }
    }

    public void EnableEnemyTurn()
    {
        canTakeTurn = true;
    }

    private void Attack()
    {
        // Trigger attack
        anim.SetTrigger("enemyattack");
    }
}
