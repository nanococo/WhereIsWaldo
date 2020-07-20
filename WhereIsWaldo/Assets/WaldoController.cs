using System;
using UnityEngine;
using UnityEngine.UI;
using WaldoCharGenerator;
using Random = UnityEngine.Random;

public class WaldoController : MonoBehaviour {


    public int _charCount = 5; 
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject background;
    
    // Start is called before the first frame update
    void Start() {
        SetBackground();
        GenerateCharacters();
    }

    private void SetBackground() {
        var index = Random.Range(0, 3);
        background.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Bkg"+index);
    }

    private void GenerateCharacters() {
        var extras = 350;
        while (extras > 0) {
            var x = Random.Range(-33, 50);
            var y = Random.Range(-30, 12);

            WaldoCharFactory.GetCharacter(WaldoCharacter.Other, x, y);
            extras--;
        }

        MainChar mainChar;

        var wenda = WaldoCharFactory.GetCharacter(WaldoCharacter.Wenda, Random.Range(-33, 50), Random.Range(-30, 12));
        mainChar = wenda.AddComponent<MainChar>();
        mainChar.waldoController = this;
        

        var woof = WaldoCharFactory.GetCharacter(WaldoCharacter.Woof, Random.Range(-33, 50), Random.Range(-30, 12));
        mainChar = woof.AddComponent<MainChar>();
        mainChar.waldoController = this;
        
        var whiteBeard = WaldoCharFactory.GetCharacter(WaldoCharacter.WhiteBeard, Random.Range(-33, 50), Random.Range(-30, 12));
        mainChar = whiteBeard.AddComponent<MainChar>();
        mainChar.waldoController = this;
        
        var oddLaw = WaldoCharFactory.GetCharacter(WaldoCharacter.OddLaw, Random.Range(-33, 50), Random.Range(-30, 12));
        mainChar = oddLaw.AddComponent<MainChar>();
        mainChar.waldoController = this;
        
        var waldo = WaldoCharFactory.GetCharacter(WaldoCharacter.Waldo, Random.Range(-33, 50), Random.Range(-30, 12));
        mainChar = waldo.AddComponent<MainChar>();
        mainChar.waldoController = this;

        winText.SetActive(false);
    }

    private void Update() {
        if (_charCount<=0) {
            winText.SetActive(true);    
        }
    }
}
