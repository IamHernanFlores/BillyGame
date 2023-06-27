using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetLogic : MonoBehaviour
{

    public PlayerLogic playerLogic;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        playerLogic.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerLogic.puedoSaltar = false;
    }
}
