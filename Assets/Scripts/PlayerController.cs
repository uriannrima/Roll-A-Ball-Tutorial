using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Rigidbody.
    /// </summary>
    public Rigidbody Rigidbody;

    /// <summary>
    /// Thrust power.
    /// </summary>
    public float Thrust;

    /// <summary>
    /// Count Text reference.
    /// </summary>
    public Text CountText;

    /// <summary>
    /// Win Text reference.
    /// </summary>
    public Text WinText;

    /// <summary>
    /// Counter value.
    /// </summary>
    private int Count;

    // Always runs, even when disabled.
    void Awake()
    {

    }

    /// <summary>
    /// Runs only when enabled.
    /// </summary>
    void Start()
    {
        // Get Rigidbody
        Rigidbody = GetComponent<Rigidbody>();

        // Start out our count.
        Count = 0;

        // Set out text count.
        SetCountText();

        // Set out win text empty.
        WinText.text = "";
    }

    //Vector3 movement = new Vector3();

    /// <summary>
    /// Used for physical interactions.
    /// </summary>
    void FixedUpdate()
    {
        //movement.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //rb.AddForce(movement * Thrust);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Rigidbody.AddForce(new Vector3(horizontal, 0, vertical) * Thrust);
    }

    /// <summary>
    /// When player touch a trigger collider.
    /// </summary>
    /// <param name="other">The other collider.</param>
    void OnTriggerEnter(Collider other)
    {
        // Destroy everything associated with the other gameObject.
        // Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // Deactivate the other game object.
            other.gameObject.SetActive(false);

            // Count it.
            Count++;

            // Set out count text.
            SetCountText();
        }
    }

    void SetCountText()
    {
        CountText.text = "Count: " + Count.ToString();

        // Win logic.
        if (Count >= 12)
        {
            WinText.text = "You win. GG";
        }
    }
}
