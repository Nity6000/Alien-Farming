using UnityEngine.UI;
using UnityEngine;

public class UIControl : MonoBehaviour
{

#pragma warning disable

    public InputField input;
    public Text txt;



    void Start()
    {

        PlayerPrefs.SetInt("loadGame", 0);
        string name = PlayerPrefs.GetString("SpeciesName");
        string message = ("Are you ready to deploy your " + name + "s into the wild");
        txt.GetComponent<UnityEngine.UI.Text>().text = message.ToString();
    }

    public void CharName()
    {
        PlayerPrefs.SetString("SpeciesName", input.text);
        if (PlayerPrefs.GetString("SpeciesName") == "a")
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
    }

    public void ChangeScene(string sceneName)
    {
        PlayerPrefs.SetInt("gameIsLoaded", 0);
        Application.LoadLevel(sceneName);
        PlayerPrefs.Save();
    }
    public void NewGame(string sceneName)
    {

        Application.LoadLevel(sceneName);        
        PlayerPrefs.SetInt("gameIsLoaded", 0);
        PlayerPrefs.Save();        
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void BackButton(string sceneName)
    {
        Application.LoadLevel(sceneName);
        PlayerPrefs.DeleteAll();
    }

    public void saveAlien0()
    {
        PlayerPrefs.SetInt("alienpicked", 0);
    }

    public void saveAlien1()
    {
        PlayerPrefs.SetInt("alienpicked", 1);
    }

    public void LoadGameplay()
    {
        PlayerPrefs.SetInt("gameIsLoaded", 1);
        Application.LoadLevel("Scenes/MainGame");
        PlayerPrefs.Save();
    }

}