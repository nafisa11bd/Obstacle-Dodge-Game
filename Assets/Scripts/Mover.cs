using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]private float speed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
       
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float yValue = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.Translate(xValue, 0, yValue);

    }

    
}
