using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] private Transform m_CameraPoint;
    private Camera m_cam => this.gameObject.GetComponent<Camera>();
    
    private CameraControls m_controls;
    private Vector2 m_lookInput;
    void Awake() {
        m_controls = new CameraControls();

        m_controls.CameraMap.Look.performed += context => m_lookInput = context.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        m_cam.transform.LookAt(m_CameraPoint);
    }

    void OnEnable() {
        m_controls.Enable();
    }

    void OnDisable() {
        m_controls.Disable();
    }

    void OnDestroy() {
        m_controls.Dispose();
    }
}
