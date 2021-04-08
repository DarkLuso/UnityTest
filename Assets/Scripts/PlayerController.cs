using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;


    private Rigidbody2D playerRigidbody2d;
    public float apertaoX = 0.0f;
    public float apertaoY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        apertaoX = Input.GetAxisRaw("Horizontal");
        apertaoY = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer (float apX, float apY)
    {
        playerRigidbody2d.velocity = new Vector2(apX * speed, apY * speed);
    }

    private void FixedUpdate()
    {
        MovePlayer(apertaoX, apertaoY);
    }

}
