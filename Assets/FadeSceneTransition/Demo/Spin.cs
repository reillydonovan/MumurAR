using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float speed = 100f;
	public Vector3 direction = Vector3.up;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(direction, speed * Time.deltaTime);
	}
}
