using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager GameManager;

    public float forwardForce = -10000f;

    public void OnTriggerEnter()
    {
        GameManager.CompleteLevel1();
    }
}
