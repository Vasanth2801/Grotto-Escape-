using TMPro;
using UnityEngine;

public class DiamondManager : MonoBehaviour
{
    public static DiamondManager instance;

    [SerializeField] private int diamondCount = 0;
    [SerializeField] private TextMeshProUGUI diamondText;

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

    void Update()
    {
        diamondText.text = "X " + diamondCount.ToString();
    }

    public void AddDiamond()
    {
        diamondCount++;
    }
}