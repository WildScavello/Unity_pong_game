using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PongBall : MonoBehaviour
{
    public Text ScoreText;
    public Text TimerText;
    public Text Message;
    public float Speed;
    Vector2 BallPos;
    Vector2 intialPos;
    Rigidbody2D rb;
    private int leftSide = 0;
    private int rightSide = 0;
    // Use this for initialization
    void Start()
    {
        if(ScoreText == null)
        {
            Debug.LogError("No Text inplemented");
        }
        rb = GetComponent<Rigidbody2D>();

    
        intialPos = transform.position;
        StartCoroutine(waitSeconds(2));

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x <= -9 || transform.position.x >= 9)
        {
            if (transform.position.x <= -9)
                leftSide++;
            else
                rightSide++;

            rb.isKinematic = true;
            transform.position = intialPos;
            StartCoroutine(waitSeconds(2));
        }
        
   
        BallPos = BallPos.normalized;


       rb.AddForce(BallPos * Time.deltaTime * Speed);
        UpdateScore();
    }

   void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Paddle")
        {
            BallPos.y = (transform.position.y - other.transform.position.y) / other.collider.bounds.size.y;
            BallPos.x = (-1) * BallPos.x;
           // Debug.Log("The right Paddle is collison is working");
        }
        if (other.gameObject.tag == "Wall")
        {
            BallPos.y = (-1) * BallPos.y;
        }  
                
    }

   


    IEnumerator  waitSeconds(float waitTime)
    {
        TimerText.enabled = true;
        Message.enabled = true;
        float time = waitTime;
        int value = Random.Range(0, 2);
        for(int x = 0; x < waitTime; x++)

        {
            TimerText.text = time + "";
           yield return new WaitForSeconds(1);
            time--;
        }
      

        if (value == 0)
            BallPos = new Vector2(Random.Range(60, 90), Random.Range(-90, 90));

        else
            BallPos = new Vector2(Random.Range(-60, -90), Random.Range(-90, 90));
        rb.isKinematic = false;
        TimerText.enabled = false;
        Message.enabled = false;
    }
    void UpdateScore()
    {
        if (leftSide >= 5)
            SceneManager.LoadScene("Player2");
        else if (rightSide >= 5)
            SceneManager.LoadScene("Player1");

        ScoreText.text = leftSide + " : " + rightSide;
    }
}
