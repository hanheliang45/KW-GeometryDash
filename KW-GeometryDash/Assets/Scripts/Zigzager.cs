using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zigzager : MonoBehaviour
{
    [SerializeField] private float ZigZagSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.GetComponent<Chracter>().ZigZag(ZigZagSpeed);
    }
}
