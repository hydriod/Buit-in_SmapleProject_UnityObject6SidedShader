using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Vector3 mousePastPosi;

    public Vector2 MouseSpeed
    {
        get
        {
            Vector3 dv = Input.mousePosition - mousePastPosi;
            return new Vector2(dv.x / Screen.width, dv.y / Screen.height);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // rotate with mouse
        if (Input.GetMouseButton(0))
        {
            Vector3 rotateAngle = new Vector3(MouseSpeed.y * 90, MouseSpeed.x * -180, 0);
            Debug.Log(new Vector3(MouseSpeed.y, MouseSpeed.x, 0) * 180);
            Vector3 rotation = Camera.main.transform.rotation.eulerAngles + rotateAngle;
            transform.rotation = Quaternion.Euler(rotation);
        }
        mousePastPosi = Input.mousePosition;

        // move with key
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

        //quit
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            return;
        }
    }
}
