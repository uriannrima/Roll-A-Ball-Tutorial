using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    /// <summary>
    /// Rotate it each frame.
    /// </summary>
    void Update()
    {
        /// Use Time.DeltaTime to make it smooth.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
