using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllDot : MonoBehaviour
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
        other.gameObject.GetComponent<Chracter>().Controlled();
        Debug.Log("controll!");
    }
}
