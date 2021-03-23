using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterButton : MonoBehaviour
{
    public GameObject button_space;
    GameObject target;
    bool buttonON = false;
    private void Awake() 
    {
        target = GameObject.Find("MainCharacter");    
        Debug.Log(target);    
    }
    private void Update()
    {
        if(!buttonON) // 버튼 안떠있으면
        {
            if(Input.GetMouseButtonDown(0))
            {
                GiveButton(target);
            }
        }
    }
    void GiveButton(GameObject target)
    {
        ShieldmanController shieldmanController = target.GetComponent<ShieldmanController>();
        shieldmanController.GenerateButton(button_space);
    }
    
}