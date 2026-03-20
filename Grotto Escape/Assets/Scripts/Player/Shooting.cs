using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Shooting Settings")]
    [SerializeField] private float bulletSpeed = 20f;

    [Header("References")]
    [SerializeField] private ObjectPooler pooler;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Animator animator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        animator.SetTrigger("Shoot");
        GameObject fireBall = pooler.SpawnFromPools("FireBall",firePoint.position,firePoint.rotation);
        Rigidbody2D rb = fireBall.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }
}