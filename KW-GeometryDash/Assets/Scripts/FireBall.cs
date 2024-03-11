using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool targeted;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Follow();
    }
    private void Follow()
    {
        Vector3 p_My = this.transform.position;

        p_My.x += Time.deltaTime * speed / 1.5f;


        if (targeted)
        {
            Debug.Log("carefull!");
            p_My.x += Time.deltaTime * speed;
        }
        else
        {

            if (p_My.y - Chracter.instance.GetTransform().position.y > -0.1 &&
                p_My.y - Chracter.instance.GetTransform().position.y < 0.1)
            {
                Debug.Log("carefull!");
                targeted = true;
            }

            if (Chracter.instance.GetTransform().position.y > transform.position.y)
            {

                p_My.y += Time.deltaTime * speed;
            }
            else
            {
                p_My.y -= Time.deltaTime * speed;
            }
        }

        this.transform.position = p_My;
    }
}


