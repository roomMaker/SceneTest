using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMan : MonoBehaviour
{
    private float _moveSpeed = 10f;
    private float _jumpSpeed = 0f;
    private float elapsedTime = 0f;

    private float _input;
    private bool _isJump;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _input = Input.GetAxisRaw("Horizontal");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isJump == false)
        {
            _isJump = true;
        }
        Jump();
        Turn();
        Move();
    }
    private void Turn()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
    
    private void Move()
    {
        Vector3 move = new Vector3(_input * _moveSpeed * Time.fixedDeltaTime, _jumpSpeed * Time.fixedDeltaTime, 0f);
        _rigidbody.MovePosition(transform.position + move);
    }

    private void Jump()
    {
        if(_isJump)
        {
            _jumpSpeed = 10f;
            elapsedTime += Time.deltaTime;
            if (elapsedTime > 0.5f)
            {
                _jumpSpeed = 0f;
            }
            if(elapsedTime > 1f)
            {
                _isJump = false;
                elapsedTime = 0f;
            }
        }
    }
}
