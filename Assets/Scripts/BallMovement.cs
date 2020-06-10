﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float ballSpeed;
    public float additionalSpeedperHit;
    public float maxAddedSpeed;
    int hitCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall());
    }
     void PositionBall(bool isPlayerFirst) {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        if(isPlayerFirst) {
            this.gameObject.transform.localPosition = new Vector3(-100,0,0); 
        }

             else {
                this.gameObject.transform.localPosition = new Vector3(100,0,0);
            }
        }
    

    public IEnumerator StartBall(bool isPlayerFirst = true) {

        this.PositionBall(isPlayerFirst);

           this.hitCounter = 0;
           yield return new WaitForSeconds(2);
           if(isPlayerFirst) 
               this.MoveBall(new Vector2(-1,0));
            else {
               this.MoveBall(new Vector2(1,0));
           }

    }

    public void MoveBall(Vector2 dir) {
        dir = dir.normalized;

        float speed = this.ballSpeed + this.hitCounter * this.additionalSpeedperHit;

        Rigidbody2D myrigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
       // myrigidbody2D.velocity = dir*speed*Time.deltaTime;
       myrigidbody2D.velocity = dir*speed;
    }

    public void IncreaseHitCounter() {
        if(this.hitCounter * this.additionalSpeedperHit <= this.maxAddedSpeed) {
            this.hitCounter++;
        }
    }
}
