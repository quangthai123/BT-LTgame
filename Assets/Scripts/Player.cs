using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [HideInInspector] public MeshRenderer meshRend;
    private Rigidbody rb;
    private Animator anim;
    private GameManager gameManager;
    private float horizontalInput;
    private float verticalInput;
    private bool canMove;
    private bool animated;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        meshRend = GetComponent<MeshRenderer>();
        canMove = false;
        animated = false;
        rb.useGravity = false;
        Physics.gravity *= 25f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && !animated)
        {
            anim.SetTrigger("Roll");
            animated = true;
        }
        if (gameManager.startGame && !gameManager.gameOver)
        {
            rb.useGravity = true;
            if (horizontalInput != 0 || verticalInput != 0)
                canMove = true;
        }
        if (gameManager.gameOver)
            Time.timeScale = 0f;
        if (rb.velocity.y < -30f)
            gameManager.gameOver = true;
    }
    private void FixedUpdate()
    {
        if (canMove && !gameManager.gameOver)
        {
            rb.velocity = new Vector3(horizontalInput * speed, 0f, verticalInput * speed);
        }
    }
    private void Animated()
    {
        animated = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Items")
        {
            gameManager.IncreaseScore(1);
            Destroy(other.gameObject);
        }
        else if (other.tag == "3points")
        {
            gameManager.IncreaseScore(3);
            Destroy(other.gameObject);

        }
        else if (other.tag == "2points")
        {
            gameManager.IncreaseScore(2);
            Destroy(other.gameObject);

        }
        else if (other.tag == "1points")
        {
            gameManager.IncreaseScore(1);
            Destroy(other.gameObject);
        }
    }
}


