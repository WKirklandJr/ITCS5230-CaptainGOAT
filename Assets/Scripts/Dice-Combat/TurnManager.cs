using System.Collections;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public PlayerCombat playerCombat;
    public EnemyCombat enemyCombat;
    private bool isPlayerTurn = true;

    void Start()
    {
        // Start the player's turn
        StartCoroutine(PlayerTurn());
    }

    IEnumerator PlayerTurn()
    {
        isPlayerTurn = true;
        playerCombat.EnablePlayerTurn();

        // Wait until the player has taken their turn
        yield return new WaitUntil(() => !isPlayerTurn);

        // Start the enemy's turn
        StartCoroutine(EnemyTurn());
    }

    IEnumerator EnemyTurn()
    {
        isPlayerTurn = false;
        enemyCombat.EnableEnemyTurn();

        // Wait until the enemy has taken their turn
        yield return new WaitUntil(() => isPlayerTurn);

        // Start the player's turn again
        StartCoroutine(PlayerTurn());
    }

    public void EndPlayerTurn()
    {
        isPlayerTurn = false;
    }

    public void EndEnemyTurn()
    {
        isPlayerTurn = true;
    }
}
