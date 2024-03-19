using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    Transform template;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        //SceneManager.LoadScene(0);
        Debug.Log(template);
        Instantiate(template);
    }

    public void SetTemplate(Transform template) 
    {
        this.template = template;    
    }
}
