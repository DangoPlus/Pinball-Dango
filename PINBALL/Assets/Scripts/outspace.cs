using UnityEngine;
using System.Collections;

public class outspace : MonoBehaviour
{
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
