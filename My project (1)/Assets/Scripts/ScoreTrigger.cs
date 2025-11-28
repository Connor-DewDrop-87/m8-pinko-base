using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public int points = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreKeeper.AddScore(points);
    }
}
