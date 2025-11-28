using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;
    void FixedUpdate()
    {
        Vector3 positionTarget;
        if (disc == null)
        {
            positionTarget = player.transform.position;
        }
        else 
        {
            positionTarget = disc.transform.position;
        }
        positionTarget.x = 0;
        positionTarget.z = camera.transform.position.z;
        // Assign camera position part way from current to target position
        camera.transform.position = Vector3.Lerp(camera.transform.position, positionTarget, lerpRate);
    }
    public void FollowDisc(GameObject disc)
    {
        this.disc = disc;
    }
}
