using UnityEngine;
using System.Collections;

public class UFOController : MonoBehaviour {

	public float speed = 10;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello Start()");
	
	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetKey( KeyCode.W)){
			this.transform.position+= new Vector3( 0, speed * Time.deltaTime , 0 );
		}

		if( Input.GetKey( KeyCode.S)){
			this.transform.position+= new Vector3( 0, -speed * Time.deltaTime , 0 );
		}

		if( Input.GetKey( KeyCode.A)){
			this.transform.position+= new Vector3( -speed * Time.deltaTime , 0 ,0 );
		}

		if( Input.GetKey( KeyCode.D)){
			this.transform.position+= new Vector3( speed * Time.deltaTime , 0 ,0 );
		}

	
	}
}
