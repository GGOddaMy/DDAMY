using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Monster : MonoBehaviour
{
    public string monName;

    public float monMaxHp;

    public float monCurHp;

    public float Atk;

    public Image hpImage;

    public Monster target;

    public float coolTime;





    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = monName;
        monCurHp = monMaxHp;
    }

    float cTime;
    // Update is called once per frame
    void Update()
    {
        if(monCurHp > 0)
            if(cTime >= coolTime)
            {
                target.OnDamge(Atk);
                cTime = 0;
            }
        else {
                cTime += Time.deltaTime;
              
}
