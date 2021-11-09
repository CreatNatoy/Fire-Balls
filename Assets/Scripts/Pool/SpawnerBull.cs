using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBull : ObjectPool
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        Intialize(_bulletPrefab); 
    }

    public void ActivateBullet()
    {
        if(TryGetObject(out GameObject bullet))
        {
            SetBullet(bullet, _spawnPoint.position);
        }
    }

    private void SetBullet(GameObject bullet, Vector3 spawnPoint)
    {
        bullet.SetActive(true);
        bullet.transform.position = spawnPoint; 
    }
}
