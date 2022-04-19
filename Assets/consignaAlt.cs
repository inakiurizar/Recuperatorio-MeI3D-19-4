using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consignaAlt : MonoBehaviour
{
    public int edad;
    public float altura;

    void Start()
    {
        if (edad < 1)
        {
            Debug.Log("Error");
        }
        else if (altura < 0)
        {
            Debug.Log("Error");
        }
        else
        {
            if (altura > 1.2 || edad > 13)
            {
                Debug.Log("Podes entrar");
            }
            else
            {
                Debug.Log("No podes entrar");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}