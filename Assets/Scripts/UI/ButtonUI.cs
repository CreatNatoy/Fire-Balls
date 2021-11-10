using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{   
    public void OnPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void OffPanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void TimeGame(float time)
    {
        Time.timeScale = time; 
    }

    public void LoadScene(int level)
    {
        if (level == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        else
            SceneManager.LoadScene(level);
        TimeGame(1f); 
    }

    public void ExitGame()
    {
        Application.Quit(); 
    }
}
