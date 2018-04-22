using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMoveV : MonoBehaviour
{

    public Camera camera;
    private Vector3 offset;
    public GameObject target;
    public static Vector3 posicao;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x + offset.magnitude - 5, 2, -1);
        transform.Translate(0.15f, 0f, 0f);
        posicao = this.gameObject.transform.position;
    }
}