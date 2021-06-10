using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveChange : MonoBehaviour
{
    public GameObject[] Wave;
    private int WaveCount;
    private int Count;
    public int MaxCount;
    // Start is called before the first frame update
    void Start()
    {
        WaveCount = 0;
        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Count >= MaxCount)
        {
            Wave[WaveCount].SetActive(false);
            WaveCount++;
            if (WaveCount >= Wave.Length)
            {
                WaveCount = 0;
            }
            Wave[WaveCount].SetActive(true);
            Count = 0;
        }
        else
        {
            Count++;
        }
    }
}
