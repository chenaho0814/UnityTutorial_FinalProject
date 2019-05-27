using UnityEngine;
using System.Collections;

public class UFOController_Phy : MonoBehaviour {

	public float forceValue;

	private Rigidbody2D rigidbody2D = null;

	public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {

		rigidbody2D = this.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		Vector2 force2D = Vector2.zero;		

		if(Input.GetKey(KeyCode.W)){

			force2D.y += forceValue;
		}

		if(Input.GetKey(KeyCode.S)){
			force2D.y -= forceValue;
		}

		if(Input.GetKey(KeyCode.A)){
			force2D.x -= forceValue;
		}

		if(Input.GetKey(KeyCode.D)){
			force2D.x += forceValue;
		}

		rigidbody2D.AddForce(force2D);
	}


	void OnTriggerEnter2D( Collider2D other){

		Debug.Log("Collider2D:" + other.gameObject.name);

        PickUpController picUpinstance = other.gameObject.GetComponent<PickUpController>();
  //      //if( oth )


if(scoreManager)
        {
            //if(picUpinstance && picUpinstance )
                scoreManager.AddScore(picUpinstance.GetScore() );
        }
			
		else
			Debug.Log( "please assign ScoreManager");

		other.gameObject.SetActive(false);






	}






}