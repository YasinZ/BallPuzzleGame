using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[CreateAssetMenu]
public class PlayerColorSettings : MonoBehaviour
{
    public Dropdown dropdown;
    public GameState gameState;

    public void Start()
    {
        string[] enumNames = Enum.GetNames(typeof(DropdownColors));
        dropdown.AddOptions(new List<string>(enumNames));
    }

    public void ChangePlayerColor()
    {
        var selectedItem = (DropdownColors)dropdown.value;

        switch (selectedItem)
        {
            case DropdownColors.RED:
                gameState.playerColor = Color.red;
                break;
            case DropdownColors.GREEN:
                gameState.playerColor = Color.green;
                break;
            case DropdownColors.BLUE:
                gameState.playerColor = Color.blue;
                break;
        }
    }

    enum DropdownColors
    {
        DEFAULT,
        RED,
        GREEN,
        BLUE
    }
}
