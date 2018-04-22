using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLaser : MonoBehaviour {

    public GameObject leiser;
    private Vector3 target;
    public static bool move = true;

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        if (Lazer.laser)
        {
            if (Input.GetMouseButtonDown(0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
                if (move)
                {
                    Lazer.laser = false;
                    move = false;
                    Instantiate(leiser, target, Quaternion.identity);
                    transform.position = new Vector3(transform.position.x, transform.position.y, this.gameObject.transform.position.z);
                }
              
            }

            if (Input.GetMouseButtonUp(0)) {
                move = true;
            }
        }
    }
}
