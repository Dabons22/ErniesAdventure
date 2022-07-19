using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float MovementSpeed = 5f;
    [SerializeField]
    private float JumpForce = 5f;
    private Rigidbody2D rgidbody2d;
    public ParticleSystem Dust;
    public static AudioClip JumppSound;
    public static AudioSource audioSrc;

    void Start()
    {
        rgidbody2d = GetComponent<Rigidbody2D>();
        JumppSound = Resources.Load<AudioClip>("Jump87");
        audioSrc = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rgidbody2d.velocity.y) < 00.1) {
           CreateDust(); 
            audioSrc.Play();
            rgidbody2d.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        } 
        

        if (Input.GetAxisRaw("Horizontal") > 0) { GetComponent<SpriteRenderer>().flipX = false; CreateDust(); }
        else if (Input.GetAxisRaw("Horizontal") < 0) { GetComponent<SpriteRenderer>().flipX = true; CreateDust(); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Enemy") {
            Destroy(gameObject);
            FindObjectOfType<Manager>().Endgame();
        }
    }
    void CreateDust() {
        Dust.Play();
    }
   
    }
    