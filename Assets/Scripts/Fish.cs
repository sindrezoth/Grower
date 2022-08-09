using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField]
    float Speed = 1f;
    [SerializeField]
    SpriteRenderer sr;

    private float _orientation = 1f;

    void Start()
    {
        if(transform.position.x < 0)
        {
            _orientation = 1f;
            sr.flipX = true;
        }
        else
        {
            _orientation = -1f;
        }
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(_orientation * Speed, 0f, 0f);
        
    }

}
