using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;       //Allows us to write code for the UI

public class GameManager : MonoBehaviour
{
    public GameObject panelWin;
    public Text score;

    bool gameEnded = false;     //Prevents EndGame from being called multiple times

    public void LevelWin()
    {
        gameEnded = true;
        Debug.Log("YOU WIN");
        panelWin.SetActive(true);
        score.enabled = false;
    }

    public void LevelLose()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 0.7f);
        }   
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Debug.Log("Game Exiting");
        Application.Quit();
    }
}
