using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveV : MonoBehaviour {

    private Rigidbody2D rb2d;
    bool morrendo = false;


    public static Vector3 posicaoPlayer;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(0.15f, 0f, 0f);
        //posicaoPlayer = this.gameObject.transform.position;

        rb2d.velocity = new Vector2(10, rb2d.velocity.y);
    }

}
