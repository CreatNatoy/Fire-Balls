using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _bounceForse;
    [SerializeField] private float _bounceRadius; 

    private Vector3 _moveDirection;

    private void Start()
    {
        _moveDirection = Vector3.forward; 
    }

    private void Update()
    {
        transform.Translate(_moveDirection * _speed * Time.deltaTime); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Block block))
        {
            block.Break();
        }
        if(other.TryGetComponent(out Finish finish))
        {
            finish.FinishGame(); 
        }
        if (other.TryGetComponent(out Obstacle obstacle))
        {
            obstacle.GameOver();
        }
        Die(); 

    }

        private void Die()
        {
        gameObject.SetActive(false); 
        }

}
