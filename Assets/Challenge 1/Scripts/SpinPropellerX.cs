using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 500f;
    void Start()
    {
        
    }

    void Update()
    {
        // Putar propeller terus-menerus di sumbu Z lokal (sumbu maju baling-baling)
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}