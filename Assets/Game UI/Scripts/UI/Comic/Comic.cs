using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LedokolUI;

namespace LedokolUI
{
    public class Comic : MonoBehaviour
    {
        public GameObject comic;

        void Awake()
        {
            comic.gameObject.SetActive(false);
        }

        void Start()
        {

        }

        public void StartComic()
        {
            GameObject.Find("ComicButton").gameObject.SetActive(false);
            GameObject.Find("CloseButton").gameObject.SetActive(false);
            comic.gameObject.SetActive(true);
            comic.GetComponent<Animation>().Play("comic");
        }
    }
}
