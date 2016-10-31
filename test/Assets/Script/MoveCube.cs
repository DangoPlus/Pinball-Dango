using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
	GameObject[] cubes;
	// Use this for initialization
	void Start () {
		cubes = new GameObject[4];
		cubes[0] = GameObject.Find("Cube1");
		cubes[1] = GameObject.Find("Cube2");
		cubes[2] = GameObject.Find("Cube3");
		cubes[3] = GameObject.Find("Cube4");
	}
	
	// Update is called once per frame
	void Update () {
		cubes[0].GetComponent<Rigidbody>().AddForce(Vector3.forward*12);
		cubes[1].GetComponent<Rigidbody>().velocity =  Vector3.forward;
		
		cubes[2].transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
		cubes[3].transform.position+=Vector3.forward * Time.deltaTime;
		
	}
	
	
}
