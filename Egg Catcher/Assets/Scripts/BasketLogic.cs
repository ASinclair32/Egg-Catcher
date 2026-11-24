using UnityEngine;

public class BasketLogic : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = 0f;

        if(Input.GetKey(KeyCode.A))
        {
            moveInput = -1f;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            moveInput = 1f;
        }

        

        Vector2 newVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        
        
        Debug.Log("" + newVelocity);


        rb.linearVelocity = newVelocity;
    }
}
