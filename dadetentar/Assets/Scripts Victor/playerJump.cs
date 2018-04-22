using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{

    public AudioClip jumpSound1;
    public AudioClip jumpSound2;

    private Animator animator;



    [Header("PUBLIC")]
    public static bool grounded;
    public LayerMask whatIsGround;
    private Rigidbody2D myRigidbody;
    private Collider2D myCollider;
    public GameObject player;
    public GameObject player2;
    public KeyCode tecla;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if (Troca.trocou == false)
        {
            tecla = KeyCode.W;
        }
        else
        {
            tecla = KeyCode.UpArrow;
        }

        if (Input.GetKeyDown(tecla))
        {
            SoundManager.instance.RandomizeSfx(jumpSound1, jumpSound2);
            if (grounded && this.gameObject == player.gameObject)
            {
                myRigidbody.AddForce(new Vector2(0, 40), ForceMode2D.Impulse);
                animator.SetBool("isJumpingBlue", true);
                animator.Play("isJumpingBlue");
            }

            if (grounded && this.gameObject == player2.gameObject)
            {
                myRigidbody.AddForce(new Vector2(0, -40), ForceMode2D.Impulse);
                animator.SetBool("isJumpingOrange", true);
                animator.Play("isJumpingOrange");
            }
        }
                animator.SetBool("isWalkingBlue", true);
                animator.SetBool("isJumpingBlue", false);

                animator.SetBool("isWalkingOrange", true);
                animator.SetBool("isJumpingOrange", false);

          }
    }