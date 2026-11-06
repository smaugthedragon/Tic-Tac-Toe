using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class Placement : MonoBehaviour
{
    public bool isXTurn = true;
    public int turnCount = 0;
    public GameObject xSymbol;
    public GameObject oSymbol;
    public GameObject xIndicator;
    public GameObject oIndicator;
    public Camera mainCamera;
    public GameObject turnIndicator;


    public GameObject row_0_0;
    public GameObject row_0_1;
    public GameObject row_0_2;
    public GameObject row_1_0;
    public GameObject row_1_1;
    public GameObject row_1_2;
    public GameObject row_2_0;
    public GameObject row_2_1;
    public GameObject row_2_2;
    public GameObject column_0_0;
    public GameObject column_0_1;
    public GameObject column_0_2;
    public GameObject column_1_0;
    public GameObject column_1_1;
    public GameObject column_1_2;
    public GameObject column_2_0;
    public GameObject column_2_1;
    public GameObject column_2_2;
    public GameObject diag_0_0;
    public GameObject diag_0_1;
    public GameObject diag_0_2;
    public GameObject diag_1_0;
    public GameObject diag_1_1;
    public GameObject diag_1_2;

    public TMP_Text Text;

    private GameObject currentXIndicator;
    private GameObject currentOIndicator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentXIndicator = Instantiate(xIndicator, turnIndicator.transform.position, Quaternion.identity);
        currentOIndicator = Instantiate(oIndicator, turnIndicator.transform.position, Quaternion.identity);
        UpdateIndicator();
        Text.gameObject.SetActive(false);

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
                if (hit.collider.CompareTag("Placement") && !hit.collider.gameObject.GetComponent<Blocks>().isFull)
                {
                    if (isXTurn)
                    {
                        Instantiate(xSymbol, hit.collider.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(oSymbol, hit.collider.transform.position, Quaternion.identity);
                    }

                    if(hit.collider.gameObject.TryGetComponent<Blocks>(out Blocks block))
                    {
                        block.setFull(isXTurn);
                        checkWinCondition();
                    }

                    isXTurn = !isXTurn;
                    UpdateIndicator();
                    turnCount++;
                }
            }
        }

        if(turnCount >= 9)
        { 
            Text.text = "Game Over: It's a draw!";
            Text.gameObject.SetActive(true);
        }
    }

    void UpdateIndicator()
    {
        if (isXTurn)
        {
            currentXIndicator.SetActive(true);
            currentOIndicator.SetActive(false);

        }
        else
        {
            currentXIndicator.SetActive(false);
            currentOIndicator.SetActive(true);
        }
    }

    void checkWinCondition()
    {
        if (row_0_0.GetComponent<Blocks>().isX == isXTurn && row_0_0.GetComponent<Blocks>().isFull)
        {
            if (row_0_1.GetComponent<Blocks>().isX == isXTurn && row_0_1.GetComponent<Blocks>().isFull)
            {
                if(row_0_2.GetComponent<Blocks>().isX == isXTurn && row_0_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
            }
        }
        if (row_1_0.GetComponent<Blocks>().isX == isXTurn && row_1_0.GetComponent<Blocks>().isFull)
        {
            if (row_1_1.GetComponent<Blocks>().isX == isXTurn && row_1_1.GetComponent<Blocks>().isFull)
            {
                if (row_1_2.GetComponent<Blocks>().isX == isXTurn && row_1_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
            }
        }
        if(row_2_0.GetComponent<Blocks>().isX == isXTurn && row_2_0.GetComponent<Blocks>().isFull)
        {
            if (row_2_1.GetComponent<Blocks>().isX == isXTurn && row_2_1.GetComponent<Blocks>().isFull)
            {
                if (row_2_2.GetComponent<Blocks>().isX == isXTurn && row_2_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
            }
        }

        if (column_0_0.GetComponent<Blocks>().isX == isXTurn && column_0_0.GetComponent<Blocks>().isFull)
        {
            if (column_0_1.GetComponent<Blocks>().isX == isXTurn && column_0_1.GetComponent<Blocks>().isFull)
            {
                if(column_0_2.GetComponent<Blocks>().isX == isXTurn && column_0_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
                
            }
        }
        if(column_1_0.GetComponent<Blocks>().isX == isXTurn && column_1_0.GetComponent<Blocks>().isFull)
        {
            if (column_1_1.GetComponent<Blocks>().isX == isXTurn && column_1_1.GetComponent<Blocks>().isFull)
            {
                if (column_1_2.GetComponent<Blocks>().isX == isXTurn && column_1_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
        
            }
        }
        if(column_2_0.GetComponent<Blocks>().isX == isXTurn && column_2_0.GetComponent<Blocks>().isFull)
        {
            if (column_2_1.GetComponent<Blocks>().isX == isXTurn && column_2_1.GetComponent<Blocks>().isFull)
            {
                if (column_2_2.GetComponent<Blocks>().isX == isXTurn && column_2_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
                
            }
        }

        if (diag_0_0.GetComponent<Blocks>().isX == isXTurn && diag_0_0.GetComponent<Blocks>().isFull)
        {
            if (diag_0_1.GetComponent<Blocks>().isX == isXTurn && diag_0_1.GetComponent<Blocks>().isFull)
            {
                if(diag_0_2.GetComponent<Blocks>().isX == isXTurn && diag_0_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
            }
        }

        if (diag_1_0.GetComponent<Blocks>().isX == isXTurn && diag_1_0.GetComponent<Blocks>().isFull)
        {
            if (diag_1_1.GetComponent<Blocks>().isX == isXTurn && diag_1_1.GetComponent<Blocks>().isFull)
            {
                if(diag_1_2.GetComponent<Blocks>().isX == isXTurn && diag_1_2.GetComponent<Blocks>().isFull)
                {
                    Text.text = "Player " + (isXTurn ? "X" : "O") + " wins!";
                    Text.gameObject.SetActive(true);
                }
            }
        }

    }
}

