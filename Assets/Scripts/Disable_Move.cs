using UnityEngine;

public class Disable_Move : MonoBehaviour
{
    public GameObject targetObject;
    private Rigidbody2D rb;
    bool Drop = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Drop"))
        {
            Drop = true;
            targetObject.GetComponent<Move_Pepis>().enabled = false;
            rb.constraints = RigidbodyConstraints2D.None;

        }
    }
}
