using System.Collections;
using UnityEngine;

public class ControllerText : MonoBehaviour {
    private static TextControl popupText;
    private static GameObject canvas;

    public static float posYstatic;

    void Start()
    {
        Initialize();
    }

    public static void Initialize()
    {
        canvas = GameObject.Find("Misc");
        if (!popupText)
            popupText = Resources.Load<TextControl>("Prefabs/PopupTextParent");
    }

    public static void CreateText(string text, Transform location, float posY)
    {
        posY = posYstatic;
        if (PlayerPrefs.GetInt("FruitSelected") == 1)
        {
            posY = 1.921f;
        }
        if (PlayerPrefs.GetInt("WheatSelected") == 1)
        {
            posY = 3.298f;
        }
        if (PlayerPrefs.GetInt("HarvestSelected") == 1)
        {
            if (PlayerPrefs.GetInt("HarvestingCrop") == 0)
            {
                posY = 3.298f;
                Debug.Log(posY);
            }
            if (PlayerPrefs.GetInt("HarvestingCrop") == 1)
            {
                posY = 1.921f;
                Debug.Log(posY);
            }
            else
            {
                Debug.Log(PlayerPrefs.GetInt("HarvestingCrop"));
            }
        }

        TextControl instance = Instantiate(popupText);
        Vector2 screenPosition = new Vector2(location.position.x + 6.3f, location.position.y + posY);

        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = screenPosition;
        instance.SetText(text);
    }

}
