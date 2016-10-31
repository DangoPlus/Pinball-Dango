using UnityEngine;
using System.Collections;

public class collisionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter( Collision collision  )
	{
		Debug.Log(this.gameObject.name+ "  collsion  " + collision.gameObject.name );
	}
}
