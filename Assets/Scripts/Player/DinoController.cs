using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class DinoController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;

        [SerializeField] private Vector2 jumpVector;

        private bool isGrounded;

        private void Update()
        {
            if (Keyboard.current.spaceKey.isPressed && isGrounded)
            {
                rb.linearVelocity = jumpVector;
                isGrounded = false;
            }
        }


        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
                isGrounded = true;
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
                isGrounded = false;
        }
    }
}