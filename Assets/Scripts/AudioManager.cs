using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;
    

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "RacketPlayer" || collision.gameObject.name == "CPU") {
            this.racketSound.Play();
        } else if(collision.gameObject.name == "LeftWall" || collision.gameObject.name=="RightWall") {
            this.wallSound.Play();
        }
    }
}
