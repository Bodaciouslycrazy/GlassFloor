using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate(){
		transform.Rotate( new Vector3( 0,30 * Time.deltaTime ,0) );
	}
}
