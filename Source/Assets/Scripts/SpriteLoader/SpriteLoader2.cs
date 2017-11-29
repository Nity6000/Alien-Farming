using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLoader2 : MonoBehaviour
{

    public Sprite Alien2;


    void Update()
    {

        if (PlayerPrefs.GetInt("alienpicked") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Alien2;
        }
    }
}
