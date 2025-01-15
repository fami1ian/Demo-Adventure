using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed;
   public float jumpForce;
   private float moveInput;

   private Rigidbody2D rb;
   private void Start ()
   {
    rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate ()
    {
        moveInput = Input.GetAxis("Horizontal");
        
    }
}
