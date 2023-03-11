using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blackthornprod.Core
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 50f;

        public float HealthValReturn()
        {
            return health;

        }

        public void DamageDone(float Damage)
        {
            health -= Damage;
        }

        public void HealthPickUp(float PickUp)
        {
            health += PickUp;
        }
    }
}
