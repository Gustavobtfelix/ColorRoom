using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public int pos_x = 5;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        GetComponent<Renderer>().material.color = Color.blue;
        
        if(Input.GetKeyDown(KeyCode.W))
        GetComponent<Renderer>().material.color = Color.green;
    }
}
