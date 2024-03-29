using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Player_1, Player_2, Player_3, Player_4
}
public class DataMgr : MonoBehaviour
{
    public static DataMgr instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}
