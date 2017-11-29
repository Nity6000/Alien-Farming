using UnityEngine.UI;
using UnityEngine;

public class CropPlanting : MonoBehaviour
{
    // Graphical Wheat Counter
    public Text WheatCounterText;
    // Accesible Wheat Counter
    private static int StaticWheatCounter;
    // Graphical Fruit Counter @TODO
    public Text FruitCounterText;
    // Accesible Fruit Counter
    private static int StaticFruitCounter;
    // Error Window
    public Canvas ErrorWindow;
    //Random Number FAIL @TODO
    public int number;
    // Higlight Selected
    public Canvas WheatHighlight;
    public Canvas FruitHighlight;
    public Canvas HarvestHighlight;
    // For Method
    public static string amount;
    // Static Dirt
    public static string StaticDirt;


    // Crop Timer Values
    private float CropGrowTimer1 = 15f;
    private float CropGrowTimer2 = 15f;
    private float CropGrowTimer3 = 15f;
    private float CropGrowTimer4 = 15f;
    private float CropGrowTimer5 = 15f;
    private float CropGrowTimer6 = 15f;
    private float CropGrowTimer7 = 15f;
    private float CropGrowTimer8 = 15f;
    private float CropGrowTimer9 = 15f;
    private float CropGrowTimer10 = 15f;
    private float CropGrowTimer11 = 15f;
    private float CropGrowTimer12 = 15f;
    private float CropGrowTimer13 = 15f;
    private float CropGrowTimer14 = 15f;
    private float CropGrowTimer15 = 15f;
    private float CropGrowTimer16 = 15f;
    private float CropGrowTimer17 = 15f;
    private float CropGrowTimer18 = 15f;
    private float CropGrowTimer19 = 15f;
    private float CropGrowTimer20 = 15f;
    private float CropGrowTimer21 = 15f;
    private float CropGrowTimer22 = 15f;
    private float CropGrowTimer23 = 15f;
    private float CropGrowTimer24 = 15f;
    private float CropGrowTimer25 = 15f;

    // Textures
    public Sprite WheatTex;
    public Sprite WheatSeedsTex;
    public Sprite FruitTex;
    public Sprite DirtTex;
    public Sprite FruitSeedsTex;

    // Tile Map Engine
    public Button DirtTile1;
    public Button DirtTile2;
    public Button DirtTile3;
    public Button DirtTile4;
    public Button DirtTile5;
    public Button DirtTile6;
    public Button DirtTile7;
    public Button DirtTile8;
    public Button DirtTile9;
    public Button DirtTile10;
    public Button DirtTile11;
    public Button DirtTile12;
    public Button DirtTile13;
    public Button DirtTile14;
    public Button DirtTile15;
    public Button DirtTile16;
    public Button DirtTile17;
    public Button DirtTile18;
    public Button DirtTile19;
    public Button DirtTile20;
    public Button DirtTile21;
    public Button DirtTile22;
    public Button DirtTile23;
    public Button DirtTile24;
    public Button DirtTile25;

    void Awake()
    {
        
        // Default Selection
        WheatHighlight.enabled = false;
        HarvestHighlight.enabled = false;
        FruitHighlight.enabled = false;
        PlayerPrefs.SetInt("WheatSelected", 0);
        PlayerPrefs.SetInt("FruitSelected", 0);
        PlayerPrefs.SetInt("HarvestSelected", 0);
    }


    public void SelectWheat()
    {
        WheatHighlight.enabled = true;
        HarvestHighlight.enabled = false;
        FruitHighlight.enabled = false;
        PlayerPrefs.SetInt("WheatSelected", 1);
        PlayerPrefs.SetInt("FruitSelected", 0);
        PlayerPrefs.SetInt("HarvestSelected", 0);

    }

    public void SelectFruit()
    {
        WheatHighlight.enabled = false;
        HarvestHighlight.enabled = false;
        FruitHighlight.enabled = true;
        PlayerPrefs.SetInt("FruitSelected", 1);
        PlayerPrefs.SetInt("WheatSelected", 0);
        PlayerPrefs.SetInt("HarvestSelected", 0);
    }

    public void SelectHarvest()
    {
        WheatHighlight.enabled = false;
        HarvestHighlight.enabled = true;
        FruitHighlight.enabled = false;
        PlayerPrefs.SetInt("HarvestSelected", 1);
        PlayerPrefs.SetInt("WheatSelected", 0);
        PlayerPrefs.SetInt("FruitSelected", 0);
    }

    public void OKClicked()
    {
        // Disable Error Window
        ErrorWindow.enabled = false;

        PlayerPrefs.SetInt("RenderCryFace", 0);
        PlayerPrefs.SetInt("RenderSadFace", 0);
        PlayerPrefs.SetInt("RenderWheatLeft", 0);
        PlayerPrefs.SetInt("RenderWheatRight", 0);
        PlayerPrefs.SetInt("RenderErrorIcon", 0);
    }

    public void DirtClicked(Button dirt)
    {

        if (PlayerPrefs.GetInt("HarvestSelected") == 1)
        {
            if (dirt.image.sprite == WheatTex)

            {
                PlayerPrefs.SetInt("HarvestingCrop", 0);
                amount = "+2";
                ControllerText.CreateText(amount, transform, ControllerText.posYstatic);
                if (PlayerPrefs.GetInt("breakpoint") == 1)
                {
                    if (dirt == DirtTile1)
                    {
                        PlayerPrefs.SetInt("wheatTimer1", 0);

                    }
                    if (dirt == DirtTile2)
                    {

                        PlayerPrefs.SetInt("wheatTimer2", 0);
                    }
                    if (dirt == DirtTile3)
                    {
                        PlayerPrefs.SetInt("wheatTimer3", 0);
                    }
                    if (dirt == DirtTile4)
                    {
                        PlayerPrefs.SetInt("wheatTimer4", 0);
                    }
                    if (dirt == DirtTile5)
                    {
                        PlayerPrefs.SetInt("wheatTimer5", 0);
                    }
                    if (dirt == DirtTile6)
                    {
                        PlayerPrefs.SetInt("wheatTimer6", 0);
                    }
                    if (dirt == DirtTile7)
                    {
                        PlayerPrefs.SetInt("wheatTimer7", 0);
                    }
                    if (dirt == DirtTile8)
                    {
                        PlayerPrefs.SetInt("wheatTimer8", 0);
                    }
                    if (dirt == DirtTile9)
                    {
                        PlayerPrefs.SetInt("wheatTimer9", 0);
                    }
                    if (dirt == DirtTile10)
                    {
                        PlayerPrefs.SetInt("wheatTimer10", 0);
                    }
                    if (dirt == DirtTile11)
                    {
                        PlayerPrefs.SetInt("wheatTimer11", 0);
                    }
                    if (dirt == DirtTile12)
                    {
                        PlayerPrefs.SetInt("wheatTimer12", 0);
                    }
                    if (dirt == DirtTile13)
                    {
                        PlayerPrefs.SetInt("wheatTimer13", 0);
                    }
                    if (dirt == DirtTile14)
                    {
                        PlayerPrefs.SetInt("wheatTimer14", 0);
                    }
                    if (dirt == DirtTile15)
                    {
                        PlayerPrefs.SetInt("wheatTimer15", 0);
                    }
                    if (dirt == DirtTile16)
                    {
                        PlayerPrefs.SetInt("wheatTimer16", 0);
                    }
                    if (dirt == DirtTile17)
                    {
                        PlayerPrefs.SetInt("wheatTimer17", 0);
                    }
                    if (dirt == DirtTile18)
                    {
                        PlayerPrefs.SetInt("wheatTimer18", 0);
                    }
                    if (dirt == DirtTile19)
                    {
                        PlayerPrefs.SetInt("wheatTimer19", 0);
                    }
                    if (dirt == DirtTile20)
                    {
                        PlayerPrefs.SetInt("wheatTimer20", 0);
                    }
                    if (dirt == DirtTile21)
                    {
                        PlayerPrefs.SetInt("wheatTimer21", 0);
                    }
                    if (dirt == DirtTile22)
                    {
                        PlayerPrefs.SetInt("wheatTimer22", 0);
                    }
                    if (dirt == DirtTile23)
                    {
                        PlayerPrefs.SetInt("wheatTimer23", 0);
                    }
                    if (dirt == DirtTile24)
                    {
                        PlayerPrefs.SetInt("wheatTimer24", 0);
                    }
                    if (dirt == DirtTile25)
                    {
                        PlayerPrefs.SetInt("wheatTimer25", 0);
                    }

                }

                dirt.image.sprite = DirtTex;
            }

            if (dirt.image.sprite == FruitTex)

            {
                PlayerPrefs.SetInt("HarvestingCrop", 1);
                amount = "+2";
                ControllerText.CreateText(amount, transform, ControllerText.posYstatic);
                if (PlayerPrefs.GetInt("breakpoint") == 1)
                {
                    if (dirt == DirtTile1)
                    {
                        PlayerPrefs.SetInt("fruitTimer1", 0);

                    }
                    if (dirt == DirtTile2)
                    {

                        PlayerPrefs.SetInt("fruitTimer2", 0);
                    }
                    if (dirt == DirtTile3)
                    {
                        PlayerPrefs.SetInt("fruitTimer3", 0);
                    }
                    if (dirt == DirtTile4)
                    {
                        PlayerPrefs.SetInt("fruitTimer4", 0);
                    }
                    if (dirt == DirtTile5)
                    {
                        PlayerPrefs.SetInt("fruitTimer5", 0);
                    }
                    if (dirt == DirtTile6)
                    {
                        PlayerPrefs.SetInt("fruitTimer6", 0);
                    }
                    if (dirt == DirtTile7)
                    {
                        PlayerPrefs.SetInt("fruitTimer7", 0);
                    }
                    if (dirt == DirtTile8)
                    {
                        PlayerPrefs.SetInt("fruitTimer8", 0);
                    }
                    if (dirt == DirtTile9)
                    {
                        PlayerPrefs.SetInt("fruitTimer9", 0);
                    }
                    if (dirt == DirtTile10)
                    {
                        PlayerPrefs.SetInt("fruitTimer10", 0);
                    }
                    if (dirt == DirtTile11)
                    {
                        PlayerPrefs.SetInt("fruitTimer11", 0);
                    }
                    if (dirt == DirtTile12)
                    {
                        PlayerPrefs.SetInt("fruitTimer12", 0);
                    }
                    if (dirt == DirtTile13)
                    {
                        PlayerPrefs.SetInt("fruitTimer13", 0);
                    }
                    if (dirt == DirtTile14)
                    {
                        PlayerPrefs.SetInt("fruitTimer14", 0);
                    }
                    if (dirt == DirtTile15)
                    {
                        PlayerPrefs.SetInt("fruitTimer15", 0);
                    }
                    if (dirt == DirtTile16)
                    {
                        PlayerPrefs.SetInt("fruitTimer16", 0);
                    }
                    if (dirt == DirtTile17)
                    {
                        PlayerPrefs.SetInt("fruitTimer17", 0);
                    }
                    if (dirt == DirtTile18)
                    {
                        PlayerPrefs.SetInt("fruitTimer18", 0);
                    }
                    if (dirt == DirtTile19)
                    {
                        PlayerPrefs.SetInt("fruitTimer19", 0);
                    }
                    if (dirt == DirtTile20)
                    {
                        PlayerPrefs.SetInt("fruitTimer20", 0);
                    }
                    if (dirt == DirtTile21)
                    {
                        PlayerPrefs.SetInt("fruitTimer21", 0);
                    }
                    if (dirt == DirtTile22)
                    {
                        PlayerPrefs.SetInt("fruitTimer22", 0);
                    }
                    if (dirt == DirtTile23)
                    {
                        PlayerPrefs.SetInt("fruitTimer23", 0);
                    }
                    if (dirt == DirtTile24)
                    {
                        PlayerPrefs.SetInt("fruitTimer24", 0);
                    }
                    if (dirt == DirtTile25)
                    {
                        PlayerPrefs.SetInt("fruitTimer25", 0);
                    }

                }

                dirt.image.sprite = DirtTex;
            }

        }

        if (PlayerPrefs.GetInt("WheatSelected") == 1)
        {
            if (StaticWheatCounter != 0)
            {
                amount = "-1";
                ControllerText.CreateText(amount, transform, ControllerText.posYstatic);
                dirt.image.sprite = WheatSeedsTex;
            }

            if (StaticWheatCounter == 0)
            {
                if (PlayerPrefs.GetInt("breakpoint") == 1)
                {
                    ErrorWindow.enabled = true;
                    PlayerPrefs.SetInt("RenderCryFace", 1);
                    PlayerPrefs.SetInt("RenderSadFace", 1);
                    PlayerPrefs.SetInt("RenderWheatLeft", 1);
                    PlayerPrefs.SetInt("RenderWheatRight", 1);
                    PlayerPrefs.SetInt("RenderErrorIcon", 1);

                }
            }

            if (PlayerPrefs.GetInt("breakpoint") == 1)
            {
                if (dirt == DirtTile1)
                {
                    PlayerPrefs.SetInt("wheatTimer1", 1);
                    CropGrowTimer1 = 15f;
                }
                if (dirt == DirtTile2)
                {
                    CropGrowTimer2 = 15f;
                    PlayerPrefs.SetInt("wheatTimer2", 1);
                }
                if (dirt == DirtTile3)
                {
                    PlayerPrefs.SetInt("wheatTimer3", 1);
                    CropGrowTimer3 = 15f;
                }
                if (dirt == DirtTile4)
                {
                    PlayerPrefs.SetInt("wheatTimer4", 1);
                    CropGrowTimer4 = 15f;
                }
                if (dirt == DirtTile5)
                {
                    PlayerPrefs.SetInt("wheatTimer5", 1);
                    CropGrowTimer5 = 15f;
                }
                if (dirt == DirtTile6)
                {
                    PlayerPrefs.SetInt("wheatTimer6", 1);
                    CropGrowTimer6 = 15f;

                }
                if (dirt == DirtTile7)
                {
                    PlayerPrefs.SetInt("wheatTimer7", 1);
                    CropGrowTimer7 = 15f;

                }
                if (dirt == DirtTile8)
                {
                    PlayerPrefs.SetInt("wheatTimer8", 1);
                    CropGrowTimer8 = 15f;

                }
                if (dirt == DirtTile9)
                {
                    PlayerPrefs.SetInt("wheatTimer9", 1);
                    CropGrowTimer9 = 15f;

                }
                if (dirt == DirtTile10)
                {
                    PlayerPrefs.SetInt("wheatTimer10", 1);
                    CropGrowTimer10 = 15f;

                }
                if (dirt == DirtTile11)
                {
                    PlayerPrefs.SetInt("wheatTimer11", 1);
                    CropGrowTimer11 = 15f;
                }
                if (dirt == DirtTile12)
                {
                    PlayerPrefs.SetInt("wheatTimer12", 1);
                    CropGrowTimer12 = 15f;
                }
                if (dirt == DirtTile13)
                {
                    PlayerPrefs.SetInt("wheatTimer13", 1);
                    CropGrowTimer13 = 15f;
                }
                if (dirt == DirtTile14)
                {
                    PlayerPrefs.SetInt("wheatTimer14", 1);
                    CropGrowTimer14 = 15f;
                }
                if (dirt == DirtTile15)
                {
                    PlayerPrefs.SetInt("wheatTimer15", 1);
                    CropGrowTimer15 = 15f;
                }
                if (dirt == DirtTile16)
                {
                    PlayerPrefs.SetInt("wheatTimer16", 1);
                    CropGrowTimer16 = 15f;
                }
                if (dirt == DirtTile17)
                {
                    PlayerPrefs.SetInt("wheatTimer17", 1);
                    CropGrowTimer17 = 15f;
                }
                if (dirt == DirtTile18)
                {
                    PlayerPrefs.SetInt("wheatTimer18", 1);
                    CropGrowTimer18 = 15f;
                }
                if (dirt == DirtTile19)
                {
                    PlayerPrefs.SetInt("wheatTimer19", 1);
                    CropGrowTimer19 = 15f;
                }
                if (dirt == DirtTile20)
                {
                    PlayerPrefs.SetInt("wheatTimer20", 1);
                    CropGrowTimer20 = 15f;
                }
                if (dirt == DirtTile21)
                {
                    PlayerPrefs.SetInt("wheatTimer21", 1);
                    CropGrowTimer21 = 15f;
                }
                if (dirt == DirtTile22)
                {
                    PlayerPrefs.SetInt("wheatTimer22", 1);
                    CropGrowTimer22 = 15f;
                }
                if (dirt == DirtTile23)
                {
                    PlayerPrefs.SetInt("wheatTimer23", 1);
                    CropGrowTimer23 = 15f;
                }
                if (dirt == DirtTile24)
                {
                    PlayerPrefs.SetInt("wheatTimer24", 1);
                    CropGrowTimer24 = 15f;
                }
                if (dirt == DirtTile25)
                {
                    PlayerPrefs.SetInt("wheatTimer25", 1);
                    CropGrowTimer25 = 15f;
                }
            }


            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("FruitSelected") == 1)
        {
            if (StaticFruitCounter != 0)
            {
                amount = "-1";
                ControllerText.CreateText(amount, transform, ControllerText.posYstatic);
                dirt.image.sprite = FruitSeedsTex;
            }

            if (StaticFruitCounter == 0)
            {
                if (PlayerPrefs.GetInt("breakpoint") == 1)
                {
                    ErrorWindow.enabled = true;
                    PlayerPrefs.SetInt("RenderCryFace", 1);
                    PlayerPrefs.SetInt("RenderSadFace", 1);
                    PlayerPrefs.SetInt("RenderWheatLeft", 1);
                    PlayerPrefs.SetInt("RenderWheatRight", 1);
                    PlayerPrefs.SetInt("RenderErrorIcon", 1);

                }
            }

            if (PlayerPrefs.GetInt("breakpoint") == 1)
            {
                if (dirt == DirtTile1)
                {
                    PlayerPrefs.SetInt("fruitTimer1", 1);
                    CropGrowTimer1 = 15f;
                }
                if (dirt == DirtTile2)
                {
                    CropGrowTimer2 = 15f;
                    PlayerPrefs.SetInt("fruitTimer2", 1);
                }
                if (dirt == DirtTile3)
                {
                    PlayerPrefs.SetInt("fruitTimer3", 1);
                    CropGrowTimer3 = 15f;
                }
                if (dirt == DirtTile4)
                {
                    PlayerPrefs.SetInt("fruitTimer4", 1);
                    CropGrowTimer4 = 15f;
                }
                if (dirt == DirtTile5)
                {
                    PlayerPrefs.SetInt("fruitTimer5", 1);
                    CropGrowTimer5 = 15f;
                }
                if (dirt == DirtTile6)
                {
                    PlayerPrefs.SetInt("fruitTimer6", 1);
                    CropGrowTimer6 = 15f;

                }
                if (dirt == DirtTile7)
                {
                    PlayerPrefs.SetInt("fruitTimer7", 1);
                    CropGrowTimer7 = 15f;

                }
                if (dirt == DirtTile8)
                {
                    PlayerPrefs.SetInt("fruitTimer8", 1);
                    CropGrowTimer8 = 15f;

                }
                if (dirt == DirtTile9)
                {
                    PlayerPrefs.SetInt("fruitTimer9", 1);
                    CropGrowTimer9 = 15f;

                }
                if (dirt == DirtTile10)
                {
                    PlayerPrefs.SetInt("fruitTimer10", 1);
                    CropGrowTimer10 = 15f;

                }
                if (dirt == DirtTile11)
                {
                    PlayerPrefs.SetInt("fruitTimer11", 1);
                    CropGrowTimer11 = 15f;
                }
                if (dirt == DirtTile12)
                {
                    PlayerPrefs.SetInt("fruitTimer12", 1);
                    CropGrowTimer12 = 15f;
                }
                if (dirt == DirtTile13)
                {
                    PlayerPrefs.SetInt("fruitTimer13", 1);
                    CropGrowTimer13 = 15f;
                }
                if (dirt == DirtTile14)
                {
                    PlayerPrefs.SetInt("fruitTimer14", 1);
                    CropGrowTimer14 = 15f;
                }
                if (dirt == DirtTile15)
                {
                    PlayerPrefs.SetInt("fruitTimer15", 1);
                    CropGrowTimer15 = 15f;
                }
                if (dirt == DirtTile16)
                {
                    PlayerPrefs.SetInt("fruitTimer16", 1);
                    CropGrowTimer16 = 15f;
                }
                if (dirt == DirtTile17)
                {
                    PlayerPrefs.SetInt("fruitTimer17", 1);
                    CropGrowTimer17 = 15f;
                }
                if (dirt == DirtTile18)
                {
                    PlayerPrefs.SetInt("fruitTimer18", 1);
                    CropGrowTimer18 = 15f;
                }
                if (dirt == DirtTile19)
                {
                    PlayerPrefs.SetInt("fruitTimer19", 1);
                    CropGrowTimer19 = 15f;
                }
                if (dirt == DirtTile20)
                {
                    PlayerPrefs.SetInt("fruitTimer20", 1);
                    CropGrowTimer20 = 15f;
                }
                if (dirt == DirtTile21)
                {
                    PlayerPrefs.SetInt("fruitTimer21", 1);
                    CropGrowTimer21 = 15f;
                }
                if (dirt == DirtTile22)
                {
                    PlayerPrefs.SetInt("fruitTimer22", 1);
                    CropGrowTimer22 = 15f;
                }
                if (dirt == DirtTile23)
                {
                    PlayerPrefs.SetInt("fruitTimer23", 1);
                    CropGrowTimer23 = 15f;
                }
                if (dirt == DirtTile24)
                {
                    PlayerPrefs.SetInt("fruitTimer24", 1);
                    CropGrowTimer24 = 15f;
                }
                if (dirt == DirtTile25)
                {
                    PlayerPrefs.SetInt("fruitTimer25", 1);
                    CropGrowTimer25 = 15f;
                }
            }

            PlayerPrefs.Save();
        }
    }

    public void DirtTileSave(string dirtTile)
    {
        if (PlayerPrefs.GetInt("HarvestSelected") == 1)
        {
            if (PlayerPrefs.GetString(dirtTile) == "wheat")
            {

                PlayerPrefs.SetString(dirtTile, "dirt");
                PlayerPrefs.SetInt("WheatCounter", StaticWheatCounter += number);
            }
            if (PlayerPrefs.GetString(dirtTile) == "fruit")
            {

                PlayerPrefs.SetString(dirtTile, "dirt");
                PlayerPrefs.SetInt("FruitCounter", StaticFruitCounter += number);
            }

        }

        if (PlayerPrefs.GetInt("WheatSelected") == 1)
        {


            if (PlayerPrefs.GetString(dirtTile) != "wheatseeded")
            {
                if (StaticWheatCounter != 0)
                {
                    PlayerPrefs.SetInt("WheatCounter", StaticWheatCounter -= 1);
                }

            }

            if (StaticWheatCounter != 0)
            {
                PlayerPrefs.SetString(dirtTile, "wheatseeded");
            }

            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("FruitSelected") == 1)
        {


            if (PlayerPrefs.GetString(dirtTile) != "fruitseeded")
            {
                if (StaticFruitCounter != 0)
                {
                    PlayerPrefs.SetInt("FruitCounter", StaticFruitCounter -= 1);
                }

            }

            if (StaticFruitCounter != 0)
            {
                PlayerPrefs.SetString(dirtTile, "fruitseeded");
            }

            PlayerPrefs.Save();
        }
    }


    void FixedUpdate()
    {
        // Set Wheat Counter Digital to Graphical        
        int WheatCounter = PlayerPrefs.GetInt("WheatCounter");
        StaticWheatCounter = WheatCounter;
        WheatCounterText.GetComponent<UnityEngine.UI.Text>().text = WheatCounter.ToString();

        // Set Fruit Counter Digital to Graphical
        int FruitCounter = PlayerPrefs.GetInt("FruitCounter");
        StaticWheatCounter = WheatCounter;
        FruitCounterText.GetComponent<UnityEngine.UI.Text>().text = FruitCounter.ToString();

        Debug.Log(PlayerPrefs.GetInt("gameIsLoaded"));

        // Wheat Timers
        if (PlayerPrefs.GetInt("breakpoint") == 1)
        {
            if (PlayerPrefs.GetInt("wheatTimer1") == 1)
            {
                CropGrowTimer1 -= Time.deltaTime;
                if (CropGrowTimer1 <= 0)
                {
                    CropGrowTimer1 = 0;
                    PlayerPrefs.SetString("dirtTile0", "wheat");
                    DirtTile1.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer2") == 1)
            {

                CropGrowTimer2 -= Time.deltaTime;
                if (CropGrowTimer2 <= 0)
                {
                    CropGrowTimer2 = 0;
                    PlayerPrefs.SetString("dirtTile1", "wheat");
                    DirtTile2.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer3") == 1)
            {
                CropGrowTimer3 -= Time.deltaTime;
                if (CropGrowTimer3 <= 0)
                {
                    CropGrowTimer3 = 0;
                    PlayerPrefs.SetString("dirtTile2", "wheat");
                    DirtTile3.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer4") == 1)
            {
                CropGrowTimer4 -= Time.deltaTime;
                if (CropGrowTimer4 <= 0)
                {
                    CropGrowTimer4 = 0;
                    PlayerPrefs.SetString("dirtTile3", "wheat");
                    DirtTile4.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer5") == 1)
            {
                CropGrowTimer5 -= Time.deltaTime;
                if (CropGrowTimer5 <= 0)
                {
                    CropGrowTimer5 = 0;
                    PlayerPrefs.SetString("dirtTile4", "wheat");
                    DirtTile5.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer6") == 1)
            {
                CropGrowTimer6 -= Time.deltaTime;
                if (CropGrowTimer6 <= 0)
                {
                    CropGrowTimer6 = 0;
                    PlayerPrefs.SetString("dirtTile5", "wheat");
                    DirtTile6.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer7") == 1)
            {
                CropGrowTimer7 -= Time.deltaTime;
                if (CropGrowTimer7 <= 0)
                {
                    CropGrowTimer7 = 0;
                    PlayerPrefs.SetString("dirtTile6", "wheat");
                    DirtTile7.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer8") == 1)
            {
                CropGrowTimer8 -= Time.deltaTime;
                if (CropGrowTimer8 <= 0)
                {
                    CropGrowTimer8 = 0;
                    PlayerPrefs.SetString("dirtTile7", "wheat");
                    DirtTile8.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer9") == 1)
            {
                CropGrowTimer9 -= Time.deltaTime;
                if (CropGrowTimer9 <= 0)
                {
                    CropGrowTimer9 = 0;
                    PlayerPrefs.SetString("dirtTile8", "wheat");
                    DirtTile9.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer10") == 1)
            {
                CropGrowTimer10 -= Time.deltaTime;
                if (CropGrowTimer10 <= 0)
                {
                    CropGrowTimer10 = 0;
                    PlayerPrefs.SetString("dirtTile9", "wheat");
                    DirtTile10.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer11") == 1)
            {
                CropGrowTimer11 -= Time.deltaTime;
                if (CropGrowTimer11 <= 0)
                {
                    CropGrowTimer11 = 0;
                    PlayerPrefs.SetString("dirtTile10", "wheat");
                    DirtTile11.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer12") == 1)
            {
                CropGrowTimer12 -= Time.deltaTime;
                if (CropGrowTimer12 <= 0)
                {
                    CropGrowTimer12 = 0;
                    PlayerPrefs.SetString("dirtTile11", "wheat");
                    DirtTile12.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer13") == 1)
            {
                CropGrowTimer13 -= Time.deltaTime;
                if (CropGrowTimer13 <= 0)
                {
                    CropGrowTimer13 = 0;
                    PlayerPrefs.SetString("dirtTile12", "wheat");
                    DirtTile13.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer14") == 1)
            {
                CropGrowTimer14 -= Time.deltaTime;
                if (CropGrowTimer14 <= 0)
                {
                    CropGrowTimer14 = 0;
                    PlayerPrefs.SetString("dirtTile13", "wheat");
                    DirtTile14.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer15") == 1)
            {
                CropGrowTimer15 -= Time.deltaTime;
                if (CropGrowTimer15 <= 0)
                {
                    CropGrowTimer15 = 0;
                    PlayerPrefs.SetString("dirtTile14", "wheat");
                    DirtTile15.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer16") == 1)
            {
                CropGrowTimer16 -= Time.deltaTime;
                if (CropGrowTimer16 <= 0)
                {
                    CropGrowTimer16 = 0;
                    PlayerPrefs.SetString("dirtTile15", "wheat");
                    DirtTile16.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer17") == 1)
            {
                CropGrowTimer17 -= Time.deltaTime;
                if (CropGrowTimer17 <= 0)
                {
                    CropGrowTimer17 = 0;
                    PlayerPrefs.SetString("dirtTile16", "wheat");
                    DirtTile17.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer18") == 1)
            {
                CropGrowTimer18 -= Time.deltaTime;
                if (CropGrowTimer18 <= 0)
                {
                    CropGrowTimer18 = 0;
                    PlayerPrefs.SetString("dirtTile17", "wheat");
                    DirtTile18.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer19") == 1)
            {
                CropGrowTimer19 -= Time.deltaTime;
                if (CropGrowTimer19 <= 0)
                {
                    CropGrowTimer19 = 0;
                    PlayerPrefs.SetString("dirtTile18", "wheat");
                    DirtTile19.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer20") == 1)
            {
                CropGrowTimer20 -= Time.deltaTime;
                if (CropGrowTimer20 <= 0)
                {
                    CropGrowTimer20 = 0;
                    DirtTile20.image.sprite = WheatTex;
                    PlayerPrefs.SetString("dirtTile19", "wheat");
                }
            }
            if (PlayerPrefs.GetInt("wheatTimer21") == 1)
            {
                CropGrowTimer21 -= Time.deltaTime;
                if (CropGrowTimer21 <= 0)
                {
                    CropGrowTimer21 = 0;
                    PlayerPrefs.SetString("dirtTile20", "wheat");
                    DirtTile21.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer22") == 1)
            {
                CropGrowTimer22 -= Time.deltaTime;
                if (CropGrowTimer22 <= 0)
                {
                    CropGrowTimer22 = 0;
                    PlayerPrefs.SetString("dirtTile21", "wheat");
                    DirtTile22.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer23") == 1)
            {
                CropGrowTimer23 -= Time.deltaTime;
                if (CropGrowTimer23 <= 0)
                {
                    CropGrowTimer23 = 0;
                    PlayerPrefs.SetString("dirtTile22", "wheat");
                    DirtTile23.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer24") == 1)
            {
                CropGrowTimer24 -= Time.deltaTime;
                if (CropGrowTimer24 <= 0)
                {
                    CropGrowTimer24 = 0;
                    PlayerPrefs.SetString("dirtTile23", "wheat");
                    DirtTile24.image.sprite = WheatTex;

                }
            }
            if (PlayerPrefs.GetInt("wheatTimer25") == 1)
            {
                CropGrowTimer25 -= Time.deltaTime;
                if (CropGrowTimer25 <= 0)
                {
                    CropGrowTimer25 = 0;
                    PlayerPrefs.SetString("dirtTile24", "wheat");
                    DirtTile25.image.sprite = WheatTex;

                }
            }
        }

        // Fruit Timers
        if (PlayerPrefs.GetInt("breakpoint") == 1)
        {
            if (PlayerPrefs.GetInt("fruitTimer1") == 1)
            {

                CropGrowTimer1 -= Time.deltaTime;
                if (CropGrowTimer1 <= 0)
                {
                    CropGrowTimer1 = 0;
                    PlayerPrefs.SetString("dirtTile0", "fruit");
                    DirtTile1.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer2") == 1)
            {

                CropGrowTimer2 -= Time.deltaTime;
                if (CropGrowTimer2 <= 0)
                {
                    CropGrowTimer2 = 0;
                    PlayerPrefs.SetString("dirtTile1", "fruit");
                    DirtTile2.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer3") == 1)
            {
                CropGrowTimer3 -= Time.deltaTime;
                if (CropGrowTimer3 <= 0)
                {
                    CropGrowTimer3 = 0;
                    PlayerPrefs.SetString("dirtTile2", "fruit");
                    DirtTile3.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer4") == 1)
            {
                CropGrowTimer4 -= Time.deltaTime;
                if (CropGrowTimer4 <= 0)
                {
                    CropGrowTimer4 = 0;
                    PlayerPrefs.SetString("dirtTile3", "fruit");
                    DirtTile4.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer5") == 1)
            {
                CropGrowTimer5 -= Time.deltaTime;
                if (CropGrowTimer5 <= 0)
                {
                    CropGrowTimer5 = 0;
                    PlayerPrefs.SetString("dirtTile4", "fruit");
                    DirtTile5.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer6") == 1)
            {
                CropGrowTimer6 -= Time.deltaTime;
                if (CropGrowTimer6 <= 0)
                {
                    CropGrowTimer6 = 0;
                    PlayerPrefs.SetString("dirtTile5", "fruit");
                    DirtTile6.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer7") == 1)
            {
                CropGrowTimer7 -= Time.deltaTime;
                if (CropGrowTimer7 <= 0)
                {
                    CropGrowTimer7 = 0;
                    PlayerPrefs.SetString("dirtTile6", "fruit");
                    DirtTile7.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer8") == 1)
            {
                CropGrowTimer8 -= Time.deltaTime;
                if (CropGrowTimer8 <= 0)
                {
                    CropGrowTimer8 = 0;
                    PlayerPrefs.SetString("dirtTile7", "fruit");
                    DirtTile8.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer9") == 1)
            {
                CropGrowTimer9 -= Time.deltaTime;
                if (CropGrowTimer9 <= 0)
                {
                    CropGrowTimer9 = 0;
                    PlayerPrefs.SetString("dirtTile8", "fruit");
                    DirtTile9.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer10") == 1)
            {
                CropGrowTimer10 -= Time.deltaTime;
                if (CropGrowTimer10 <= 0)
                {
                    CropGrowTimer10 = 0;
                    PlayerPrefs.SetString("dirtTile9", "fruit");
                    DirtTile10.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer11") == 1)
            {
                CropGrowTimer11 -= Time.deltaTime;
                if (CropGrowTimer11 <= 0)
                {
                    CropGrowTimer11 = 0;
                    PlayerPrefs.SetString("dirtTile10", "fruit");
                    DirtTile11.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer12") == 1)
            {
                CropGrowTimer12 -= Time.deltaTime;
                if (CropGrowTimer12 <= 0)
                {
                    CropGrowTimer12 = 0;
                    PlayerPrefs.SetString("dirtTile11", "fruit");
                    DirtTile12.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer13") == 1)
            {
                CropGrowTimer13 -= Time.deltaTime;
                if (CropGrowTimer13 <= 0)
                {
                    CropGrowTimer13 = 0;
                    PlayerPrefs.SetString("dirtTile12", "fruit");
                    DirtTile13.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer14") == 1)
            {
                CropGrowTimer14 -= Time.deltaTime;
                if (CropGrowTimer14 <= 0)
                {
                    CropGrowTimer14 = 0;
                    PlayerPrefs.SetString("dirtTile13", "fruit");
                    DirtTile14.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer15") == 1)
            {
                CropGrowTimer15 -= Time.deltaTime;
                if (CropGrowTimer15 <= 0)
                {
                    CropGrowTimer15 = 0;
                    PlayerPrefs.SetString("dirtTile14", "fruit");
                    DirtTile15.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer16") == 1)
            {
                CropGrowTimer16 -= Time.deltaTime;
                if (CropGrowTimer16 <= 0)
                {
                    CropGrowTimer16 = 0;
                    PlayerPrefs.SetString("dirtTile15", "fruit");
                    DirtTile16.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer17") == 1)
            {
                CropGrowTimer17 -= Time.deltaTime;
                if (CropGrowTimer17 <= 0)
                {
                    CropGrowTimer17 = 0;
                    PlayerPrefs.SetString("dirtTile16", "fruit");
                    DirtTile17.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer18") == 1)
            {
                CropGrowTimer18 -= Time.deltaTime;
                if (CropGrowTimer18 <= 0)
                {
                    CropGrowTimer18 = 0;
                    PlayerPrefs.SetString("dirtTile17", "fruit");
                    DirtTile18.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer19") == 1)
            {
                CropGrowTimer19 -= Time.deltaTime;
                if (CropGrowTimer19 <= 0)
                {
                    CropGrowTimer19 = 0;
                    PlayerPrefs.SetString("dirtTile18", "fruit");
                    DirtTile19.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer20") == 1)
            {
                CropGrowTimer20 -= Time.deltaTime;
                if (CropGrowTimer20 <= 0)
                {
                    CropGrowTimer20 = 0;
                    DirtTile20.image.sprite = FruitTex;
                    PlayerPrefs.SetString("dirtTile19", "fruit");
                }
            }
            if (PlayerPrefs.GetInt("fruitTimer21") == 1)
            {
                CropGrowTimer21 -= Time.deltaTime;
                if (CropGrowTimer21 <= 0)
                {
                    CropGrowTimer21 = 0;
                    PlayerPrefs.SetString("dirtTile20", "fruit");
                    DirtTile21.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer22") == 1)
            {
                CropGrowTimer22 -= Time.deltaTime;
                if (CropGrowTimer22 <= 0)
                {
                    CropGrowTimer22 = 0;
                    PlayerPrefs.SetString("dirtTile21", "fruit");
                    DirtTile22.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer23") == 1)
            {
                CropGrowTimer23 -= Time.deltaTime;
                if (CropGrowTimer23 <= 0)
                {
                    CropGrowTimer23 = 0;
                    PlayerPrefs.SetString("dirtTile22", "fruit");
                    DirtTile23.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer24") == 1)
            {
                CropGrowTimer24 -= Time.deltaTime;
                if (CropGrowTimer24 <= 0)
                {
                    CropGrowTimer24 = 0;
                    PlayerPrefs.SetString("dirtTile23", "fruit");
                    DirtTile24.image.sprite = FruitTex;

                }
            }
            if (PlayerPrefs.GetInt("fruitTimer25") == 1)
            {
                CropGrowTimer25 -= Time.deltaTime;
                if (CropGrowTimer25 <= 0)
                {
                    CropGrowTimer25 = 0;
                    PlayerPrefs.SetString("dirtTile24", "fruit");
                    DirtTile25.image.sprite = FruitTex;

                }
            }
        }
    }


    void Start()
    {
        // Randomize FAIL
        number = Random.Range(1, 4);

        // Initialize Controllers
        ControllerText.Initialize();

        // Intialize Hide Error Window
        ErrorWindow.enabled = false;
        PlayerPrefs.SetInt("RenderCryFace", 0);
        PlayerPrefs.SetInt("RenderSadFace", 0);
        PlayerPrefs.SetInt("RenderWheatLeft", 0);
        PlayerPrefs.SetInt("RenderWheatRight", 0);
        PlayerPrefs.SetInt("RenderErrorIcon", 0);

        // Set All Tiles to Default
        if (PlayerPrefs.GetInt("gameIsLoaded") == 0)
        {

            PlayerPrefs.SetString("dirtTile0", "dirt");
            PlayerPrefs.SetString("dirtTile1", "dirt");
            PlayerPrefs.SetString("dirtTile2", "dirt");
            PlayerPrefs.SetString("dirtTile3", "dirt");
            PlayerPrefs.SetString("dirtTile4", "dirt");
            PlayerPrefs.SetString("dirtTile5", "dirt");
            PlayerPrefs.SetString("dirtTile6", "dirt");
            PlayerPrefs.SetString("dirtTile7", "dirt");
            PlayerPrefs.SetString("dirtTile8", "dirt");
            PlayerPrefs.SetString("dirtTile9", "dirt");
            PlayerPrefs.SetString("dirtTile10", "dirt");
            PlayerPrefs.SetString("dirtTile11", "dirt");
            PlayerPrefs.SetString("dirtTile12", "dirt");
            PlayerPrefs.SetString("dirtTile13", "dirt");
            PlayerPrefs.SetString("dirtTile14", "dirt");
            PlayerPrefs.SetString("dirtTile15", "dirt");
            PlayerPrefs.SetString("dirtTile16", "dirt");
            PlayerPrefs.SetString("dirtTile17", "dirt");
            PlayerPrefs.SetString("dirtTile18", "dirt");
            PlayerPrefs.SetString("dirtTile19", "dirt");
            PlayerPrefs.SetString("dirtTile20", "dirt");
            PlayerPrefs.SetString("dirtTile21", "dirt");
            PlayerPrefs.SetString("dirtTile22", "dirt");
            PlayerPrefs.SetString("dirtTile23", "dirt");
            PlayerPrefs.SetString("dirtTile24", "dirt");
            PlayerPrefs.SetString("dirtTile25", "dirt");

        }

        // Set Default Resource Numbers
        if (PlayerPrefs.GetInt("gameIsLoaded") == 0)
        {
            PlayerPrefs.SetInt("WheatCounter", 15);
            PlayerPrefs.SetInt("FruitCounter", 15);
            Debug.Log("pooop");
        }
        // Close Wheat Timers
        if (PlayerPrefs.GetInt("breakpoint") == 1)
        {
            PlayerPrefs.SetInt("wheatTimer1", 0);
            PlayerPrefs.SetInt("wheatTimer2", 0);
            PlayerPrefs.SetInt("wheatTimer3", 0);
            PlayerPrefs.SetInt("wheatTimer4", 0);
            PlayerPrefs.SetInt("wheatTimer5", 0);
            PlayerPrefs.SetInt("wheatTimer6", 0);
            PlayerPrefs.SetInt("wheatTimer7", 0);
            PlayerPrefs.SetInt("wheatTimer8", 0);
            PlayerPrefs.SetInt("wheatTimer9", 0);
            PlayerPrefs.SetInt("wheatTimer10", 0);
            PlayerPrefs.SetInt("wheatTimer11", 0);
            PlayerPrefs.SetInt("wheatTimer12", 0);
            PlayerPrefs.SetInt("wheatTimer13", 0);
            PlayerPrefs.SetInt("wheatTimer14", 0);
            PlayerPrefs.SetInt("wheatTimer15", 0);
            PlayerPrefs.SetInt("wheatTimer16", 0);
            PlayerPrefs.SetInt("wheatTimer17", 0);
            PlayerPrefs.SetInt("wheatTimer18", 0);
            PlayerPrefs.SetInt("wheatTimer19", 0);
            PlayerPrefs.SetInt("wheatTimer20", 0);
            PlayerPrefs.SetInt("wheatTimer21", 0);
            PlayerPrefs.SetInt("wheatTimer22", 0);
            PlayerPrefs.SetInt("wheatTimer23", 0);
            PlayerPrefs.SetInt("wheatTimer24", 0);
            PlayerPrefs.SetInt("wheatTimer25", 0);
        }
        // Close Fruit Timers
        if (PlayerPrefs.GetInt("breakpoint") == 1)
        {
            PlayerPrefs.SetInt("fruitTimer1", 0);
            PlayerPrefs.SetInt("fruitTimer2", 0);
            PlayerPrefs.SetInt("fruitTimer3", 0);
            PlayerPrefs.SetInt("fruitTimer4", 0);
            PlayerPrefs.SetInt("fruitTimer5", 0);
            PlayerPrefs.SetInt("fruitTimer6", 0);
            PlayerPrefs.SetInt("fruitTimer7", 0);
            PlayerPrefs.SetInt("fruitTimer8", 0);
            PlayerPrefs.SetInt("fruitTimer9", 0);
            PlayerPrefs.SetInt("fruitTimer10", 0);
            PlayerPrefs.SetInt("fruitTimer11", 0);
            PlayerPrefs.SetInt("fruitTimer12", 0);
            PlayerPrefs.SetInt("fruitTimer13", 0);
            PlayerPrefs.SetInt("fruitTimer14", 0);
            PlayerPrefs.SetInt("fruitTimer15", 0);
            PlayerPrefs.SetInt("fruitTimer16", 0);
            PlayerPrefs.SetInt("fruitTimer17", 0);
            PlayerPrefs.SetInt("fruitTimer18", 0);
            PlayerPrefs.SetInt("fruitTimer19", 0);
            PlayerPrefs.SetInt("fruitTimer20", 0);
            PlayerPrefs.SetInt("fruitTimer21", 0);
            PlayerPrefs.SetInt("fruitTimer22", 0);
            PlayerPrefs.SetInt("fruitTimer23", 0);
            PlayerPrefs.SetInt("fruitTimer24", 0);
            PlayerPrefs.SetInt("fruitTimer25", 0);
        }

        PlayerPrefs.SetInt("breakpoint", 1);

        //load all the wheat seeds
        if (PlayerPrefs.GetInt("gameIsLoaded") == 1)
        {
            if (PlayerPrefs.GetString("dirtTile0") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer1", 1);
                DirtTile1.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile1") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer2", 1);
                DirtTile2.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile2") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer3", 1);
                DirtTile3.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile3") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer4", 1);
                DirtTile4.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile4") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer5", 1);
                DirtTile5.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile5") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer6", 1);
                DirtTile6.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile6") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer7", 1);
                DirtTile7.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile7") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer8", 1);
                DirtTile8.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile8") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer9", 1);
                DirtTile9.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile9") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer10", 1);
                DirtTile10.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile10") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer11", 1);
                DirtTile11.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile11") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer12", 1);
                DirtTile12.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile12") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer13", 1);
                DirtTile13.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile13") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer14", 1);
                DirtTile14.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile14") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer15", 1);
                DirtTile15.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile15") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer16", 1);
                DirtTile16.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile16") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer17", 1);
                DirtTile17.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile17") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer18", 1);
                DirtTile18.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile18") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer19", 1);
                DirtTile19.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile19") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer20", 1);
                DirtTile20.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile20") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer21", 1);
                DirtTile21.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile21") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer22", 1);
                DirtTile22.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile22") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer23", 1);
                DirtTile23.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile23") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer24", 1);
                DirtTile24.image.sprite = WheatSeedsTex;
            }
            if (PlayerPrefs.GetString("dirtTile24") == "wheatseeded")
            {
                PlayerPrefs.SetInt("wheatTimer25", 1);
                DirtTile25.image.sprite = WheatSeedsTex;
            }
        }

        //load all the wheat
        if (PlayerPrefs.GetInt("gameIsLoaded") == 1)
        {
            if (PlayerPrefs.GetString("dirtTile0") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer1", 1);
                DirtTile1.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile1") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer2", 1);
                DirtTile2.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile2") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer3", 1);
                DirtTile3.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile3") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer4", 1);
                DirtTile4.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile4") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer5", 1);
                DirtTile5.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile5") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer6", 1);
                DirtTile6.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile6") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer7", 1);
                DirtTile7.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile7") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer8", 1);
                DirtTile8.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile8") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer9", 1);
                DirtTile9.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile9") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer10", 1);
                DirtTile10.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile10") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer11", 1);
                DirtTile11.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile11") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer12", 1);
                DirtTile12.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile12") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer13", 1);
                DirtTile13.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile13") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer14", 1);
                DirtTile14.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile14") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer15", 1);
                DirtTile15.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile15") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer16", 1);
                DirtTile16.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile16") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer17", 1);
                DirtTile17.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile17") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer18", 1);
                DirtTile18.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile18") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer19", 1);
                DirtTile19.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile19") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer20", 1);
                DirtTile20.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile20") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer21", 1);
                DirtTile21.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile21") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer22", 1);
                DirtTile22.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile22") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer23", 1);
                DirtTile23.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile23") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer24", 1);
                DirtTile24.image.sprite = WheatTex;
            }
            if (PlayerPrefs.GetString("dirtTile24") == "wheat")
            {
                PlayerPrefs.SetInt("wheatTimer25", 1);
                DirtTile25.image.sprite = WheatTex;
            }
        }
    }
}
