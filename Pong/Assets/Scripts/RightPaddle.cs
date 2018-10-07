using UnityEngine;
using System.Collections;

public class RightPaddle : MonoBehaviour
{
    [SerializeField]
    float PaddleSpeed; //Speed of the paddle

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 3.30 && Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector2.up * Time.deltaTime * PaddleSpeed);

        if (transform.position.y >= -3.5 && Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector2.down * Time.deltaTime * PaddleSpeed);


    }
}
