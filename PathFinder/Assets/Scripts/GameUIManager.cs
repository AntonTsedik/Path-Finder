using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject gameWinScreen;
    [SerializeField] GameTime gameTime;
    private void Start()
    {
        gameTime.StartStopwatch();
    }

    public void SetGameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
        gameTime.StopStopwatch();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetGameWin()
    {
        gameWinScreen.SetActive(true);
        Time.timeScale = 0;
        gameTime.StopStopwatch();
    }

    public void NextLevel()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex + 1 >= SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(0);
        else
            SceneManager.LoadScene(currentSceneIndex + 1);
        Time.timeScale = 1;
    }
}
