using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Blackthornprod.Core;

namespace Blackthornprod.SceneManagment
{
    public class TransitionManager : MonoBehaviour
    {
        public IEnumerator TransitionNextScene()
        {
            Animator animator = GetComponent<Animator>();

            animator.SetBool("Transition", true);
            yield return new WaitForSeconds(2.5f);

            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

            yield return new WaitForSeconds(1f);

            animator.SetBool("Transition", false);

        }

        public IEnumerator TransitionGameOver()
        {
            Animator animator = GetComponent<Animator>();

            animator.SetBool("Transition", true);
            FindObjectOfType<ValueTransfer>().ResetVal();
            yield return new WaitForSeconds(2.5f);


            yield return SceneManager.LoadSceneAsync("GameOver");

            yield return new WaitForSeconds(1f);

            animator.SetBool("Transition", false);

        }

        public IEnumerator TransitionMainMenu()
        {
            Animator animator = GetComponent<Animator>();

            animator.SetBool("Transition", true);
            FindObjectOfType<ValueTransfer>().ResetVal();
            yield return new WaitForSeconds(2.5f);


            yield return SceneManager.LoadSceneAsync("MainMenu");

            yield return new WaitForSeconds(1f);

            animator.SetBool("Transition", false);

        }



    }
}
