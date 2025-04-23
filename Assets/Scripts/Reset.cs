using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject pepis;
    public GameObject spamBots;
    public Transform spawn;
    private Rigidbody2D rb;
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
        transform.position = spawn.position;
        rb.linearVelocity = Vector3.zero;
        transform.rotation = Quaternion.identity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpamBots"))
        {

        }
    }
}
