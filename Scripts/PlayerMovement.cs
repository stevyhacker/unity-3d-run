using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public Rigidbody rb;
    public Joystick joystick;
    public float forwardForceMovement = 1000f;
    public float sidewaysForceMovement = 1000f;
    public float speed;


    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        // Add a forward force
        // rb.AddForce(-forwardForceMovement * Time.deltaTime, 0, 0);

        // If the player is pressing the d or a keys

        if (Input.GetKey("d") || Input.GetKey("right") || joystick.Horizontal > 0.5f)
        {
            // Add a force to the right
            // Debug.Log("Right arrow key was pressed.");
            rb.AddForce(0, 0, sidewaysForceMovement * Time.deltaTime);
        }

        if (Input.GetKey("a") || Input.GetKey("left") || joystick.Horizontal < -0.5f)
        {
            // Add a force to the left
            // Debug.Log("Left arrow key was pressed.");z
            rb.AddForce(0, 0, -sidewaysForceMovement * Time.deltaTime);
        }

        if (Input.GetKey("s") || Input.GetKey("down") ||  joystick.Vertical < -0.5f )
        {
            rb.AddForce(forwardForceMovement * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w") || Input.GetKey("up") || joystick.Vertical > 0.5f)
        {
            rb.AddForce(-forwardForceMovement * Time.deltaTime, 0, 0);
        }

        // Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.left * joystick.Horizontal;
        // rb.AddForce(direction * (speed * Time.fixedDeltaTime));

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
                activity.Call<bool>("moveTaskToBack", true);
            }
            else
            {
                Application.Quit();
            }
        }
    }
}