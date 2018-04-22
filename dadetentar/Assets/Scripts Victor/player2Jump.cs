using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Jump : MonoBehaviour {

    public float moveSpeed0;
    public float jumpForce;
    public static bool grounded;
    public LayerMask whatIsGround;
    private Rigidbody2D myRigidbody;
    private Collider2D myCollider;

    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update () {

    grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            myRigidbody.AddForce(new Vector2(0, -30), ForceMode2D.Impulse);
        }
    }
}
