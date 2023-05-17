using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10;

    void Update()
    {
        transform.Translate(Controller.Instance.GetMoveDirection(transform) * _speed * Time.deltaTime);
    }

}