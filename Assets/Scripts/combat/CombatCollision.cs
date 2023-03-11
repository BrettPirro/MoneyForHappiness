using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blackthornprod.Core;
using Blackthornprod.controls;

public class CombatCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemies")
        {
            collision.gameObject.GetComponent<Health>().DamageDone(gameObject.GetComponentInParent<PlayerInput>().DamagePlayerDoesReturn());
        }
    }
}
