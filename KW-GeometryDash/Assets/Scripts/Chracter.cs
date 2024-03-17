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
    private bool controlled;
    private float actualSpeed;
    
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        controlled = false;
        physicsBody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //Controlled //Controlled //Controlled //Controlled
        if (controlled)
        {
            
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
            
            if (OnGround && Input.GetKeyDown(KeyCode.Space))
            {
                physicsBody.velocity = new Vector2(physicsBody.velocity.x,jumpHeight);
                OnGround = false;
                jumped = true;
            }
            return;    
        }
        
        
        //Moving //Moving //Moving //Moving 
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
        
        
        //Random //Random //Random //Random //Random  
    }

    private void LateUpdate()
    {
        Camera.main.transform.position = this.transform.position + Vector3.back * 20 + Vector3.up * 4 + Vector3.left * 2;
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
    
    
    
    
    
   
    
    
    
}
