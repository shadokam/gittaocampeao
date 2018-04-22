using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2moveV : MonoBehaviour {

    public static Vector3 posicaoPlayer2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0.15f, 0f, 0f);
        posicaoPlayer2 = this.gameObject.transform.position;
    }
}
