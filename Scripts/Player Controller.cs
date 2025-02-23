using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
   public float speed;
   public float jumpForce;
   private float moveInput;

   private bool facingRight = true;

   private bool isGrounded;
   public Transform feetPos;
   public float checkRadius;
   public LayerMask whatIsGround;

   private Rigidbody2D rb;
       private void Start ()
   {
    rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate ()
{
        moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocityY);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
}
    private void Update ()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }


    void Flip() {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
