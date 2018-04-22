using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public static bool ganhou = false;

    void Start()
    {
        ganhou = false;
    }

    void OnTriggerEnter2D()
    {
        ganhou = true;
    }
}