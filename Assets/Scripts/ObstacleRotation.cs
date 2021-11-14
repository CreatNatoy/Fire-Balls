using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleRotation : MonoBehaviour
{
    [SerializeField] private float _animationDuration;

    private void Start()
    {
        ObstacleLevels();
    }

    private void ObstacleLevels()
    {
        int level = SceneManager.GetActiveScene().buildIndex; 

        if(level == 1 || level == 2 || level == 5)
            transform.DORotate(new Vector3(0, 360, 0), _animationDuration, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
        else if (level == 3 || level == 4)
            transform.DORotate(new Vector3(0, 360, 0), _animationDuration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
    }
}
