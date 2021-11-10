using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLevel : MonoBehaviour
{
    [SerializeField] private Button[] _buttonLevels; 
    private void Start()
    {
        if(PlayerPrefs.HasKey("level"))
        {
              for(int i = 0; i < _buttonLevels.Length; i++)
            {
                if (i < PlayerPrefs.GetInt("level"))
                    _buttonLevels[i].interactable = true;
                else
                    _buttonLevels[i].interactable = false; 
            }
        }
    }
}
