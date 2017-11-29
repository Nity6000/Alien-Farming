using UnityEngine;

public class SpriteLoaderFace : MonoBehaviour {

    public Sprite CryFace;


	void Update () {
		if (PlayerPrefs.GetInt("RenderCryFace") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CryFace;
        }
        if (PlayerPrefs.GetInt("RenderCryFace") == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
