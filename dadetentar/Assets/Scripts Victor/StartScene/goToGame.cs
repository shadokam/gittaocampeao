using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goToGame : MonoBehaviour {

    public InputField player1;
    public InputField player2;
    public InputField player3;
    public static string nome1;
    public static string nome2;
    public static string nome3;
    public GameObject aviso;
    private bool avisoTrue;

    // Use this for initialization
    void Start () {
        avisoTrue = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (avisoTrue == true) {
            aviso.SetActive(true);
        } 
	}

    public void startGame()
    {
        nome1 = player1.textComponent.text;
        nome2 = player2.textComponent.text;
        nome3 = player3.textComponent.text;
        if (nome1.Length > 9 || nome2.Length > 9 || nome3.Length > 9)
        {
            avisoTrue = true;
            Application.LoadLevel("setNames");
        } else {
            Application.LoadLevel("cena1Victor");
        }
    }
}
