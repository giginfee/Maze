using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField]
    Transform character;
    public float sensitivity;
    public float smoothing = 1.5f;

    Vector2 velocity;
    Vector2 frameVelocity;
    public GameObject hintWindow;
    float timeLeft = 2.0f;
    void Reset()
    {
        // Get the character from the FirstPersonMovement in parents.
        character = GetComponentInParent<FirstPersonMovement>().transform;
    }

    void Start()
    {
        hintWindow.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            hintWindow.SetActive(false);
        }
       

        if (Input.GetKeyDown(KeyCode.Escape)&& Cursor.lockState== CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && Cursor.lockState != CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = true;
        }
        /*Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (Input.GetKeyDown(KeyCode.Escape)&&!Cursor.visible)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
                    
        if (Input.GetKeyDown(KeyCode.Escape) && Cursor.visible)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }*/
        // Get smooth velocity.
        Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        // Rotate camera up-down and controller left-right from velocity.
        transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
    }
}
