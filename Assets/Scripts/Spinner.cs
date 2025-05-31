using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
