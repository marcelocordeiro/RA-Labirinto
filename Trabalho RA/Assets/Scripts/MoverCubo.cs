using UnityEngine;
using System.Collections;

public class MoverCubo : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.left * (float) 0.03 * movX * Time.deltaTime);
        transform.Translate(Vector3.down * (float) 0.03 * movY * Time.deltaTime);
	}
}
