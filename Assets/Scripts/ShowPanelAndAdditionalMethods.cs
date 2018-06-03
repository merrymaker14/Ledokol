using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanelAndAdditionalMethods : MonoBehaviour {
	public GameObject Panel, AdditionalPanel;
	public Button modalButton;

	void Start () {
		Panel.gameObject.SetActive (false);
		if (AdditionalPanel != null)
			AdditionalPanel.gameObject.SetActive (false);
		GameObject Background = GameObject.Find ("Background");
	}

	public void showPanel() {
		if (AdditionalPanel != null)
			AdditionalPanel.gameObject.SetActive (false);
		Panel.gameObject.SetActive (true);
	}

	public void showAdditionalPanel() {
		Panel.gameObject.SetActive(false);
		AdditionalPanel.gameObject.SetActive (true);
	}

	public void closeStoreButton() {
		GameObject.Find ("StoreButton").gameObject.SetActive (false);
	}

	public void closeModalButton() {
		modalButton.gameObject.SetActive (false);
	}

	public void closeModal() {
		Panel.gameObject.SetActive (false);
		modalButton.gameObject.SetActive (true);
	}
}
