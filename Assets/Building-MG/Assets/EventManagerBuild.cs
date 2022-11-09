using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerBuild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public delegate void ObjectPlacement();
    public static event ObjectPlacement BuildObject;
    public static void RunCorrectPart()
    {
        BuildObject?.Invoke();
    }
}
