using UnityEngine;
using System.Collections;

public class gravedad : MonoBehaviour {

	public float velocidadCaida = 8.0f;
	public float VelocidadGiro = 250.0f;

	void Update() 
	{

		transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime, Space.World);
		transform.Rotate(Vector3.forward, VelocidadGiro * Time.deltaTime);

	}

	void OnCollisionEnter (Collision collision)
	{
		Debug.Log (collision.gameObject.name);
	}
	/*void OnMouseDown() {

		renderer.enabled = false;

	}*/

}