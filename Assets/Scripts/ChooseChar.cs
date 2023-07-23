using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseChar : MonoBehaviour
{
    public Character character;
    SpriteRenderer sr;
    public ChooseChar[] chars;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if (DataMgr.instance.currentCharacter == character) OnSelect();
        else OnDeSelect();
    }

    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        DataMgr.instance.currentCharacter = character;
        OnSelect();
        for(int i = 0; i<chars.Length; i++)
        {
            if (chars[i] != this) chars[i].OnDeSelect();
        }
    }

    void OnDeSelect()
    {
        sr.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnSelect()
    {
        sr.color = new Color(1f, 1f, 1f);
    }
}
