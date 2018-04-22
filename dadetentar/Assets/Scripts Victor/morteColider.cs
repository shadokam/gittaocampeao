using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class morteColider : MonoBehaviour {

    [Header("PUBLIC")]

<<<<<<< HEAD
    public GameObject perdeu;
	// Use this for initialization
	void Start () {
        
=======
    public static float unscaledDeltaTime;

    // Use this for initialization
    void Start () {
>>>>>>> 151c2ff5a5561a32ff014d28fb60f61929ffada5
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
