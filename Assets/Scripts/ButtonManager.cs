using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    public GameObject ImageBehindEntrar;
    public GameObject ImageBehindRegistrar;

    // Start is called before the first frame update
    void Start()
    {
        ImageBehindEntrar.SetActive(true);
        ImageBehindRegistrar.SetActive(false);
    }

    public void OnClickEntrar()
    {
        Debug.Log("Button Entrar Clicked!");
        ImageBehindEntrar.SetActive(true);
        ImageBehindRegistrar.SetActive(false);
    }

    public void OnClickRegistrar()
    {
        Debug.Log("Button Registrar Clicked!");
        ImageBehindEntrar.SetActive(false);
        ImageBehindRegistrar.SetActive(true);
    }

}
