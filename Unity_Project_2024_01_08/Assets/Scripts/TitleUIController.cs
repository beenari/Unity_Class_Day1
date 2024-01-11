using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUIController : MonoBehaviour
{
    public Button btnStart;
    public Button btnOption;
    public Button btnEnd;

    // Start is called before the first frame update
    void Start()
    {
        btnStart.onClick.AddListener(OnClickBtnStart);
        //btnStart.onClick.AddListener(delegate { OnClickBtnStart});
        btnOption.onClick.AddListener(OnClickBtnOption);
        btnEnd.onClick.AddListener(OnClickBtnEnd);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClickBtnStart()
    {
        AudioManager.instance.PlaySFX("Button_Down");
        SceneManager.LoadScene("PlayScene");
    }

    void OnClickBtnOption()
    {
        AudioManager.instance.PlaySFX("Button_Down");
        AudioManager.instance.PanelOnOff(true);
    }

    void OnClickBtnEnd()
    {
        AudioManager.instance.PlaySFX("Button_Down");
        Application.Quit();
    }
}
