using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaldoCharGenerator
{
    public class WaldoCharFactory {
        public static Dictionary<string, GameObject> Others = new Dictionary<string, GameObject>();
        
        public static GameObject GetCharacter(WaldoCharacter waldoCharacter, float x, float y) {
            GameObject gameObject;
            switch (waldoCharacter) {
                case WaldoCharacter.Waldo:
                    gameObject = Waldo.GetInstance();
                    break;
                case WaldoCharacter.Wenda:
                    gameObject = Wenda.GetInstance();
                    break;
                case WaldoCharacter.Woof:
                    gameObject = Woof.GetInstance();
                    break;
                case WaldoCharacter.OddLaw:
                    gameObject = OddLaw.GetInstance();
                    break;
                case WaldoCharacter.WhiteBeard:
                    gameObject = WhiteBeard.GetInstance();
                    break;
                case WaldoCharacter.Other:
                    gameObject = Other.GetNewOther(Others);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(waldoCharacter), waldoCharacter, null);
            }
            
            gameObject.transform.position = new Vector3(x, y, 0);

            return gameObject;
        }
    }
}
