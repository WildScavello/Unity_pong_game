using UnityEngine;
using System.Collections;

public class LeftPaddle : MonoBehaviour {
    [SerializeField]
     float PaddleSpeed; //Speed of the paddle

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frames
	void Update () {
        if (transform.position.y <= 3.30 && Input.GetKey(KeyCode.Q))
            rb.AddForce(Vector2.up * Time.deltaTime * PaddleSpeed);
                
        if (transform.position.y >= -3.5 && Input.GetKey(KeyCode.A))
            rb.AddForce(Vector2.down * Time.deltaTime * PaddleSpeed);
       
        
    }
}
