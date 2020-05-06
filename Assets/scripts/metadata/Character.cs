using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Metadata
{
    public class Character : MonoBehaviour
    {
        public int currentHP;
        public int maxHP;
        public int currentMana;
        public int maxMana;

        public void dealDamage(int number)
        {
            this.currentHP -= number;

            return;
        }

        public void dead()
        {
            if (this.currentHP > 0)
            {
                return;
            }

        }
    }
}