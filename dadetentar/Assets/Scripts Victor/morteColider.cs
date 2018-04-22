using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class morteColider : MonoBehaviour {

    [Header("PUBLIC")]

    public GameObject perdeu;
	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            if (Dash.protecaoDoDash == false) {
                perdeu.SetActive(true);

                Time.timeScale = 0;

                //SceneManager.LoadScene("Perdeu");
            }
        } 

    }
}
