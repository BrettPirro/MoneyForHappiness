using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blackthornprod.Core
{
    public class keySpawner : MonoBehaviour
    {
        [SerializeField] GameObject Key;
        [SerializeField] Transform[] SpawnPositions;

        private void Awake()
        {
            Vector2 position = SpawnPositions[Random.Range(0, SpawnPositions.Length)].position;

            Instantiate(Key,position,transform.rotation);
        }

    }
}
