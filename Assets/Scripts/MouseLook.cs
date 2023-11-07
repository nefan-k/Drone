using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivityHor = 3.0f;
    public float sensitivityVert = 3.0f;
    
    private float _rotationX;
    private float _rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
        _rotationY += Input.GetAxis("Mouse X") * sensitivityHor;
        transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
    }

    private void OnDestroy()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
