using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    Vector2 moveInput;
    
    float move;
    [SerializeField] float speed;
    
    [SerializeField] float jumpForce;
    [SerializeField] bool isJumping;

    public Text scoreText = null;
    private int _score = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();        
    }

    
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2d.AddForce(moveInput * speed);
        
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * speed, rb2d.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jumpForce));
            Debug.Log("Jump!");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            _score += 1;
            UpdateScoreText();

            Destroy(other.gameObject); 
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            isJumping = true;
        }

    }

    public void UpdateScoreText()
    {
        _score++;
        scoreText.text = $"SCORE: {_score}";
        if (_score >= 36)
        {
            scoreText.text = $"You win!!";
        }
    }
}
