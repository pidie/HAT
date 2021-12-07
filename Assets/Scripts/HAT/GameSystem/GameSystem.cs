using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HAT.GameSystem
{
    public abstract class GameSystem : MonoBehaviour
    {
        private string _label;
        private Sprite _gameSystemIcon;

        protected bool ValidateCheck()
        {
            return false;
        }

        protected bool ValidateCombat()
        {
            return false;
        }
    }
}
