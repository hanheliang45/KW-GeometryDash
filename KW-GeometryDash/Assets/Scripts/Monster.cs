using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public static Monster instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {  
        float position_x = Chracter.instance.GetTransform().position.x - 6;
        float position_y = this.transform.position.y;
        transform.position = new Vector3(position_x, position_y, 0);
    }

    public void Fire()
    {
        Debug.Log("Booooooom");     
    }
}
