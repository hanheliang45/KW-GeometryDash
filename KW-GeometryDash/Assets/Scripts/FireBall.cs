using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p_ = this.transform.position;
        if  (p_.y - Chracter.instance.GetTransform().position.y < 0.1 )
        {
            p_.x += speed;  
            return;
        }
        if  (p_.y - Chracter.instance.GetTransform().position.y > 0.1 )
        {
            p_.x += speed;     
            return;
        }
        if (Chracter.instance.GetTransform().position.y > transform.position.y)
        {
            
            p_.y += Time.deltaTime * -speed;
        }
        else
        {
            p_.y -= Time.deltaTime * speed;      
        }
            
    }
}
