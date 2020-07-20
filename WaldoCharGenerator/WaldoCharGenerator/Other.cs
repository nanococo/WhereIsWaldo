using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace WaldoCharGenerator {
    public class Other : Character {

        private Other() {}

        public static GameObject GetNewOther(Dictionary<string, GameObject> others) {
            while (true) {
                var index = Random.Range(1, 140);
                var name = "Extra" + index;

                GameObject gameObject;
                if (others.ContainsKey(name)) {
                    gameObject = Object.Instantiate(others[name]); //Cloning method
                }
                else {
                    gameObject = Init(name, 1.7f);
                    others.Add(name, gameObject);
                }

                var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
                spriteRenderer.sortingOrder = 0;

                spriteRenderer.sprite = Resources.Load<Sprite>(name);

                if (spriteRenderer.sprite == null) continue;
                return gameObject;
            }
        }
    }
}