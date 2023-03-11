using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blackthornprod.Core;
using UnityEngine.UI;
using Blackthornprod.SceneManagment;

namespace Blackthornprod.controls
{   [RequireComponent(typeof(Mover))]
    public class PlayerInput : MonoBehaviour
    {

        Mover mover;
        Health health;
        [SerializeField]Slider healthBar;
        bool Attacking = false;
        [SerializeField]float PlayerDamage = 10f;
        bool dead = false;

        private void Start()
        {
            mover = GetComponent<Mover>();
            health = GetComponent<Health>();

            healthBar.maxValue = health.HealthValReturn();
        }

        private void Update()
        {
            MovmentInput();

            if (dead) { return; }


            if (Input.GetKeyDown(KeyCode.E)&&!Attacking)
            {
                StartCoroutine(Attack());
            }

            if (health.HealthValReturn() < 0 && !dead)
            {
                dead = true;
                GetComponent<Animator>().SetTrigger("Death");
                

            }

            healthBar.value= health.HealthValReturn();

        }

        private void MovmentInput()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            if (dead)
            {
                GetComponent<Mover>().GeneralInput(0, 0);
                return;
            }

            GetComponent<Mover>().GeneralInput(x, y);

           

        }

        public void startCoroutineGameOver()
        {
            StartCoroutine(GameOver());
        }

        IEnumerator Attack()
        {
            Attacking = true;
            mover.Attack();
            yield return new WaitForSeconds(0.6f);
            Attacking = false;


        }

        public float DamagePlayerDoesReturn()
        {
            return PlayerDamage;
        }

        IEnumerator GameOver()
        {
            DontDestroyOnLoad(this);
            yield return FindObjectOfType<TransitionManager>().TransitionGameOver();
            Destroy(gameObject);
        }


    }

}
