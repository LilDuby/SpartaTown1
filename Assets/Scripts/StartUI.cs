using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{

    public TMP_InputField inputField;

    public Sprite[] characterImages;

    public Image selectedcharacter;

    public void ChoiceCharacter(int num)
    {
        selectedcharacter.sprite = characterImages[num];
        DataManager.instance.characterNum = num;
    }
    public void OnClickBtn()
    {
        if(inputField.text.Length < 2 ||  inputField.text.Length > 10)
            return;

        DataManager.instance.userName = inputField.text;

        SceneManager.LoadScene(1);
    }
}
