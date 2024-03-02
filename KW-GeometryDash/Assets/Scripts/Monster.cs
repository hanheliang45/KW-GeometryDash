using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 My_position = this.transform.position;
        Vector2 told_Position = Chracter.instance.GetTransform().position + new Vector3(-6,0);
        My_position.x = told_Position.x;
    }
}
