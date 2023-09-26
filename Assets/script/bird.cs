using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bird : MonoBehaviour
{
    //[RequireComponent(typeof(Rigidbody2D))]
    
    [Range(0f,100f)]
    public float sPeed;
    private Rigidbody2D rigidbodybird;

    
    GameController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameController>();


    }
    private void Awake()
    {
        rigidbodybird = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
       //// xDerition = Input.GetAxisRaw("Vertical");// lay 1 hoac -1
        //float moveStep = sPeed * xDerition;

        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began )
        {
            //rigidbodybird.AddForce(Vector3.up * sPeed,ForceMode2D.Impulse);
            rigidbodybird.velocity = new Vector2(rigidbodybird.velocity.x, sPeed);

            Debug.Log(" da vao ham aaaa");
        }
        

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("deathZone")) {
            controller.EndGame();

            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("addScore"))
        {
            controller.IncrementScore();
            Debug.Log("tinh diem");
        }
    }
}
