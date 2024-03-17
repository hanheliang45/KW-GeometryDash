using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Transform button;
    [SerializeField] Transform panel;
    [SerializeField] Transform board;
    [SerializeField] int buttonsPerRow;
    [SerializeField] int panelsPerC;
    int buttonsMade_LF;
    int buttonsMade_T;
    bool DoneMakingButtons;
    void Start()
    {
        buttonsMade_LF = 0;
        buttonsMade_T = 0;     
        DoneMakingButtons = false;
       
    }

    void Update()
    {
        Transform newPanel = panel;
        if (DoneMakingButtons) 
        {
            return;
        }
        if (buttonsMade_T == buttonsPerRow) 
        {
            buttonsMade_T = 0;
            newPanel = Instantiate(panel,board);
        }
        Instantiate(button,newPanel);    
        buttonsMade_LF++;
        buttonsMade_T++;
        button.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = buttonsMade_LF.ToString();
        if (buttonsMade_LF == panelsPerC * buttonsPerRow)
        {
            DoneMakingButtons = true;
            button.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
        }
    }
}
