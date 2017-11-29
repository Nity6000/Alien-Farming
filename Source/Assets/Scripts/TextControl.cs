using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{

    public Animator anim;
    private Text damageText;

    void Start()
    {
        AnimatorClipInfo[] clipInfo = anim.GetCurrentAnimatorClipInfo(0);
        Debug.Log(clipInfo.Length);
        Destroy(gameObject, clipInfo[0].clip.length);
        damageText = anim.GetComponent<Text>();

    }

    public void SetText(string text)
    {
        anim.GetComponent<Text>().text = text;
    }
}
