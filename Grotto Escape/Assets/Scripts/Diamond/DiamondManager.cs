using UnityEngine;

public class DiamondManager : MonoBehaviour
{
    public static DiamondManager instance;

    [SerializeField] private int diamondCount = 0;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddDiamond()
    {
        diamondCount++;
    }
}