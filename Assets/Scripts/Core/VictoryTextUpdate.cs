using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Blackthornprod.Core
{
    public class VictoryTextUpdate : MonoBehaviour
    {
        [SerializeField]string[] Texts; 


        private void Awake()
        {

            if (FindObjectOfType<ValueTransfer>().Happiness>80&& FindObjectOfType<ValueTransfer>().Happiness < 90&& FindObjectOfType<ValueTransfer>().Money<1)
            {

            }
            else if (FindObjectOfType<ValueTransfer>().Happiness< FindObjectOfType<ValueTransfer>().Money)
            {
                GetComponent<Text>().text = Texts[0];
            }
            else if (FindObjectOfType<ValueTransfer>().Happiness > FindObjectOfType<ValueTransfer>().Money)
            {
                GetComponent<Text>().text = Texts[1];
            }


        }


    }



}
