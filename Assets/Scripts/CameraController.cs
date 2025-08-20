using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Camera cam;

    [SerializeField]
    private float xInput;
    [SerializeField]
    private float yInput;
    [SerializeField]
    private int moveSpeed = 20;
    public static CameraController instance;

    private void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        MoveByKB();
    }

    private void MoveByKB()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3 (xInput, yInput, 0);
        transform.position = dir * moveSpeed * Time.deltaTime;
    }
}
