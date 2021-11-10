using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation; 

    private void Update()
    {
        transform.Rotate(new Vector3(0f, _speedRotation, 0f) * Time.deltaTime);
    }
}
