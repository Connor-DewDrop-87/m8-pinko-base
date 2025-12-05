using UnityEngine;




public class Player : MonoBehaviour
{
    public float speed = 1;
    public float direction = 2;
    public float screenEdge = 10;
    public int discsAvailable = 10;
    public GameObject disc;
    public CameraFollow cameraFollow;
    private GameObject activeDisc;
    // Update is called once per frame
    void Update()
    {
        DropDisc();
        Move();
    }
    void Move()
    {
        if (activeDisc == null && discsAvailable>0)
        {
            float movementX = direction * Time.deltaTime * speed;
            Vector3 offSet = new Vector3(movementX, 0, 0);
            transform.position += offSet;
            // Once the edge is hit, reverse the movement of the player
            if (transform.position.x >= screenEdge || transform.position.x <= screenEdge * -1)
            {
                direction *= -1;
            }
        }
    }
    void DropDisc()
    {
        if (Input.GetButtonDown("Fire1") && activeDisc == null && discsAvailable>0)
        {
                Vector3 position = transform.position-new Vector3(0,2,0);
                Quaternion rotation = transform.rotation;
                activeDisc = Instantiate(disc, position, rotation);
                cameraFollow.FollowDisc(activeDisc);
                discsAvailable--;
        }
    }
    public int getDiscs()
    {
        return discsAvailable;
    }
}
