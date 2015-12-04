using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

    public GameObject carro;

	// Use this for initialization
	void Start () {
        carro.SetActive(false);
        carro.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
