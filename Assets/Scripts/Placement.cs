using UnityEngine;

public class Placement : MonoBehaviour
{
    public bool isXTurn = true;
    public GameObject xSymbol;
    public GameObject oSymbol;
    public Camera mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Placement"))
                {
                    if (isXTurn)
                    {
                        Instantiate(xSymbol, hit.collider.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(oSymbol, hit.collider.transform.position, Quaternion.identity);
                    }
                    isXTurn = !isXTurn;
                }
            }
        }
    }
}
