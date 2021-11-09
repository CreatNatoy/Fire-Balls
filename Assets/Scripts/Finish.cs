using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _panelFinish;
    [SerializeField] private ButtonUI _buttonUI; 

    public void FinishGame()
    {
        Debug.Log("Finish");
        _buttonUI.OnPanel(_panelFinish);
        _buttonUI.TimeGame(0f); 

    }
}
