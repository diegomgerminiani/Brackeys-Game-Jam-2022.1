using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamController : MonoBehaviour
{
    void Update(){
        if (Input.GetKeyDown("1"))
        {
            Acordar();
        }

        if (Input.GetKeyDown("2"))
        {
            Sonhar();
        }
    }

    private void Sonhar()
    {
        print("Sonhando");
    }
    private void Acordar()
    {
        print("Acordando");
    }
}
