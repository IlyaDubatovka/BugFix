using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _wallPrefab;
    
    private void Start()
    {
       Rigidbody cube= Instantiate(_wallPrefab);
       cube.isKinematic = false;
    }
}
