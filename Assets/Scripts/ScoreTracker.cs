using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    public GameObject scoreText1;
     public GameObject scoreText2;
     public int goalToWIN;




    // Update is called once per frame
    void Update()
    {

        if(this.scorePlayer1 >= this.goalToWIN || this.scorePlayer2 >= this.goalToWIN) {

            Debug.Log("Game Won");

        }
        
    }
    
    private void FixedUpdate() {
        Text uiP1score = this.scoreText1.GetComponent<Text>();
        uiP1score.text = this.scorePlayer1.ToString();


        Text uiP2score = this.scoreText2.GetComponent<Text>();
        uiP2score.text = this.scorePlayer2.ToString();

    }
    public void GoalPlayer1() {
        this.scorePlayer1++;

    }
     public void GoalPlayer2() {
        this.scorePlayer2++;
        
    }
}
