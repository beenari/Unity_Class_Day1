using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public Slider silderUI_Player_Hp_Bar;
    public Slider silderUI_Player_Exp_Bar;
    public TMP_Text tmpTextUI_Player_Hp;
    public TMP_Text tmpTextUI_Player_Exp;
    public TMP_Text tmpTextUI_Player_Level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpTextUI_Player_Hp.text = GameManager.Instance.currentHp.ToString();
        tmpTextUI_Player_Exp.text = GameManager.Instance.currentExp.ToString();
        tmpTextUI_Player_Level.text = "Level" + GameManager.Instance.level.ToString();

        silderUI_Player_Hp_Bar.value = (float)GameManager.Instance.currentHp / (float)GameManager.Instance.maxHp;
        silderUI_Player_Exp_Bar.value = (float)GameManager.Instance.currentExp /
            (float)GameManager.Instance.levelUpExp[GameManager.Instance.level - 1];
    }
}
