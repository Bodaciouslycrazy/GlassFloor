using UnityEngine;
using System.Collections;

public class GlassBreaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter( Collision col ){
		//do stuff
		if(col.gameObject.tag == "Player"){
			Destroy( gameObject );
		}
	}
}
