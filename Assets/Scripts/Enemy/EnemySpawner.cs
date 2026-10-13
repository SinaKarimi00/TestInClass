using System;
using UnityEngine;

namespace Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject enemy;
        [SerializeField] private Vector3 spawnPoint;
        [SerializeField] private float spawnTime;


        private float counter;

        private void Update()
        {
            if (counter >= spawnTime)
            {
                Instantiate(enemy, spawnPoint, Quaternion.identity);
                counter = 0;
            }
            else
            {
                counter += Time.deltaTime;
            }
        }
    }
}