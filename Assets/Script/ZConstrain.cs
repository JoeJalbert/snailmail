using UnityEngine;
using System.Collections;

public class ZConstrain : MonoBehaviour {

    float lockRot = 0;

	void Start () {
	
	}

	void Update () {
        
		Vector3 pos = transform.position;
		pos.z = 0;
		transform.position = pos;

		//transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, 0); 
	}
}
