using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Troca : MonoBehaviour {

    public AudioClip changeSound1;
    public AudioClip changeSound2;

    [Header("Normal Variables")]

    public static bool trocou;
    public Button botao;
    public GameObject imgDash;
    public GameObject imgJump;
    private bool inverter = true;

	// Use this for initialization
	void Start () {
        trocou = false;
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

    public void Ativar() {
        trocou = !trocou;
        SoundManager.instance.RandomizeSfx(changeSound1, changeSound2);
        if (inverter == true)
        {
            imgDash.GetComponent<Animator>().SetTrigger("go1");
            imgJump.GetComponent<Animator>().SetTrigger("go1");
            inverter = false;
        }
        else {
            imgDash.GetComponent<Animator>().SetTrigger("go2");
            imgJump.GetComponent<Animator>().SetTrigger("go2");
            inverter = true;
        }
        StartCoroutine(Botao());
    }

    public IEnumerator Botao() {
        botao.interactable = false;
        botao.GetComponent<Animator>().SetTrigger("go");
        yield return new WaitForSeconds(5f);
        botao.GetComponent<Animator>().SetTrigger("back");
        botao.interactable = true;
    }
}
