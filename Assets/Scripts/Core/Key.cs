using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blackthornprod.Core
{
    public class Key : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Destroy(GameObject.FindGameObjectWithTag("door"));
                Destroy(gameObject);
            }
        }


    }
}
