using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tank : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private float _delayBetweemShoots;
    [SerializeField] private float _recoilDistance;
    [SerializeField] private SpawnerBull _spawnerBull;
    [SerializeField] private MusicEffects _musicEffects; 

    private float _timeAfterShoot;

    private void Update()
    {
        _timeAfterShoot += Time.deltaTime; 

        if(Input.GetMouseButton(0))
        {
            if(_timeAfterShoot > _delayBetweemShoots)
            {
                _spawnerBull.ActivateBullet(); 
                transform.DOMoveZ(transform.position.z - _recoilDistance, _delayBetweemShoots/2).SetLoops(2,LoopType.Yoyo);
                _timeAfterShoot = 0;
                _musicEffects.ShoutSound(); 
            }
        }
    }
}
