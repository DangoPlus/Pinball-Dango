using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			GameObject ball = GameObject.Find("ball");
			ball.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * 100);
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene ("main");
		}

	}
}
