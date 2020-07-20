using UnityEngine;

namespace WaldoCharGenerator {
    public class Character {
        protected static GameObject Init(string name, float sizeVariation) {
            var gameObject = new GameObject(name);
            var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>(name);
            
            if (!name.Contains("Extra")) {
                var collider2D = gameObject.AddComponent<BoxCollider2D>();
                var bounds = spriteRenderer.bounds;
                collider2D.size = bounds.size;    
            }
            spriteRenderer.sortingOrder = 1;
            gameObject.transform.localScale = new Vector3(sizeVariation, sizeVariation, 1f);
            return gameObject;
        }
    }
}