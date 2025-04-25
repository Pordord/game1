using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI StaminaValue;
    public GameObject PAGE_1;
    public GameObject PAGE_2;
    public GameObject DEAD_SCENE;
    public int Stamina;

    public UIManager(int stamina)
    {
        Stamina = stamina;
    }

    // Start is called before the first frame update
    void Start()
    {
        PAGE_1.SetActive(true);
        PAGE_2.SetActive(false);
        DEAD_SCENE.SetActive(false);

        Stamina = 100;
        
    }

    private void Update()
    {
        StaminaValue.text = Stamina.ToString();
        if (Stamina <= 0)
        { 
            DEAD_SCENE.SetActive(true);
        }
    }

    public void Igor()
    {
        Stamina = Stamina - 50;
        PAGE_1.SetActive(false);
        PAGE_2.SetActive(true);
        DEAD_SCENE.SetActive(false);

    }

    public void Chromakopia()
    {
        Stamina = Stamina - 50;
        PAGE_1.SetActive(true);
        PAGE_2.SetActive(false);
        DEAD_SCENE.SetActive(false);

    }

    public void Restart()
    {
        DEAD_SCENE.SetActive(false);
        PAGE_1.SetActive(true);
        Stamina = Stamina + 100;
    }
}
