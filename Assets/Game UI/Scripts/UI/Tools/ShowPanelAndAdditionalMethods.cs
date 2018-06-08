using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LedokolUI
{
    public class ShowPanelAndAdditionalMethods : MonoBehaviour
    {
        public GameObject Panel, AdditionalPanel;
        [Header("Modal button (for comic):")]
        public Button modalButton;

        void Awake()
        {
            if (Panel != null)
                Panel.gameObject.SetActive(false);
            if (AdditionalPanel != null)
                AdditionalPanel.gameObject.SetActive(false);
        }

        void Start()
        {

        }

        public void ShowPanel()
        {
            if (AdditionalPanel != null)
                AdditionalPanel.gameObject.SetActive(false);
            Panel.gameObject.SetActive(true);
        }

        public void ShowAdditionalPanel()
        {
            Panel.gameObject.SetActive(false);
            AdditionalPanel.gameObject.SetActive(true);
        }

        public void ShowModalButton()
        {
            modalButton.gameObject.SetActive(true);
        }

        public void CloseStoreButton()
        {
            GameObject.Find("StoreButton").gameObject.SetActive(false);
        }

        public void CloseModalButton()
        {
            modalButton.gameObject.SetActive(false);
        }

        public void CloseModal()
        {
            Panel.gameObject.SetActive(false);
            modalButton.gameObject.SetActive(true);
        }
    }
}