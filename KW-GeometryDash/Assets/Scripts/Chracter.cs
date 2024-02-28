using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chracter : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpHeight;
    [SerializeField] private float fallSpeed;
    Rigidbody2D physicsBody;
    private bool OnGround;
    private bool jumped;
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
            Debug.Log(OnGround);
            if (OnGround)
            {
                Debug.Log("jumped");
                physicsBody.velocity = Vector3.up * jumpHeight;
                speed = speed / 3;
                OnGround = false;
            }
        }


    }

    private void LateUpdate()
    {
        Camera.main.transform.position = this.transform.position + Vector3.back*20;
        this.transform.position += speed * Time.deltaTime*new Vector3(1, 0, 0);
    }

    public void TouchGround()
    {
        OnGround = true;
        if (jumped)
        {
            speed *= 3;
            jumped = false;
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }


}
