using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;     //Prevents EndGame from being called multiple times
    public void EndGame()
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
}
