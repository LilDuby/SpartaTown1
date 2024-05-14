using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public GameObject[] characters;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        characters[DataManager.instance.characterNum].SetActive(true);
    }
}
