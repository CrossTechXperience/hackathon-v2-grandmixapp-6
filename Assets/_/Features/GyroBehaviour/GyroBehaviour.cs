using UnityEngine;

public class GyroBehaviour : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        Quaternion gyro = Input.gyro.attitude;

        Quaternion converted = new Quaternion(
            -gyro.x,
            -gyro.y,
            gyro.z,
            gyro.w
        );

        Quaternion reference = Quaternion.Euler(90f, 0f, 0f);

        transform.localRotation = reference * converted;
    }
}