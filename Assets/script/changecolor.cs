using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    private bool tempo = true;    
    private void FixedUpdate()
    {
        if (tempo)
        {
            StartCoroutine(ExampleCoroutine());
            tempo = false;
        }
    }
    public void MudaCor(bool cor = true)
    {
        if (cor == true)
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        else
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called. color red
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        MudaCor(true);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);

        //After we have waited seconds print the time again. color blue
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        MudaCor(false);
        yield return new WaitForSeconds(0.5f);
        tempo = true;
    }
}
