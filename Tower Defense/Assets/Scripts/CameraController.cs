using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float camSpeed = 30f;
    private float zoomSpeed = 5f;
    private float minY = 10f;
    private float maxY = 80f;

    private bool camMoveable = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
            camMoveable = !camMoveable;
        if (!camMoveable)
            return;

        if(Input.GetKey("w") || Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * camSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.Translate(Vector3.back * camSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * camSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * camSpeed * Time.deltaTime, Space.World);
        }

        float zoom = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= zoom * 1000 * zoomSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
