using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blackthornprod.Core
{
    public class Collectible : MonoBehaviour
    {
        [SerializeField] GameObject VFXPickUp;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Debug.Log("collided");
                FindObjectOfType<ValueManager>().MoneyAddition(3);
                FindObjectOfType<ValueManager>().HappinessSub(5);
                Instantiate(VFXPickUp, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }

}
