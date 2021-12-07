using UnityEngine;

namespace HAT.Characters
{
    public abstract class Character : MonoBehaviour
    {
        public string nameOfChar;
        public string race;
        public string age;
        public string description;
        public string[] factions;
        public string residence;
        public string notes;
        public int[] charSheet;

        public string GetCharSheet()
        {
            return $"STR: {charSheet[0]}\n" +
                   $"DEX: {charSheet[1]}\n" +
                   $"CON: {charSheet[2]}\n" +
                   $"INT: {charSheet[3]}\n" +
                   $"WIS: {charSheet[4]}\n" +
                   $"CHA: {charSheet[5]}";
        }
    }
}
