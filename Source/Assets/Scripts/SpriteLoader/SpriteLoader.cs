using UnityEngine;

public class SpriteLoader : MonoBehaviour
{

    public Sprite Alien1;


    void Update()
    {
        if (PlayerPrefs.GetInt("alienpicked") == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Alien1;
        }

    }

}
