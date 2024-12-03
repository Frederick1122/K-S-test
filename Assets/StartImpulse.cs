using UnityEngine;

public class StartImpulse : MonoBehaviour
{
    [SerializeField] private float _force;

    private Vector3 _startPos;
    private Rigidbody _rigidbody;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _startPos = transform.position;
        Reset();
    }

    [ContextMenu("Reset")]
    public void Reset()
    {
        _rigidbody.velocity = Vector3.zero;        
        _rigidbody.angularVelocity = Vector3.zero;
        transform.position = _startPos;
        
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);

        Vector3 randomVec = new(x * _force, y * _force);
        _rigidbody.AddForce(randomVec);
    }
}
