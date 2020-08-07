using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float _movementStep;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetKey
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-_movementStep, 0, 0);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(_movementStep, 0, 0);
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, _movementStep, 0);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, -_movementStep, 0);
        }
    }
}

