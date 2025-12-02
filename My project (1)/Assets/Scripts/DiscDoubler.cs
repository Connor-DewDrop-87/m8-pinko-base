using Unity.VisualScripting;
using UnityEngine;


public class DiscDoubler : MonoBehaviour
{
    public GameObject disc;
    public GameObject discDoubler;
    private GameObject activeDisc;
    private float[] randomX = { -15.8f ,- 14.8f ,- 13.8f ,- 12.8f ,- 11.8f, - 10.8f ,- 9.8f ,- 8.8f ,- 7.8f ,- 6.8f, -5.8f, -4.8f, -3.8f, -2.8f, -1.8f, 0.2f, 1.2f, 2.2f, 3.2f, 4.2f, 5.2f, 6.2f, 7.2f, 8.2f, 9.2f, 10.2f, 11.2f, 12.2f,13.2f,14.2f,15.2f,16.2f};
    private float[] randomY = { 9.22f,5.22f,2.22f,1.22f,-1.78f};
    private void Start()
    {
        Vector3 randomPosition = new Vector3(randomX[Random.Range(0, randomX.Length)], randomY[Random.Range(0, randomY.Length)], 0);
        transform.position = randomPosition;
    }
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Vector3 position = transform.position+new Vector3(2,0,0);
        Quaternion rotation = transform.rotation;
        activeDisc = Instantiate(disc, position, rotation);
        Vector3 randomPosition = new Vector3(randomX[Random.Range(0,randomX.Length)], randomY[Random.Range(0, randomY.Length)], 0);
        transform.position = randomPosition;
        discDoubler.SetActive(false);
        
    }
}
