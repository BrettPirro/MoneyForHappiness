using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Blackthornprod.Core;

namespace Blackthornprod.SceneManagment
{
    public class EndLevelGoal : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Debug.Log("Hit");
                StartCoroutine(NextScene());
            }


        }


        IEnumerator NextScene()
        {
            var manager=FindObjectOfType<ValueManager>();

            DontDestroyOnLoad(this);
            FindObjectOfType<ValueTransfer>().SetValue(manager.HappinessReturn(), manager.MoneyReturn());

            yield return FindObjectOfType<TransitionManager>().TransitionNextScene();

            Destroy(gameObject);



        }


    }

    

}