using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void MovePlayer()
    {
        this.transform.position += new Vector3(2f, 0f, 0f);
    }
    
    private void OnEnable()
    {
        MurderEventManager.OnMovePlayer += MovePlayer;
    }

    private void OnDisable()
    {
        MurderEventManager.OnMovePlayer -= MovePlayer;
    }
}
