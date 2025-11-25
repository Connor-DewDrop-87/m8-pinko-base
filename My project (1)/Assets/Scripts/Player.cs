using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject disc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DropDisc();
        Move();
    }
    void Move()
    {
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offSet = new Vector3(movementX, 0, 0);
        transform.position += offSet;
    }
    void DropDisc()
    {
        if (Input.GetButtonDown("Fire1"))
        {
                Vector3 position = transform.position;
                Quaternion rotation = transform.rotation;
                Instantiate(disc, position, rotation);
            
        }
    }
}
