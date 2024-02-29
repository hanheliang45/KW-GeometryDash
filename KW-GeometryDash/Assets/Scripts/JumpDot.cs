using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        Debug.Log("Canjump");
        collision.gameObject.GetComponent<Chracter>().TouchGround();    
    }
    //
    //
    // private void OnTriggerExit(Collider other)
    // {
    //     other.gameObject.GetComponent<Chracter>().LeaveJumpDot();
    // }
}
