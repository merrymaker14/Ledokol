using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LedokolUI
{
    public class ItemDisplay : MonoBehaviour
    {
        public Item item;

        public Text name;
        public Image picture;
        public Text baseValue;

        // Use this for initialization
        void Start()
        {
            name.text = item.name;
            picture.sprite = item.picture;
            baseValue.text = item.baseValue.ToString();
        }
    }
}
