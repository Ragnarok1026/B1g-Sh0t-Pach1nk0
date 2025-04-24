using UnityEngine;
using TMPro;
using System.Data.SqlTypes;
public class KR0M3RKounter : MonoBehaviour
{
    public static KR0M3RKounter instance;
    public int kromer = 0;
    public TextMeshProUGUI KromerText;

    void Start()
    {
        UpdateUI();
        instance = this;
    }
    public void AddKromer(int amount)
    {
        kromer += amount;
        UpdateUI();
    }
    void UpdateUI()
    {
        KromerText.text = "KR0M3R: " + kromer;
    }


}

