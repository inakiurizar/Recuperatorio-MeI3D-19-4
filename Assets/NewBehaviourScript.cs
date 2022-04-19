using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float altura;
        public float edad;
    
    void Start()
    {
        if (edad < 1)
        {
            Debug.Log("Error");
        }
        else if (altura < 0)
        {
            Debug.Log("Error");
        } else
        {
            if (altura > 1.2)
            {
                Debug.Log("Podes entrar");
            }
            else if (edad > 13)
            {
                Debug.Log("Podes entrar");
            }
            else
            {
                Debug.Log("No podes entrar");
            }
        }
         
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
