using UnityEngine;
using System.Collections;

public class CameraTargetController : MonoBehaviour
{
    /// <summary>
    /// Target of the Camera.
    /// </summary>
    public GameObject Target;

    void LateUpdate()
    {
        this.transform.position = Target.transform.position;
    }
}
