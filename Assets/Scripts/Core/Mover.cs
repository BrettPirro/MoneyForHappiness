using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blackthornprod.Core
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] float Speed = 2f;
        Rigidbody2D MyRigidbody2d;
        Animator animator;

        Vector3 change;

        void Start()
        {
            MyRigidbody2d = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            CharacterAnimationUpdate();
        }

        public void GeneralInput(float x, float y)
        {
            change = Vector2.zero;
            change.x = x;
            change.y = y;
        }

        private void CharacterAnimationUpdate()
        {
            if (change != Vector3.zero)
            {
                CharacterMovment();
                animator.SetBool("Walking", true);
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
            }
            else
            {
                animator.SetBool("Walking", false);
                MyRigidbody2d.velocity = Vector2.zero;
            }
        }

        public void Attack()
        {
            animator.SetTrigger("Attack");
        }


        private void CharacterMovment()
        {

            MyRigidbody2d.velocity = change * Speed;
        }
    }

}