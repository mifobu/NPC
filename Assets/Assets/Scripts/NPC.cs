using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public void TakeDamge(int amt)
    {
        GetComponent<IHealth>().TakeDamage(amt);
    }
}