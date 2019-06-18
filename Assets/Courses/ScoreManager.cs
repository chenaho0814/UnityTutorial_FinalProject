using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private Text _text ;  // Class Text is defined in  UnityEngine.UI
	private float _currentScore = 0;
	const string ScorePrefix = "Score : ";

    public int Score_Win=100;
    public int Score_Lose= -10;

    private bool m_bIsGameEnd = false;

    public SoundManager GameSoundManager;

    // Use this for initialization
    void Start () {
		_text = this.GetComponent<Text> ();
		_text.text = ScorePrefix + _currentScore;
	
        

	}


	public void AddScore(int score)
	{
        if (m_bIsGameEnd == true) return;

		_currentScore += score;
		_text.text = ScorePrefix + _currentScore;


        Debug.Log("AddScore:"+ score);

        if(GameSoundManager != null){
            if (score > 0)
                GameSoundManager.PlaySound("coin");
            else
            {
                GameObject.Find("UFO").GetComponent<UFOAnimation>().UFOAnimationHit();
                GameSoundManager.PlaySound("hurt");

                motionCameraShake shake = GameObject.Find("motion_camerashaking").GetComponent<motionCameraShake>();
                if (shake)
                    shake.MotionCameraShaking();


                GameObject.Find("UFO").GetComponent<SpawnAction>().bTestFlag = true;
            }
                
        }




    }

    void CheckGameStatus() {

        if (_currentScore >= Score_Win) {
            _text.text = "Win!!!";
            _text.color = Color.green;
            m_bIsGameEnd = true;

            GameSoundManager.PlaySound("win");
        }


        if (_currentScore <= Score_Lose)
        {
            _text.text =  "Lose...";
            _text.color = Color.red;
            m_bIsGameEnd = true;

            GameSoundManager.PlaySound("lose");
        }

    }


	// Update is called once per frame
	void Update () {

        if(m_bIsGameEnd == false)
            CheckGameStatus();

    }
}
