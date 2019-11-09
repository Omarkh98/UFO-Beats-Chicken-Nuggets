using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

    public GameObject Player;

    private Vector3 Offset;

	// Use this for initialization
	void Start () {
        Offset = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () { // More Garantueed To run every Frame than Update().
        transform.position = Player.transform.position + Offset; // Camera Position is the Player Position plus the Offset of the Location. Update every time the Player Moves.   ( Child(Camera) of Parent(Player)).
	}
}
