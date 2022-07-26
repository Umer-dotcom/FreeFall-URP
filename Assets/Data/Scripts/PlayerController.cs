using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public string draggingTag;
    [SerializeField] private Camera cam;
    [SerializeField] private float speed;

    private Vector3 dis;
    private float posX;
    private float posY;

    private bool touched = false;
    private bool dragging = false;

    private Transform toDrag;
    private Rigidbody toDragRigidbody;
    private Vector3 previousPosition;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        if (cam != null)
        {
            if (Input.touchCount != 1)  // Check if more than one touch is detected
            {
                dragging = false;   // No object is to be dragged
                touched = false;    // No touch is to be followed

                return;
            }

            Touch touch = Input.touches[0]; // Store the first touch
            Vector3 pos = touch.position;   // Touch position (By default it's position is according to the pixels)

            if (touch.phase == TouchPhase.Began)    // Check if player just put it's finger on the screen
            {
                RaycastHit hit;
                Ray ray = cam.ScreenPointToRay(pos);

                if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag(draggingTag))
                {
                    toDrag = hit.transform; // Storing the transform of object that's need to be controlled
                    previousPosition = toDrag.position;
                    toDragRigidbody = toDrag.GetComponent<Rigidbody>();
                    toDragRigidbody.isKinematic = false;    // Turning off kinematic, to apply physics forces on the object 

                    dis = cam.WorldToScreenPoint(previousPosition); // Converting object to be dragged position to screen pixels location
                    posX = Input.GetTouch(0).position.x - dis.x;
                    posY = Input.GetTouch(0).position.y - dis.y;

                    touched = true;
                }
            }

            if (touched && touch.phase == TouchPhase.Moved) // Check if player finger is moving on the screen and first touch is registered
            {
                Debug.Log("Finger is moving!");
                dragging = true;

                float posXNow = Input.GetTouch(0).position.x - posX;
                float posYNow = Input.GetTouch(0).position.y - posY;
                Vector3 curPos = new Vector3(posXNow, posYNow, dis.z);

                Vector3 worldPos = cam.ScreenToWorldPoint(curPos) - previousPosition;   // Converting finger position to unity world position
                worldPos = new Vector3(worldPos.x, worldPos.y, 0.0f);

                toDragRigidbody.velocity = worldPos / (Time.deltaTime * speed);

                previousPosition = toDrag.position;
            }

            if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
            {
                dragging = false;
                touched = false;
                previousPosition = new Vector3(0.0f, 0.0f, 0.0f);
                toDragRigidbody.isKinematic = true;
            }
        }
    }

    public void DisableController()
    {
        this.enabled = false;
    }

    public void EnableController()
    {
        this.enabled = true;
    }
}
