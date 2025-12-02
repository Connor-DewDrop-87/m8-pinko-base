using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public GameObject discDoubler;
    public int points = 1;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        scoreKeeper.AddScore(points);
        Destroy(collider.gameObject);
        discDoubler.SetActive(true);
    }
}
