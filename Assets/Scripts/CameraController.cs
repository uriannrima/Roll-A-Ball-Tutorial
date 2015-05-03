using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    /// <summary>
    /// Player reference.
    /// </summary>
    public GameObject Player;

    /// <summary>
    /// Calculated Offset.
    /// </summary>
    private Vector3 Offset;

    /// <summary>
    ///  Calculate the offset.
    /// </summary>
    void Start()
    {
        Offset = this.transform.position - Player.transform.position;
    }

    /// <summary>
    /// Move camera with the player.
    /// </summary>
    void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}
