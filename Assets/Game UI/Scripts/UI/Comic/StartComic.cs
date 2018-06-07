using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LedokolUI;

namespace LedokolUI
{
    public class StartComic : MonoBehaviour
    {
        public GameObject comic;

        void Start()
        {
            comic.gameObject.SetActive(false);
        }

        void startComic()
        {
            GameObject.Find("ComicButton").gameObject.SetActive(false);
            GameObject.Find("CloseButton").gameObject.SetActive(false);
            comic.gameObject.SetActive(true);
            comic.GetComponent<Animation>().Play("comic");
        }
    }
}
