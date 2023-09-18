using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using static CardInfoAsset;

public class ARLayout : MonoBehaviour
{
    public TMP_Text TitleText;

    public TMP_Text DescriptionText;

    public TMP_Text DecorationText;

    public TMP_Text NoteText;

    public TMP_Text ReferenceText;

    public GameObject IconContent;

    public UnityEngine.UI.Image CardImage;

    public CardInfoAsset CardInfoAsset;

    public UnityEngine.UI.Image BackgroundImageColor;

    private bool IconDescPrepared = false;

    /*[System.Serializable]
    public class BackgroundSprite
    {
        public string Name;
        public Sprite Sprite;
    }

    public List<BackgroundSprite> BackgroundSpriteMap = new List<BackgroundSprite>();*/

    // Start is called before the first frame update
    void Start(){}

    public void setupComponent()
    {

        TitleText.text = CardInfoAsset.Title;
        CardImage.sprite = CardInfoAsset.CardImage;
        NoteText.text = CardInfoAsset.SpecialNotes;
        DescriptionText.text = CardInfoAsset.Description;
        DecorationText.text = "A kártya " + CardInfoAsset.ReleaseYear + "-ban/ben jelent meg.\nAz Illusztrációt " + CardInfoAsset.Illustrator + " készítette.\n" + CardInfoAsset.DecorationText;
    }

    public void ActivateIconContent()
    {

        if (!IconDescPrepared)
        {
            string desc = "";
            //desc += "\n";
            desc += "Az adatok a http://kodex.hkk.hu/ weboldalról származnak (2023). A tartalommal kapcsolatos minden észrevétel és köszönet a fenntartókat illeti!\n\n";
            CreateText("Alarm", IconContent.transform, 0, -10, "<b>FIGYELEM!</b>", 24, Color.red, 54);
            CreateText("Alarm", IconContent.transform, 0, -60, desc, 18, Color.black, 54);

            int counter = 0;
            int heightCounter = -100;
            int textHeight = 0;
            foreach (IconMap item in CardInfoAsset.IconList)
            {
                desc = "";
                desc += RuleBook.GetExplanation(item.Icon) + "\n\n";

                textHeight = 54 * desc.Count(x => x == '\n');
                heightCounter -= textHeight > 300 ? textHeight : 300;


                CreateText("Icon",IconContent.transform, 0, heightCounter, desc, 18, Color.black, textHeight > 300 ? textHeight : 300);
                counter++;
            }

            CreateText("Finished", IconContent.transform, 0, heightCounter - textHeight, "---------------- Vége ----------------", 18, Color.black, 54);
            IconDescPrepared = true;
        }
    }

    private void CreateText(string title, Transform canvas_transform, float x, float y, string text_to_print, int font_size, Color text_color, int textHeight)
    {

        GameObject UItextGO = new GameObject(title);
        UItextGO.transform.SetParent(canvas_transform);

        RectTransform trans = UItextGO.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(x, y);
        //RectTransform rt = ReferenceText.GetComponent<RectTransform>();

        //trans.sizeDelta = new Vector2(ReferenceText.preferredWidth, 36 * desc.Count(x => x == '\n'));
        trans.sizeDelta = new Vector2(950, textHeight);
        TMP_Text text = UItextGO.AddComponent<TextMeshProUGUI>();
        text.text = text_to_print;
        text.fontSize = font_size;
        text.color = text_color;
        text.font = ReferenceText.font;
        text.enableWordWrapping = true;
        text.alignment = TextAlignmentOptions.Midline;
        UItextGO.SetActive(true);
        text.enabled = true;
    }

    public void openURL()
    {
        Application.OpenURL("https://beholder.hu/?m=hkk&in=hkk.php&kartya=" + CardInfoAsset.cardID); //7062
    }

    public void UpdateBackgroundColor()
    {
        if (CardInfoAsset.GroupTypeList.Count() == 1)
        {
            if (CardInfoAsset.GroupTypeList.Contains(Group.KOVETO_SZABALYLAP))
            {
                BackgroundImageColor.color = new Color32(247, 150, 19, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.BUFA) || CardInfoAsset.GroupTypeList.Contains(Group.BARD))
            {
                BackgroundImageColor.color = new Color32(117, 118, 142, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.CHARADIN) || CardInfoAsset.GroupTypeList.Contains(Group.MUTANS))
            {
                BackgroundImageColor.color = new Color32(143, 109, 174, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.DORNODON) || CardInfoAsset.GroupTypeList.Contains(Group.TOLVAJ))
            {
                BackgroundImageColor.color = new Color32(225, 131, 42, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.ELENIOS) || CardInfoAsset.GroupTypeList.Contains(Group.PSZIONICISTA))
            {
                BackgroundImageColor.color = new Color32(85, 166, 219, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.FAIRLIGHT) || CardInfoAsset.GroupTypeList.Contains(Group.MAGUS))
            {
                BackgroundImageColor.color = new Color32(232, 221, 59, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.LEAH) || CardInfoAsset.GroupTypeList.Contains(Group.HALHATATLAN))
            {
                BackgroundImageColor.color = new Color32(25, 30, 34, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.RAIA) || CardInfoAsset.GroupTypeList.Contains(Group.KATONA))
            {
                BackgroundImageColor.color = new Color32(182, 190, 201, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.SHERAN) || CardInfoAsset.GroupTypeList.Contains(Group.TUDOS))
            {
                //BackgroundImageColor.color = new Color32(41, 50, 29, 100);
                BackgroundImageColor.color = new Color32(25, 53, 17, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.THARR) || CardInfoAsset.GroupTypeList.Contains(Group.TISZTOGATO))
            {
                BackgroundImageColor.color = new Color32(129, 110, 87, 150);
            }
            else if (CardInfoAsset.GroupTypeList.Contains(Group.RHATT))
            {
                BackgroundImageColor.color = new Color32(176, 216, 83, 150);
                //BackgroundImageColor.CrossFadeAlpha(0.5f,2,true);
            }
        }
    }
}