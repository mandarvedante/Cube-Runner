using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public float force = 500f;
    public float speed = 5f;
    public float maxX;
    public float minX;
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 0, 10f*Time.deltaTime);
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(5f * Time.deltaTime, 0, 0);
        }
        
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, 500f * Time.deltaTime);
    }
}
