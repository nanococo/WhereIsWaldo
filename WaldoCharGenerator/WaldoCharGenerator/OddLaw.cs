using UnityEngine;

namespace WaldoCharGenerator {
    public class OddLaw {
        private static GameObject _gameObject;

        public static GameObject GetInstance() {
            if (_gameObject != null) return _gameObject;
            
            _gameObject = new GameObject("OddLaw");
            var spriteRenderer = _gameObject.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("OddLaw");
            var collider2D = _gameObject.AddComponent<BoxCollider2D>();
            var bounds = spriteRenderer.bounds;
            collider2D.size = bounds.size;
            _gameObject.transform.localScale = new Vector3(1.4f, 1.4f, 1f);
            spriteRenderer.sortingOrder = 1;
            return _gameObject;
        }
    }
}