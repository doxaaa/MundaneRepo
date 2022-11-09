using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        EventManagerBuild.BuildObject += MatchingParts;
    }

    private void OnDisable()
    {
        EventManagerBuild.BuildObject -= MatchingParts;
    }

    public void MatchingParts()
    {
        print("these parts match!");
    }
}
