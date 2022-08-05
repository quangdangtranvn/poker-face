using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using QTBlue.CardGame;
public class CSVToCard : MonoBehaviour
{
    [SerializeField] private TextAsset textAsset;
    const string csvPath = "/CSV/Cards.csv";


    public void ReadCSV()
    {
        string[] data = textAsset.text.Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
        foreach (var s in data.Skip(1))
        {

            print(s);
        }
    }
    [MenuItem("Ultility/Genarate New Cards")]
    public static void TakeFile()
    {
        var dataPath = Application.dataPath + csvPath;
        Debug.Log("" + Application.dataPath + csvPath);
        string[] allLines = File.ReadAllLines(dataPath);

        foreach (string s in allLines.Skip(1))
        {
            string[] data = s.Split(',');
            Card item = ScriptableObject.CreateInstance<Card>();
            item.name = data[0];
            item.suit = data[1];
            item.rankValue = float.Parse(data[2]);
            AssetDatabase.CreateAsset(item, $"Assets/Scripts/UI/Card/Data/{item.name}-{item.suit}.asset");
        }
        AssetDatabase.SaveAssets();

    }
}
