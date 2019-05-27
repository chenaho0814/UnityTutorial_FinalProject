using UnityEngine;
using System.Collections;

public enum PICKUP
{
    PICUP_GOOD,
    PICUP_BAD,
};

public class PickUpController : MonoBehaviour {

    public PICKUP ePICKUP = PICKUP.PICUP_GOOD;


	public float RotateSpeed=45f;

    private int Score=10;

    public void initRole( PICKUP pickUp ) {
        ePICKUP = pickUp;

        if (ePICKUP == PICKUP.PICUP_GOOD)
        {
            // change the script
            this.GetComponent<SpriteRenderer>().color = Color.white;
            Score = 10;
        }
        else
        if (ePICKUP == PICKUP.PICUP_BAD)
        {
            // change the script
            this.GetComponent<SpriteRenderer>().color = Color.black;

            Score = -10;
        }

    }

    public int GetScore() {
        return Score;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3(0,0,RotateSpeed*Time.deltaTime));
	}
}
