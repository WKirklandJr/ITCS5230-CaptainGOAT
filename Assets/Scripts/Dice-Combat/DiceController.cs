using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    public Sprite[] diceSprites; // Array of dice sprites (dice_1.png, dice_2.png, ..., dice_6.png)
    private SpriteRenderer spriteRenderer;
    private bool isRolling;

    public Text resultText;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        isRolling = false;
    }

    void OnMouseDown()
    {
        if (!isRolling)
        {
            isRolling = true;
            StartCoroutine(RollDice());
        }
    }

    IEnumerator RollDice()
    {
        // Play your roll animation here
        

        // Wait for the animation to finish
        yield return new WaitForSeconds(.8f); // Adjust this value to match your animation duration

        // Animation event will trigger SetRandomSprite method
        
        isRolling = false;
    }

    // This method is called by the Animation Event at the end of the animation
    public void SetRandomSprite()
    {
        
        int randomNumber = Random.Range(1, 7);
        spriteRenderer.sprite = diceSprites[randomNumber - 1]; // Sprite indices are 0-based

        resultText.text = randomNumber.ToString();
    }

    // Method to roll the dice and return a float value between 0 and 1
    public float RollDiceValue()
    {
        float randomNumber = Random.Range(0f, 1f);
        return randomNumber;
    }

}


