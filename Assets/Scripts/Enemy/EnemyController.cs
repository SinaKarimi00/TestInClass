using System;
using UnityEngine;

namespace Enemy
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Update()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("DieZone"))
            {
                Destroy(gameObject);
            }
        }
        

        // private void OnBecameInvisible()
        // {
        //     Destroy(gameObject);
        // }
    }
}