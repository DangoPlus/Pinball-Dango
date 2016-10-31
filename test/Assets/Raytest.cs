using UnityEngine;
using System.Collections;

public class Raytest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit = new RaycastHit();
		Vector3 pos = Input.mousePosition;
		Ray mouseray = Camera.main.ScreenPointToRay(pos);
		if (Input.GetMouseButton(0))
		{
			if (Physics.Raycast(mouseray,out hit) )
			{
				if(hit.collider.gameObject.tag!="noRay")
					Debug.Log( hit.collider.gameObject.name);
				Debug.DrawLine(mouseray.origin, hit.point);
			}
		}
	}
	
		
}
