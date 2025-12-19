using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController Controller;
    public Transform Camera;

    public int speed = 5;
    public float mouseSensitivity = 50f;
    public float xRotation = 0f;
    public float upClamp = -90f;
    public float downClamp = 30f;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, upClamp, downClamp);
        Camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate(Vector3.up * mouseX);

        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        Controller.Move(move * Time.deltaTime * speed); 
    }
}
