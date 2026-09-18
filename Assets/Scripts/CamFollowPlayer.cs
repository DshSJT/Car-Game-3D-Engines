using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);

    void Start()
    {
        
    }

    void LateUpdate() // dari Update() > LateUpdate() agar kamera "kind of jittery"
    { 
        // offset the camera behind the player by adding to the player's position | Sesuaikan dengan custom position camera di Unity Editor
        transform.position = player.transform.position + offset;
    }
}
