using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb2d;

    public SpriteRenderer playerSprite;
    // Start is called before the first frame update

    Vector2 movement;
    Vector2 mousePosition;

    void Start()
    {
        
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePosition - rb2d.position;



        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

    }
}
