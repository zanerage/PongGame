using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Racket : MonoBehaviour
{
    public float playerSpeed;
    private void FixedUpdate() {
        float v = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * playerSpeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
