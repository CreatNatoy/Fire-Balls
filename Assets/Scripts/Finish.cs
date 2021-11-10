using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _panelFinish;
    [SerializeField] private ButtonUI _buttonUI; 

    public void FinishGame()
    {
        if (PlayerPrefs.GetInt("level") < SceneManager.GetActiveScene().buildIndex)
            PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex);
        _buttonUI.OnPanel(_panelFinish);
        _buttonUI.TimeGame(0f); 

    }
}
