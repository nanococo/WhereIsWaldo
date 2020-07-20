using UnityEngine;

namespace WaldoCharGenerator {
    public class WhiteBeard : Character {
        private static GameObject _gameObject;

        public static GameObject GetInstance() {
            if (_gameObject != null) return _gameObject;
            _gameObject = Init("WhiteBeard", 1.3f);
            return _gameObject;
        }
    }
}