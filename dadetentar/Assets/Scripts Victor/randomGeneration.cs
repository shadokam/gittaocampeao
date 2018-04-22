using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomGeneration : MonoBehaviour {

    [Header("Normal Variables")]

    public GameObject obsEasy;
    public GameObject obsMedium;
    public GameObject obsHard;
    public GameObject obsDash;
    public GameObject obsEspinhos;
    public GameObject obsVeryHard;
    public GameObject obsEasyClone;
    public GameObject obsMediumClone;
    public GameObject obsHardClone;
    public GameObject obsDashClone;
    public GameObject obsEspinhosClone;
    public GameObject obsVeryHardClone;
    public float distance;
    private int randomNumber; 

    // Use this for initialization
    void Start () {
        for (int g = 0; g <= 40; g++)
        {
            randomNumber = Random.Range(0, 10);
            if (randomNumber == 0 || randomNumber == 1) {
                obsEasyClone = Instantiate(obsEasy, new Vector2(this.gameObject.transform.position.x + distance, 2.05f), Quaternion.identity) as GameObject;
            }
            if (randomNumber == 2 || randomNumber == 3)
            {
                obsMediumClone = Instantiate(obsMedium, new Vector2(this.gameObject.transform.position.x + distance, 2.15f), Quaternion.identity) as GameObject;
            }
            if (randomNumber == 4 || randomNumber == 5){
                obsHardClone = Instantiate(obsHard, new Vector2(this.gameObject.transform.position.x + distance, 2.05f), Quaternion.identity) as GameObject;
            }
            if (randomNumber == 6 || randomNumber == 7){
                obsDashClone = Instantiate(obsDash, new Vector2(this.gameObject.transform.position.x + distance, 2.06f), Quaternion.identity) as GameObject;
            }
            if (randomNumber == 8){
                obsEspinhosClone = Instantiate(obsEspinhos, new Vector2(this.gameObject.transform.position.x + distance, 2.05f), Quaternion.identity) as GameObject;
           }
            if (randomNumber == 9){
                obsVeryHardClone = Instantiate(obsVeryHard, new Vector2(this.gameObject.transform.position.x + distance, 2.04f), Quaternion.identity) as GameObject;
            }
            distance = distance + 15;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
