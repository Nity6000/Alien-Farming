using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorLoaderSp : MonoBehaviour {

    public Sprite ErrorIcon;


    void Update()
    {
        if (PlayerPrefs.GetInt("RenderErrorIcon") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ErrorIcon;
        }
        if (PlayerPrefs.GetInt("RenderErrorIcon") == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
