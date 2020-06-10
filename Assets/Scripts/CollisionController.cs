using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreTracker scoreTracker;
    private void BounceRacket(Collision2D other) {
        Vector3 ballPos = this.transform.position;
        Vector3 racketPos = other.gameObject.transform.position;
        float racketHeight = other.collider.bounds.size.y;
        float x;
        if(other.gameObject.name == "RacketPlayer") {
            x = 1;
        } else {
            x = -1;

        }
        float y = (ballPos.y - racketPos.y) / racketHeight;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x,y));
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.name == "RacketPlayer" || coll.gameObject.name == "CPU") {
            this.BounceRacket(coll);

        }else if(coll.gameObject.name=="LeftWall") {

            
            this.scoreTracker.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));

        }
        else if(coll.gameObject.name=="RightWall") {

           
            this.scoreTracker.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));

        }
    }
}
