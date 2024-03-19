using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    [SerializeField] GameObject chracter;
    void Start()
    {
        Instantiate(chracter, transform.position, Quaternion.identity);
        chracter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
