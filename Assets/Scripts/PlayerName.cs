using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{

    TMP_Text nameText;
    void Start()
    {
        nameText = GetComponent<TMP_Text>();

        nameText.text = DataManager.instance.userName;
    }

}
