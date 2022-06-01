using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    [SerializeField] private bool _isGrounded;
    [SerializeField] private bool _canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        Movement();

        if (transform.position.y <= -7.27)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Die();
        }
    }

    private void Movement()
    {
        if (_canMove)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            speed += 0.0003f;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (_isGrounded)
                {
                    rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                    _isGrounded = false;
                }

            }
        }
        else
        {
            return;
        }
  
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (!_isGrounded)
            {
                // Debug.Log("Is Touching Ground");
                _isGrounded = true;
            }            
        }
    }
}
