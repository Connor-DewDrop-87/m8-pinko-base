using UnityEngine;

public class DiscIncreaser : MonoBehaviour
{
    public DiscUI DiscCounter;
    public Player LimitedDiscs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collider)
    {
        DiscCounter.AddOrSubtractDisc(1);
        LimitedDiscs.AddDisc(1);
    }
}
