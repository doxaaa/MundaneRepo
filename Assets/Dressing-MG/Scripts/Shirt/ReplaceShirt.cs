using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceShirt : MonoBehaviour
{
    private bool moveShirt = false;

    public void Shirt()
    {
        moveShirt = true;
    }

    private void OnEnable()
    {
        EventManager.ShirtOnTouched += Shirt;
    }

    private void OnDisable()
    {
        EventManager.ShirtOnTouched -= Shirt;
    }

    void FixedUpdate()
    {
         if(this.transform.position.z != 0 && moveShirt == true)
        {
            this.transform.position += new Vector3(0f, 0f, -15.75f);
        }
    }
}
