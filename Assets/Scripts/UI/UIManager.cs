using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] public AudioClip gameOverSound;

    private void Awake()
    {
        gameOverScreen.SetActive(false);
    }

    //Activate game over screen
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
      //  SoundManager.instance.PlaySound(gameOverSound);
    }

}
