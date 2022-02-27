using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    private ToDestroy[] objectsToDestroy;
    private IEnumerator newDestroyCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        objectsToDestroy = FindObjectOfType<ToDestroy>();
    }
    public void DestroyThem()
    {
        newDestroyCoroutine = DestroyCoroutine();
        StartCoroutine(newDestroyCoroutine);
    }
    private IEnumerator DestroyCoroutine()
    {
        foreach (ToDestroy npc in objectsToDestroy)
        {
            if (npc != null)
            {
                Destroy(npc.gameObject);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
    public void OnMouseEnter()
    {
    }
}
