using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
    private Text _ammoText;

    void Awake()
    {
        _ammoText = GetComponent<Text>();
    }

    
    void Update()
    {
        _ammoText.text = "Ammo: " + AmmoKeeper.ammo;
    }
}
