using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJumpB : MonoBehaviour {

    [Header("variaveis")]
    public float alturaDoPulo;
    public float timingDoPulo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(pular());
        }
    }

    public IEnumerator pular()
    {
            transform.Translate(0f, alturaDoPulo, 0f);
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, alturaDoPulo, 0f); 
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, alturaDoPulo, 0f);
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, alturaDoPulo, 0f);
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, -alturaDoPulo, 0f);
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, -alturaDoPulo, 0f);
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, -alturaDoPulo, 0f);
            yield return new WaitForSeconds(timingDoPulo);
            transform.Translate(0f, -alturaDoPulo, 0f);
    }
}