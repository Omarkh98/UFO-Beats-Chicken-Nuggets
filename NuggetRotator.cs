using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuggetRotator : MonoBehaviour {

    public float Acceleration;

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,0,45) * Acceleration * Time.deltaTime);
	}
}
