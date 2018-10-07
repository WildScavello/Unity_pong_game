using UnityEngine;
using System.Collections;

public class CPU : MonoBehaviour
{
    [SerializeField]
    float PaddleSpeed; //Speed of the paddle

    [SerializeField]
   public Transform ball;
    Vector2 follow;

    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float d = ball.position.y - transform.position.y;
        if (d > 0 && transform.position.y <= 3.30)
        {
            follow.y = PaddleSpeed * Mathf.Min(d, 1.0f);
        }
        if (d < 0 && transform.position.y >= -3.5)
        {
            follow.y = -(PaddleSpeed * Mathf.Min(-d, 1.0f));
        }
        rb.AddForce(follow * Time.deltaTime);
        
    }
}

