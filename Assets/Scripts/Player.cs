using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject FieldOfMove;
    [SerializeField]
    SpriteRenderer sr;
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float Speed = 3f;

    private float _orientation = 1f;

    private void Update()
    {
        float dX = Speed * Input.GetAxis("Horizontal");
        float dY = Speed * Input.GetAxis("Vertical");

        //transform.Translate(new Vector3(dX, dY, 0) * Time.deltaTime);

        if(dX > 0)
        {
            _orientation = 1f;
            sr.flipX = true;
        }
        else if(dX < 0)
        {
            _orientation = -1f;
            sr.flipX = false;
        }
        else
        {

        }

        transform.position = transform.position + new Vector3(dX, dY, 0) * Time.deltaTime;
    }
}
