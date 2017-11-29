using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRightW : MonoBehaviour {

    public Sprite WheatRight;


    void Update()
    {
        if (PlayerPrefs.GetInt("RenderWheatRight") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = WheatRight;
        }
        if (PlayerPrefs.GetInt("RenderWheatRight") == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
