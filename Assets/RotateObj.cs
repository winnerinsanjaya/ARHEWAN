using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{

    [SerializeField] float rotSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;

    Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotation = transform.rotation;
    }

    public void DefRot()
    {
        transform.rotation = rotation;
    }

    private void OnMouseDrag()
    {
        dragging = true;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }

    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * rotSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }
}
