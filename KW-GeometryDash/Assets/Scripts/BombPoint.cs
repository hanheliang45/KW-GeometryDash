using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != Chracter.instance.gameObject)
        {
            return;    
        }
        Monster.instance.Fire_Anim();
    }

} 
