using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject pepis;
    public GameObject spamBots;
    public Transform spawn;
    private Rigidbody2D rb;
    bool Drop = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Respawn()
    {
        Drop = false;
        transform.position = spawn.position;
        rb.linearVelocity = Vector3.zero;
        transform.rotation = Quaternion.identity;
        targetObject.GetComponent<Move_Pepis>().enabled = true;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpamBots"))
        {
            Respawn();
        }
    }
}
