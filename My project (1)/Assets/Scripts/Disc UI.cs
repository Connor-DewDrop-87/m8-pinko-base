using TMPro;
using UnityEngine;

public class DiscUI : MonoBehaviour
{
    public TMP_Text DiscCount;
    public GameObject DiscCounter;
    private int discsAvailable = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateDiscNumber();
    }

    public void AddOrSubtractDisc(int DiscAdd)
    {
        discsAvailable += DiscAdd;
        UpdateDiscNumber();
    }

    // Update is called once per frame
    public void UpdateDiscNumber()
    {
        DiscCount.text = $"DISCS: {discsAvailable}";
    }
}
