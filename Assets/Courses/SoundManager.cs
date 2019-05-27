using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    public AudioClip winSound;
    public AudioClip loseSound;

    public AudioClip coinSound;
    public AudioClip hurtSound;

    AudioSource audio;


    public bool bTest = false;

    // Use this for initialization
    void Start () {
        
        audio = this.GetComponent<AudioSource>();

    }

    public void PlaySound(string type) {

        if(type == "win")
            audio.PlayOneShot(winSound, 1F);

        if (type == "lose")
            audio.PlayOneShot(loseSound, 1F);

        if (type == "coin")
            audio.PlayOneShot(coinSound, 1F);

        if (type == "hurt")
            audio.PlayOneShot(hurtSound, 1F);

    }

	
	// Update is called once per frame
	void Update () {

        if (bTest) {
            bTest = false;
            audio.PlayOneShot(winSound, 0.7F);
        }
	
	}
}
