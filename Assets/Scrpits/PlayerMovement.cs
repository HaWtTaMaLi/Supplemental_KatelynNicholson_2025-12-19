using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController Controller;
    public int speed = 5;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Controller.Move(move * Time.deltaTime * speed);
    }
}
