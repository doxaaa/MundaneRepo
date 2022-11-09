using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextController : MonoBehaviour
{
    // Start is called before the first frame update
    private int itemsPacked;
    public TMP_Text textForTextItem;
    void Start()
    {
        itemsPacked = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CountItemsPackaged()
    {
        itemsPacked = itemsPacked + 1;
        textForTextItem.text = itemsPacked + " has been packed!";
    }

    void OnEnable()
    {
        EventManagerMain.PackageEvent += CountItemsPackaged;
    }
    void OnDisable()
    {
        EventManagerMain.PackageEvent -= CountItemsPackaged;
    }
}
