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
    private float ZigZagSpeed;
    private bool OnGround;
    private bool jumped;
    private bool controlled;
    private float ZigZagingInOnWayClock;
    private float actualSpeed;
    
    private bool zigzaging;
    private bool zigzagingUp;
    private bool zigzagingDown;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        controlled = false;
        physicsBody = GetComponent<Rigidbody2D>();
        zigzagingDown = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Controlled //Controlled //Controlled //Controlled
        if (controlled)
        {
            zigzaging = false;
            
            if (Input.GetKey(KeyCode.A))
            {
                physicsBody.velocity += Vector2.left * (speed/20) ; 
                Debug.Log("Moving");
                return;
            }
            if (Input.GetKey(KeyCode.D))
            {
                physicsBody.velocity += Vector2.right * (speed/20) ;
                Debug.Log("Moving");
                return;
            }
            
            if (OnGround && Input.GetMouseButtonDown(0))
            {
                physicsBody.velocity = new Vector2(physicsBody.velocity.x,jumpHeight);
                OnGround = false;
                jumped = true;
            }
            return;    
        }

        //ZigZag //ZigZag //ZigZag //ZigZag //ZigZag 

        if (zigzaging)
        {
            controlled = false;

            ZigZagingInOnWayClock += Time.deltaTime;
            if (ZigZagingInOnWayClock >= 3)
            {
                Die();
            }
            if (Input.anyKeyDown) 
            {
                if (zigzagingUp)
                {
                    zigzagingUp = false;
                    zigzagingDown = true;
                }
                else 
                {
                    zigzagingDown = false;
                    zigzagingUp = true;
                }
            }
            if (zigzagingUp)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + ZigZagSpeed) * Time.deltaTime;
            }
            else 
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - ZigZagSpeed) * Time.deltaTime;
            }
        }
        
        //Moving //Moving //Moving //Moving 
        if (Input.GetMouseButtonDown(0))
        {
            if (OnGround)
            {
                physicsBody.velocity = new Vector2(physicsBody.velocity.x,jumpHeight);
                OnGround = false;
                jumped = true;
            }
        }
        actualSpeed = OnGround ? speed : speed / 1.5f;
        physicsBody.velocity = Vector2.right * actualSpeed + new Vector2(0, physicsBody.velocity.y);
        
        
        //Random //Random //Random //Random //Random  
    }

    private void LateUpdate()
    {
        Camera.main.transform.position = this.transform.position + Vector3.back * 20 + Vector3.up * 3 + Vector3.left * 2;
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

    public Vector3 GetPosition()
    {
        Vector3 character_p = this.transform.position;
        return character_p;
    }

    public void Controlled()
    {
        if (controlled)
        {
            controlled = false;
            return;
        }

        controlled = true;
    }

    public void ZigZag(float ZigZagSpeed) 
    {
        if (zigzaging) 
        {
            zigzaging = false;
            return;
        }
        zigzaging = true;
        this.ZigZagSpeed = ZigZagSpeed;
    }
    
    
    
   
    
    
    
}
