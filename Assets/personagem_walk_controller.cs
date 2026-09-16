using UnityEngine;

public class personagem_walk_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocity = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_input = Input.GetAxis("Horizontal");
        float vertical_input = Input.GetAxis("Vertical");
    
        Vector3 movement_direction = new Vector3(horizontal_input, 0f , vertical_input);

        transform.Translate(movement_direction * velocity * Time.deltaTime, Space.World);
    }
}
