using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLeftW : MonoBehaviour {

    public Sprite WheatLeft;


    void Update()
    {
        if (PlayerPrefs.GetInt("RenderWheatLeft") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = WheatLeft;
        }
        if (PlayerPrefs.GetInt("RenderWheatLeft") == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
