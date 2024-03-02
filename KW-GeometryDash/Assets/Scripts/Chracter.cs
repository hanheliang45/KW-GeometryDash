using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chracter : MonoBehaviour
{
    public static Chracter instance;
    [SerializeField] float speed;
    [SerializeField] float jumpHeight;
    [SerializeField] private float fallSpeed;
    Rigidbody2D physicsBody;
    private bool OnGround;
    private bool jumped;
    private float actualSpeed;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //KeyCodes//KeyCodes//KeyCodes
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnGround)
            {
                physicsBody.velocity = new Vector2(physicsBody.velocity.x,jumpHeight);
                OnGround = false;
                jumped = true;
            }
        }
        actualSpeed = OnGround ? speed : speed / 3;
        physicsBody.velocity = Vector2.right * actualSpeed + new Vector2(0, physicsBody.velocity.y);
    }

    private void LateUpdate()
    {
        Camera.main.transform.position = this.transform.position + Vector3.back*20;
    }

    public void TouchGround()
    {
        OnGround = true;
        if (jumped)
        {
            jumped = false;
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    public void LeaveJumpDot()
    {
        OnGround = false;
    }

    public Transform GetTransform()
    {
        return transform;
    }


}
