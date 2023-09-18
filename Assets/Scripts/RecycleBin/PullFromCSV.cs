using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PullFromCSV : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public int NumberOfColumnsInCSV;
    public TextAsset textAssetData;
    public CardInfoAsset[] cardInfoAssets;

    // Start is called before the first frame update
    void Start()
    {
        //ReadCSV();
        //var sprite = Resources.Load<Sprite>("dataFiles/Images/" + placeHolder);
        // Instantiate at position (0, 0, 0) and zero rotation.
        //Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    private void ReadCSV()
    {
        string[] data = textAssetData.text.Split(new string[] { ",", "\n"}, StringSplitOptions.None);
        int tableSize = data.Length / NumberOfColumnsInCSV - 1;
        cardInfoAssets = new CardInfoAsset[tableSize];

        for (int i = 0; i < tableSize; i++)
        {

            string title = data[NumberOfColumnsInCSV * (i + 1)];
            string spriteName = data[NumberOfColumnsInCSV * (i + 1) + 1];

            var sprite = Resources.Load<Sprite>("Sprites/" + spriteName);

            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/" + spriteName);
            Debug.Log("SIZE: " + sprites.Length);
            foreach (Sprite item in sprites)
            {
                Debug.Log("ITT: " + item.name);
            }

        }
    }
}
