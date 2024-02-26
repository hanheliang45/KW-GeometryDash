using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chracter : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpHeight;
    Rigidbody2D physicsBody;
    private bool OnGround;
    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();
        physicsBody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //KeyCodes//KeyCodes//KeyCodes
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (OnGround)
            {
                physicsBody.velocity = Vector3.up * jumpHeight;
                OnGround = false;
            }
        }


    }

    private void LateUpdate()
    {
        Camera.main.transform.position = this.transform.position + Vector3.back*20;
        physicsBody.velocity = speed * Vector2.right ;
       

    }

    public void TouchGround()
    {
        OnGround = true;
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }


}
