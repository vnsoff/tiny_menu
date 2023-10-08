using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    public int piecesType;

    void OnMouseDown()
    {
        GameManager.Instance.SelectCandy(this);
    }

}