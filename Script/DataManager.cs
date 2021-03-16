using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataManager : Singleton<DataManager>
{
    public GameObject rb;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void Start()
    {
        //spriteRenderer = rb.gameObject.GetComponent<SpriteRenderer>();
    }
    public void GoldSkin()
    {
        //spriteRenderer.sprite = newSprite;
        PlayerPrefs.SetFloat("skin", 1);
        PlayerPrefs.Save();
    }
}
