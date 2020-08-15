using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {
    [SerializeField] private GameObject PauseMenuUI;
    [SerializeField] private bool isPaused;
    private void Start()
    {
        PauseMenuUI.SetActive(false);
    }
    public void Pausebutton()
    {
        isPaused = !isPaused;
        if(isPaused)
        {
            ActivateMenu();
        }
        
    }
    public void ResumeButton()
    {
        isPaused = false;
        DeactivateMenu();
    }
    public void QuitButton()
    {
        SceneManager.LoadScene("LevelScreen");
        Time.timeScale = 1;
        PlayerCollide.attemps = 0;
    }
    void ActivateMenu()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
    }
    void DeactivateMenu()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }
}
