using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New NPC", menuName = "Scriptable Unity")]
public class ScriptableNPC : ScriptableObject
{
    public NPC npc;
    public BasedNPC NPC;
}
public enum NPC
{
    GREYNPC = 0,
    REDNPC = 1
}
