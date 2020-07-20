using UnityEngine;

class MainChar : MonoBehaviour {

    public WaldoController waldoController;
    private bool _isBlocked;
    
    private void OnMouseDown() {
        if(_isBlocked) return;
        waldoController._charCount--;
        gameObject.SetActive(false);
        _isBlocked = true;
    }
}