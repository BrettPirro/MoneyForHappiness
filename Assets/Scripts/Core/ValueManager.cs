using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Blackthornprod.Core
{
    public class ValueManager : MonoBehaviour
    {

        [SerializeField]float HappinessVal = 100f;

        [SerializeField]float Money = 0f;

        [SerializeField] Text HappinessTxt, MoneyTxt;
 
        void Update()
        {
            HappinessTxt.text = HappinessVal.ToString();

            MoneyTxt.text = Money.ToString();


        }

        public void HappinessSub(float deduction)
        {
            HappinessVal -= deduction;
        }

        public void MoneyAddition(float addition)
        {
            Money += addition;
        }


        public float HappinessReturn()
        {
            return HappinessVal;
        }

        public float MoneyReturn()
        {
            return Money;
        }

    }
}
