using UnityEngine;

public class FireBall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}