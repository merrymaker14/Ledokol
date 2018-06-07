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

        void Start()
        {
            if (Panel != null)
                Panel.gameObject.SetActive(false);
            if (AdditionalPanel != null)
                AdditionalPanel.gameObject.SetActive(false);
        }

        void showPanel()
        {
            if (AdditionalPanel != null)
                AdditionalPanel.gameObject.SetActive(false);
            Panel.gameObject.SetActive(true);
        }

        void showAdditionalPanel()
        {
            Panel.gameObject.SetActive(false);
            AdditionalPanel.gameObject.SetActive(true);
        }

        void showModalButton()
        {
            modalButton.gameObject.SetActive(true);
        }

        void closeStoreButton()
        {
            GameObject.Find("StoreButton").gameObject.SetActive(false);
        }

        void closeModalButton()
        {
            modalButton.gameObject.SetActive(false);
        }

        void closeModal()
        {
            Panel.gameObject.SetActive(false);
            modalButton.gameObject.SetActive(true);
        }
    }
}