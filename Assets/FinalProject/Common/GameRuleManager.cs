using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameRuleManager : MonoBehaviour
{
    private Text _text;  // Class Text is defined in  UnityEngine.UI
    public Text text_DisplayScore;
    public Text test_DisplayResult;

    public GameTimer m_GameTimer;

    private float _currentScore = 0;
    const string ScorePrefix = "Score : ";

    public int Score_Win = 100;
    public int Score_Lose = -10;

    private bool m_bIsGameEnd = false;

    public SoundManager GameSoundManager;


    public GameObject Panel_GameStart;
    public GameObject Panel_WinLoseUI;


    public GameObject []GameObjectsToShowOnStart;
    public GameObject[] GameObjectsToHideOnStart;

    // Use this for initialization
    void Start()
    {
        //_text = this.GetComponent<Text>();
        text_DisplayScore.text = ScorePrefix + _currentScore;


        for(int i = 0; i < GameObjectsToShowOnStart.Length; i++) {
            GameObjectsToShowOnStart[i].SetActive(true);
        }

        for (int i = 0; i < GameObjectsToHideOnStart.Length; i++)
        {
            GameObjectsToHideOnStart[i].SetActive(false);
        }

    }


    public void AddScore(int score)
    {
        if (m_bIsGameEnd == true) return;

        _currentScore += score;
        text_DisplayScore.text = ScorePrefix + _currentScore + "/" + Score_Win;


        Debug.Log("AddScore:" + score+ ","+ _currentScore+","+ Score_Win);

        if (GameSoundManager != null)
        {
            if (score > 0)
                GameSoundManager.PlaySound("coin");
            else
            {
                //GameObject.Find("UFO").GetComponent<UFOAnimation>().UFOAnimationHit();
                GameSoundManager.PlaySound("hurt");

                //motionCameraShake shake = GameObject.Find("motion_camerashaking").GetComponent<motionCameraShake>();
                //if (shake)
                //    shake.MotionCameraShaking();
                //GameObject.Find("UFO").GetComponent<SpawnAction>().bTestFlag = true;
            }

        }


    }


    public void SetWinDirectly() {
        _currentScore = Score_Win;
    }


    public void SetLoseDirectly() {

        _currentScore = Score_Lose;
    }


    void CheckGameStatus()
    {



        if (_currentScore >= Score_Win)
        {


            if(m_GameTimer) m_GameTimer.CountStop();
            // open the game end panel 
            Panel_WinLoseUI.SetActive(true);
            m_bIsGameEnd = true;

            Debug.Log("Win");
            test_DisplayResult.text = "Win!!!";
            test_DisplayResult.color = Color.green;


            if (GameSoundManager)
                GameSoundManager.PlaySound("win");
        }


        if ( (m_GameTimer && m_GameTimer.doOnce) || _currentScore <= Score_Lose)
        {
        
            if (m_GameTimer) m_GameTimer.CountStop();
            // open the game end panel 
            Panel_WinLoseUI.SetActive(true);
            m_bIsGameEnd = true;

            Debug.Log("Lose");
            test_DisplayResult.text = "Lose...";
            test_DisplayResult.color = Color.red;


            if(GameSoundManager)
                GameSoundManager.PlaySound("lose");
        }

    }


    // Update is called once per frame
    void Update()
    {

        if (m_bIsGameEnd == false)
            CheckGameStatus();

    }
}
