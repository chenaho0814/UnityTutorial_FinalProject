using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementJump : MonoBehaviour
{


    // the key used to activate the push
    public KeyCode key = KeyCode.Space;

    // strength of the push
    public float jumpStrength = 10f;


    //if the object collides with another object tagged as this, it can jump again
    public string groundTag = "Ground";

    //this determines if the script has to check for when the player touches the ground to enable him to jump again
    //if not, the player can jump even while in the air
    public bool checkGround = true;

    private bool canJump = true;



    // Start is called before the first frame update
    void Awake()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (canJump
            && Input.GetKeyDown(key))
        {
            // Apply an instantaneous upwards force
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            canJump = !checkGround;
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (checkGround
            && collisionData.gameObject.CompareTag(groundTag))
        {
            canJump = true;
        }
    }


}
