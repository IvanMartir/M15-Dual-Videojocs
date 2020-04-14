using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialKeys : MonoBehaviour
{

    bool EnabledObjects = false;

    public GameObject A_Key;
    public GameObject D_Key;
    public GameObject SPACE_Key;
    public GameObject ScaleBar;
    public GameObject Wall;

    public Image ScaleImage;

    bool doingA = false;
    bool doingD = false;
    bool doingSPACE = false;

    // Start is called before the first frame update
    void Start()
    {
        EnabledObjects = false;
        D_Key.SetActive(false);
        A_Key.SetActive(false);
        SPACE_Key.SetActive(false);
        ScaleBar.SetActive(false);
        Wall.SetActive(false);
        ScaleImage.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {

        // Check if Dialogs already ended
        if(DialogManager.ShowingDialogs == false)
        {

            if(EnabledObjects == false)
            {
                EnabledObjects = true;
                ScaleBar.SetActive(true);
                Wall.SetActive(true);
                ScaleImage.transform.localScale = new Vector3(0.02f, 1, 1);
                doingD = true;
            }

        }

        if (doingD == true)
        {
            D_Key.SetActive(true);

            if (ScaleImage.transform.localScale.x > 0.90f)
            {
                doingD = false;
                doingA = true;
                A_Key.SetActive(true);
                D_Key.SetActive(false);
                ScaleImage.transform.localScale = new Vector3(0.02f, 1, 1);
            }
       
            if(Input.GetKey(KeyCode.D))
            {
                ScaleImage.transform.localScale = new Vector3(ScaleImage.transform.localScale.x + 0.01f, 1, 1);
            }
        }

        if (doingA == true)
        {
            A_Key.SetActive(true);

            if (ScaleImage.transform.localScale.x > 0.90f)
            {
                doingA = false;
                doingSPACE = true;
                A_Key.SetActive(false);
                SPACE_Key.SetActive(true);
                ScaleImage.transform.localScale = new Vector3(0.02f, 1, 1);
            }

            if (Input.GetKey(KeyCode.A))
            {
                ScaleImage.transform.localScale = new Vector3(ScaleImage.transform.localScale.x + 0.01f, 1, 1);
            }
        }

        if(doingSPACE == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                doingSPACE = false;
                SPACE_Key.SetActive(false);
                ScaleImage.transform.localScale = new Vector3(0, 0, 0);
                ScaleBar.SetActive(false);
                Wall.SetActive(false);
            }
        }

    }
}
