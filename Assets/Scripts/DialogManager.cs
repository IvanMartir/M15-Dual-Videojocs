using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public GameObject ChatBubble1Object;
    public Text ChatBubble1Text;

    public string Text1ForBubble1 = "Hola mortal, se que has vingut a per mi... Per derrotar-me" +
        " necessitaras mes que una simple espassa.";

    public string Text2ForBubble1 = "Per derrotar-me hauràs d'arribar a la clau per obrir la meva " +
        "sala secreta, t'estaré esperant allí per la lluita!";

    public string Text3ForBubble1 = "Per aconsseguir la clau, necesitaras anar per un seguit de sales resolent " +
        "problemes matemàtics i resolent altres enigmes.";

    public string Text4ForBubble1 = "Molta sort, la necessitaras, ADEU!";

    public Image WhiteImageEffect;
    public GameObject LightStormImage;
    public AudioSource StormSound;

    public GameObject EnemyPlayerObject;

    public GameObject Exclamation;

    public static bool ShowingDialogs;

    bool alreadyWriting = true;

    bool alreadyExclamation = true;

    bool stop = false;

    // Start is called before the first frame update
    void Start()
    {

        ShowingDialogs = true;

        ChatBubble1Object.SetActive(false);

        EnemyPlayerObject.SetActive(false);

        Exclamation.SetActive(false);

        LightStormImage.SetActive(false);

        WhiteImageEffect.rectTransform.localScale = new Vector3(0, 0, 0);

        StartCoroutine(ScreamerStorm());

        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0f);
    }

    private IEnumerator ScreamStormOneTime()
    {
        WhiteImageEffect.rectTransform.localScale = new Vector3(1, 1, 1);
        LightStormImage.SetActive(true);
        StormSound.Play();
        EnemyPlayerObject.SetActive(false);
        ChatBubble1Object.SetActive(false);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 1f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.9f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.8f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.7f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.6f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.5f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.4f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.3f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.2f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.1f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0f);
        yield return new WaitForSeconds(0.05f);
        WhiteImageEffect.rectTransform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.2f);
        LightStormImage.SetActive(false);

        // DECIR CONTROLES
        ShowingDialogs = false;
    }

    private IEnumerator ScreamerStorm()
    {
        while (true && !stop)
        {
            yield return new WaitForSeconds(5);
            WhiteImageEffect.rectTransform.localScale = new Vector3(1, 1, 1);
            LightStormImage.SetActive(true);
            StormSound.Play();
            EnemyPlayerObject.SetActive(true);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 1f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.9f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.8f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.7f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.6f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.5f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.4f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.3f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.2f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0.1f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.color = new Color(255f, 255f, 255f, 0f);
            yield return new WaitForSeconds(0.05f);
            WhiteImageEffect.rectTransform.localScale = new Vector3(0, 0, 0);
            yield return new WaitForSeconds(0.2f);
            LightStormImage.SetActive(false);
            yield return new WaitForSeconds(1);

            if (alreadyExclamation)
            {
                alreadyExclamation = false;
                Exclamation.SetActive(true);
            }

            yield return new WaitForSeconds(2);

            Exclamation.SetActive(false);

            if (alreadyWriting)
            {
                alreadyWriting = false;
                ChatBubble1Object.SetActive(true);
                ChatBubble1Text.text = "";
                StartCoroutine(WriteChatBubble1());
            }

            yield return new WaitForSeconds(10);
        }
    }

    private IEnumerator WriteChatBubble1()
    {
        for(int i = 0; i < Text1ForBubble1.Length; i++)
        {
            ChatBubble1Text.text = ChatBubble1Text.text + Text1ForBubble1[i];
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(5);
        ChatBubble1Text.text = "";

        for (int i = 0; i < Text2ForBubble1.Length; i++)
        {
            ChatBubble1Text.text = ChatBubble1Text.text + Text2ForBubble1[i];
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(5);
        ChatBubble1Text.text = "";

        for (int i = 0; i < Text3ForBubble1.Length; i++)
        {
            ChatBubble1Text.text = ChatBubble1Text.text + Text3ForBubble1[i];
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(5);
        ChatBubble1Text.text = "";

        for (int i = 0; i < Text4ForBubble1.Length; i++)
        {
            ChatBubble1Text.text = ChatBubble1Text.text + Text4ForBubble1[i];
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(4);

        StartCoroutine(ScreamStormOneTime());

        stop = true;

    }

}
