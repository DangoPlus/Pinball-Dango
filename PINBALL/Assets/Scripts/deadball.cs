using UnityEngine;
using System.Collections;

public class deadball : MonoBehaviour {
	public GameObject Ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "deadline")
		{
			Destroy (gameObject);

			Instantiate (Ball, new Vector3 (3, 0, -2.4f), Quaternion.identity);
		}
	}
}
