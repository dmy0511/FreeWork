using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;

    void Start()
    {
        
    }

    void Update()
    {
        inputVec.x = Input.GetAxis("Horizontal");
        inputVec.y = Input.GetAxis("Vertical");
    }
}
