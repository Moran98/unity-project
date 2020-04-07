using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float moveSpeed = 5f;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public Rigidbody2D rb;
    public Text countText;
    public Text win;

    Vector2 movement;
    Vector2 mousePos;

    private Camera gameCamera;
    public Camera camera;
    private int count;

    [SerializeField] private float speed = 20f;

    // == private methods ==


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count=0;
        win.text="";
        setCountText();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // add hMovement
        // if the player presses the up arrow, then move
        // float vMovement = Input.GetAxis("Vertical");
        // float hMovement = Input.GetAxis("Horizontal");
        // // apply a force, get the player moving.
        // rb.velocity = new Vector2(hMovement * speed,
        //                           vMovement * speed);
        // float yValue = Mathf.Clamp(rb.position.y, -6.0f, 6.0f);
        // float xValue = Mathf.Clamp(rb.position.x, -11.0f, 11.0f);

        // rb.position = new Vector2(xValue, yValue);

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage){
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
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