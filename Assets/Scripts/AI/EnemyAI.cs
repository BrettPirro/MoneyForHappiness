using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blackthornprod.Core;

namespace Blackthornprod.AI
{
    [RequireComponent(typeof(Mover))]
    public class EnemyAI : MonoBehaviour
    {
        Transform Player;
        [SerializeField] float DistanceKept = 5;
        Mover mover;
       [SerializeField] float AttackPower=10f;
         float lastHit = Mathf.Infinity;
        [SerializeField]float waitTime = .6f;
        [SerializeField] float padding = 0.5f;
        bool Attack = false;
        bool Dead=false;

        private void Start()
        {
            Player = GameObject.FindWithTag("Player").transform;
            mover = GetComponent<Mover>();
          
            

        }


        private void Update()
        {

            if (GetComponent<Health>().HealthValReturn() < 0&& !Dead)
            {
                Dead = true;
                StartCoroutine(Death());
            }



            lastHit += Time.deltaTime;

            if (Vector2.Distance(Player.position, transform.position) < DistanceKept && !Dead)
            {
                Vector2 change = new Vector2(Mathf.Clamp( Player.position.x-transform.position.x,-1,1), Mathf.Clamp(Player.transform.position.y- transform.position.y, -1, 1));
                if(!(Vector2.Distance(Player.position, transform.position) <= padding))
                {
                    mover.GeneralInput(change.x, change.y);
                  
                }
                else
                {
                     mover.GeneralInput(0,0);
                }
              

            }
            else
            {
                mover.GeneralInput(0,0);
            }



            if (Attack && lastHit > waitTime)
            {
                GameObject.FindWithTag("Player").GetComponent<Health>().DamageDone(AttackPower);
                lastHit = 0;


            }



        }


        private void OnTriggerStay2D(Collider2D collision)
        {

            if (collision.tag=="Player")
            {
                Attack = true;
            }


        }


        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Attack = false;
            }
        }



        IEnumerator Death()
        {
            GetComponent<Animator>().SetTrigger("Death");
            yield return new WaitForSeconds(.8f);
            Destroy(gameObject);
        }


    }
}
