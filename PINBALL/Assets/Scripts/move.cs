using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z))
		{
			GameObject movecube = GameObject.Find ("movecubeleft");
			movecube.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 0.5f) * 400);
		}

		if (Input.GetKeyDown (KeyCode.M))
		{
			GameObject movecube = GameObject.Find ("movecuberight");
			movecube.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 0.5f) * 400);
		}
	}
}
