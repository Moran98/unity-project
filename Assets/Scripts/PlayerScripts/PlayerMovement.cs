using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Text countText;
    public Text win;
    Vector2 movement;
    Vector2 mousePos;
    public Enemy enemy;
    private Camera gameCamera;
    public Camera camera;
    private int count;

    public GameObject gameOverText, quitButton, youWinText, restartButton, nextWaveButton;

    [SerializeField] private float speed = 20f;
    [SerializeField] private int winCount;

    // == private methods ==


    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        youWinText.SetActive(false);
        nextWaveButton.SetActive(false);
        quitButton.SetActive(false);


        rb = GetComponent<Rigidbody2D>();
        count=0;
        win.text="";
        setCountText();
   
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        float yValue = Mathf.Clamp(rb.position.y, -4.5f, 4.5f);
        float xValue = Mathf.Clamp(rb.position.x, -8.95f, 8.95f);

        rb.position = new Vector2(xValue, yValue);

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            quitButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    // Collectable items
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("PickUp")){
            // Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            count= count+1;
            setCountText();     
        }

        enemy = other.GetComponent<Enemy>();

        if (enemy)
        {
            Destroy(gameObject);
        }
    }

    //Score counter and winner message
    void setCountText(){
        countText.text="SCORE : "+count.ToString();
        if(count>= winCount)
        {
            nextWaveButton.SetActive(true);
            youWinText.SetActive(true);
            Destroy(gameObject);
            win.text="YOU WIN!";
        }
    }

  
}