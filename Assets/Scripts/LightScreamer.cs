using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LightScreamer : MonoBehaviour
{

    public Image WhiteImageEffect;

    public GameObject LightStormImage;

    public AudioSource StormSound;

    // Start is called before the first frame update
    void Start()
    {
        LightStormImage.SetActive(false);

        WhiteImageEffect.rectTransform.localScale = new Vector2(0, 0);

        StartCoroutine(ScreamerStorm());

        WhiteImageEffect.color = new Color(255f, 255f, 255f, 0f);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("PresentationScene");
    }

    private IEnumerator ScreamerStorm()
    {
        while(true)
        {
            yield return new WaitForSeconds(15);
            WhiteImageEffect.rectTransform.localScale = new Vector2(1, 1);
            LightStormImage.SetActive(true);
            StormSound.Play();
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
            WhiteImageEffect.rectTransform.localScale = new Vector2(0, 0);
            yield return new WaitForSeconds(0.2f);
            LightStormImage.SetActive(false);
        }
    }

}
