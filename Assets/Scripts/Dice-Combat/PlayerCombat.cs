using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Health enemyHealth;  // Reference to the enemy's Health script
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
        if (canTakeTurn && Input.GetKeyDown(KeyCode.Space))
        {
            float playerRoll = diceController.RollDiceValue();
            Debug.Log("Player rolled: " + playerRoll);

            // Apply damage to the enemy's health
            enemyHealth.TakeDamage(playerRoll);
            canTakeTurn = false;

            // Trigger attack if animator present & End the player's turn
            if (anim != null)
            {
                Attack();
            }
            turnManager.EndPlayerTurn();
        }
    }

    public void EnablePlayerTurn()
    {
        canTakeTurn = true;
    }

    private void Attack()
    {
        // Trigger attack
        anim.SetTrigger("attack");
    }
}
