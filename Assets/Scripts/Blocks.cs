using TMPro;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    
    public bool isX = true;
    public bool isFull = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    public void setFull(bool isXTurn)
    {
        if (isXTurn)
        {
            isX = true;
        }
        else
        {
            isX = false;
        }
        isFull = true;

    }    
}
