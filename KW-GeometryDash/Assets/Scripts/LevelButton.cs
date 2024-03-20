using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    [SerializeField] Transform board;
    Transform template;
    public static LevelButton instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene(0);
        Debug.Log(template);
        board.gameObject.SetActive(false);
        
    }

    public void SetTemplate(Transform template) 
    {
        this.template = template;    
    }
}
