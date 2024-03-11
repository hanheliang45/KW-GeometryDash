using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public static Monster instance;
    [SerializeField] private Transform template_FireBall;
    private Animator animator;
    private float stopWatch;

    private void Awake()
    {
        instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
        float position_x = Chracter.instance.GetTransform().position.x - 10;
        float position_y = this.transform.position.y;
        transform.position = new Vector3(position_x, position_y, 0);
    }

    public void Fire_Anim()
    {
        Debug.Log("Booooooom");
        animator.SetBool("IsThrowing", true);
    }

    public void Fire()
    {
        Instantiate(template_FireBall,
            this.transform.position += new Vector3((float)4.56, (float)0.78, (float)-2.906496), Quaternion.identity);
    }

    public void Fired()
    {
        stopWatch += Time.deltaTime;
        Debug.Log("Fired");
        animator.SetBool("IsThrowing", false);
        animator.SetBool("IsWalking", true);
    }

}
