using UnityEngine;

namespace WaldoCharGenerator {
    class Wenda : Character { 
        private static GameObject _gameObject;

        public static GameObject GetInstance() {
            if (_gameObject != null) return _gameObject;
            _gameObject = Init("Wenda", 0.5f);
            return _gameObject;
        }
    }
}
