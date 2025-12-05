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
        //discsAvailable = DiscCounter.getDiscs;
    }

    // Update is called once per frame
    void Update()
    {
        DiscCount.text = $"DISCS: {discsAvailable}";
    }
}
