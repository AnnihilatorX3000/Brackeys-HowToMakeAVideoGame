using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button btnNo;

    bool gamePaused = false;
    
    void PauseGame()
    {
        gamePaused = true;
        pauseMenu.SetActive(true);     
        btnNo.Select();     //Enables keyboard navigation
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        gamePaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
}
