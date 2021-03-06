﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace LedokolUI
{
    public class ItemManager : MonoBehaviour
    {
        public GameObject FramePrefab;

        public List<Item> itemList;

        private GameObject _detailsTransform;
        private GameObject _details;

        private void Awake()
        {
            _detailsTransform = GameObject.Find("Panel for items");
            _details = _detailsTransform.transform.Find("Details").gameObject;
        }

        void Start()
        {
            StartCoroutine(AddingItems());
        }

        IEnumerator AddingItems()
        {
            int i = 0;
            int itemsCount = itemList.Count;
            int y = 100;
            for (i = 0; i < itemsCount; i++)
            {
                GameObject el;
                if (i % 2 == 0)
                {
                    el = Instantiate(FramePrefab, new Vector2(-100, y), Quaternion.identity) as GameObject;
                }
                else
                {
                    el = Instantiate(FramePrefab, new Vector2(100, y), Quaternion.identity) as GameObject;
                    y -= 150;
                }
                el.transform.Find("name").GetComponent<Text>().text = itemList[i].name;
                el.transform.Find("picture").GetComponent<Image>().sprite = itemList[i].picture;
                el.transform.Find("baseValue").GetComponent<Text>().text = itemList[i].baseValue.ToString();
                el.transform.SetParent(gameObject.transform, false);
                int _i = i;
                el.GetComponent<Button>().onClick.AddListener(() => ShowDetails(itemList[_i].name, itemList[_i].picture, itemList[_i].description, itemList[_i].baseValue.ToString()));
            }
            yield return null;
        }

        private void ShowDetails(string name, Sprite picture, string description, string detailBaseValue)
        {
            _details.transform.Find("detailName").GetComponent<Text>().text = name;
            _details.transform.Find("detailPicture").GetComponent<Image>().sprite = picture;
            _details.transform.Find("detailDescription").GetComponent<Text>().text = description;
            _details.transform.Find("detailBaseValue").GetComponent<Text>().text = detailBaseValue;
            _details.gameObject.SetActive(true);
        }

        public void CloseDetails()
        {
            _details.gameObject.SetActive(false);
        }
    }
}
