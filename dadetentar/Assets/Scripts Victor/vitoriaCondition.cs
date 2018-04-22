using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vitoriaCondition : MonoBehaviour {

    // Use this for initialization
    public IEnumerator timer()
    {
        yield return new WaitForSeconds(60);
        Time.timeScale = 0;
    }

    void Start () {
        timer();
	}
	
	// Update is called once per frame
	void Update () {

	}


}
