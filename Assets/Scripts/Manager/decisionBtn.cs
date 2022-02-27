using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decisionBtn : MonoBehaviour
{
    [SerializeField]
    GameObject objectToDestroy;

    public void DestroyGameObject()
    {
        Destroy(objectToDestroy);
    }
}
