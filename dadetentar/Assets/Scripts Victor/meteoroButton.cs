using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meteoroButton : MonoBehaviour {

    public AudioClip meteorSound1;
    public AudioClip meteorSound2;

    public static bool meteoro = false;
    public Button botao;
    public GameObject mete;
    public GameObject meteClone;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void butao()
    {
        meteoro = true;
        botao.interactable = false;
        meteClone = Instantiate(mete, new Vector2(mete.transform.position.x, mete.transform.position.y), Quaternion.identity) as GameObject;
        meteClone.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        StartCoroutine(timing());
        SoundManager.instance.RandomizeSfx(meteorSound1, meteorSound2);
    }

    public IEnumerator timing()
    {
        botao.GetComponent<Animator>().SetTrigger("go");
        yield return new WaitForSeconds(8f);
        botao.GetComponent<Animator>().SetTrigger("back");
        botao.interactable = true;
        meteoro = false;
    }
}
