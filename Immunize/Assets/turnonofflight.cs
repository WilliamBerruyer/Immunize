using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnonofflight : MonoBehaviour
{
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LightControl()
    {
        myLight.gameObject.SetActive(false);
    }

    public void LightControlOn()
    {
        myLight.gameObject.SetActive(true);
    }
}
