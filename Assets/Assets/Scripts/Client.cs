using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Client : MonoBehaviour
{
    public GameObject NPC;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            NPC.GetComponent<NPC>().TakeDamge(1);
        }
    }
}
