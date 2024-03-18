using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Transform button;
    [SerializeField] Transform panel;
    [SerializeField] Transform board;
    [SerializeField] Transform levels;
    [SerializeField] int buttonsPerRow;
    [SerializeField] int panelsPerC;
    bool DoneMakingButtons;
    int buttonsMade_LF;
    int buttonsMade_T;
    Transform newPanel = null;
    void Start()
    {
        buttonsMade_LF = 0;
        buttonsMade_T = 0;     
        DoneMakingButtons = false;
       
    }

    void Update()
    {

        if (DoneMakingButtons) 
        {
            return;
        }

        if (buttonsMade_LF == 0) 
        {
            newPanel = Instantiate(panel,board);
        }

        if (buttonsMade_T == buttonsPerRow) 
        {
            buttonsMade_T = 0;
            newPanel = Instantiate(panel,board);
        }

        Transform newButton = Instantiate(button,newPanel);    
        buttonsMade_LF++;
        buttonsMade_T++;
        newButton.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = buttonsMade_LF.ToString();
        if (buttonsMade_LF == panelsPerC * buttonsPerRow)
        {
            DoneMakingButtons = true;    
             button.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
        }
    }
}
