using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private ButtonUI _buttonUI; 

    public void GameOver()
    {
        _buttonUI.OnPanel(_panelGameOver);
        _buttonUI.TimeGame(0f); 
    }

}
