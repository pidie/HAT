using System.Linq;

namespace HAT.GameSystem.Classic
{
    public abstract class Classic : GameSystem
    {
        protected bool ValidateCheck(int dc, int die, int[] modifiers)
        {
            return dc <= die + modifiers.Sum();
        }
    }
}
