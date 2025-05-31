using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition=player.transform.position;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed*Time.deltaTime);
        DestroyWhenReached(); 
    }
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
 