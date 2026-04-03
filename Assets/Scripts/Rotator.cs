using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 rotationAngle = new Vector3(15,30,45);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAngle * Time.deltaTime);
    }
}
