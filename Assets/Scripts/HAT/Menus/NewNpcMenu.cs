using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace HAT.Menus
{
    public class NewNpcMenu : MonoBehaviour
    {
        [SerializeField]    private Button createButton;
        [SerializeField]    private GameObject container;

        private readonly List<TMP_InputField> _fields = new List<TMP_InputField>();
        
        private void Awake()
        {
            GetFields();
        }

        private void Update()
        {
            createButton.interactable = CheckFields();
        }

        private void GetFields()
        {
            foreach (var field in container.GetComponentsInChildren<TMP_InputField>()) 
            {
                _fields.Add(field);
            }
        }

        private bool CheckFields()
        {
            foreach (var field in _fields.Where(n => n.name == "Text"))
            {
                Debug.Log(field.text);
                // if (field.text.Length < 1)
                // {
                //     return false;
                // }
            }
            
            return true;
        }
    }
}
