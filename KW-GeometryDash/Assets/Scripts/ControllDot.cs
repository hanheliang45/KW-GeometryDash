using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllDot : MonoBehaviour
{
    [SerializeField] private Transform rotater;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotater.rotation = Quaternion.Euler(0,0,rotater.rotation.z + 10);    
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Chracter>().Controlled();
        Debug.Log("controll!");
        Destroy(this.gameObject);
    }
}
