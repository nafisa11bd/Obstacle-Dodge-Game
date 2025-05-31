using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bump = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            bump++;
            Debug.Log("You hit the object " + bump);
            
        }
    }
}
