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

    private Camera gameCamera;
    private int count;

    [SerializeField] private float speed = 20f;

    // == private methods ==


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count=0;
        win.text="";
        setCountText();
    }

    void Update()
    {
        // add hMovement
        // if the player presses the up arrow, then move
        float vMovement = Input.GetAxis("Vertical");
        float hMovement = Input.GetAxis("Horizontal");
        // apply a force, get the player moving.
        rb.velocity = new Vector2(hMovement * speed,
                                  vMovement * speed);
        // keep the player on the screen
        // float xValue = Mathf.clamp(value, min, max)
        // rb.position.x 
        float yValue = Mathf.Clamp(rb.position.y, -6.0f, 6.0f);
        float xValue = Mathf.Clamp(rb.position.x, -11.0f, 11.0f);

        rb.position = new Vector2(xValue, yValue);
    }

    // Collectable items
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("PickUp")){
            // Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            count= count+1;
            setCountText();     
}
    }

    //Score counter and winner message
    void setCountText(){
        countText.text="SCORE : "+count.ToString();
        if(count>=4){
            win.text="YOU WIN!";
        }
    }
}