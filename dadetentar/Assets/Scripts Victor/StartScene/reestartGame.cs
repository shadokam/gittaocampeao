using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class reestartGame : MonoBehaviour {

    public Text texto1;
    public Text texto2;
    public Text texto3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        texto1.text = goToGame.nome1;
        texto2.text = goToGame.nome2;
        texto3.text = goToGame.nome3;
	}

    public void letsGO() {
        Time.timeScale = 1;
        Application.LoadLevel("cena1victor");
    }

    public void letsGomenu() {
        Time.timeScale = 1;
        Application.LoadLevel("SetNames");
    }
}
