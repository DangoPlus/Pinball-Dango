using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	GameObject[] cubes;
	// Use this for initialization
	void Start () {
		cubes = new GameObject[4];
		cubes [0] = GameObject.Find ("inblock");
		//cubes [1] = GameObject.Find ("inblock1");
		//cubes [2] = GameObject.Find ("inblock2");
	}
	
	// Update is called once per frame
	void Update () {
		cubes [0].transform.Rotate(new Vector3(0, 1, 0));
		//cubes [1].transform.Rotate(new Vector3(0, 2, 0));
		//cubes [2].transform.Rotate(new Vector3(0, 3, 0));
	}
}
