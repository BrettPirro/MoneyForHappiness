using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 namespace Blackthornprod.SceneManagment
{
    public class ButtonSceneTransition : MonoBehaviour
    {
        bool loading = false;


        public void LoadNextLevel()
        {
            if (!loading)
            {
                StartCoroutine(NextScene());
                loading = true;
            }
        }
        public void Quit()
        {
            Application.Quit();
        }
        public void MainMenu()
        {
            if (!loading)
            {
                StartCoroutine(LoadMainMenu());
                loading = true;
            }
        }



        IEnumerator NextScene()
        {
            DontDestroyOnLoad(this);

            yield return FindObjectOfType<TransitionManager>().TransitionNextScene();

            Destroy(gameObject);



        }


        IEnumerator LoadMainMenu()
        {
            DontDestroyOnLoad(this);

            yield return FindObjectOfType<TransitionManager>().TransitionMainMenu();

            Destroy(gameObject);



        }

    }

}
