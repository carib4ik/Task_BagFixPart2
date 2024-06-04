using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        _shelfPrefab.GetComponent<BoxCollider>().enabled = false;

        Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
    }
}
