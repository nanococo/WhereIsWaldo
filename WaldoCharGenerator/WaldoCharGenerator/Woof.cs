using UnityEngine;

namespace WaldoCharGenerator {
    class Woof : Character {
        private static GameObject _gameObject;

        public static GameObject GetInstance() {
            if (_gameObject != null) return _gameObject;
            _gameObject = Init("Woof", 1.0f);
            return _gameObject;
        }
    }
}
