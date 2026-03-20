using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            DiamondManager.instance.AddDiamond();
            gameObject.SetActive(false);
        }
    }
}