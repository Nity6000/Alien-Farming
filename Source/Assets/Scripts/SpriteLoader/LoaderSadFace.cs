using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderSadFace : MonoBehaviour {

    public Sprite SadFace;


    void Update()
    {
        if (PlayerPrefs.GetInt("RenderSadFace") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SadFace;
        }
        if (PlayerPrefs.GetInt("RenderSadFace") == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
