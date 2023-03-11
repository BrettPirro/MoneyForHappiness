using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blackthornprod.Core
{
    public class ValueTransfer : MonoBehaviour
    {
        public float Happiness;
        public float Money;


        public void SetValue(float happy, float money)
        {
            Happiness = happy;
            Money = money;
        }

        public void ResetVal()
        {

            Happiness = 0;
            Money = 0;
        }

        
    }


}