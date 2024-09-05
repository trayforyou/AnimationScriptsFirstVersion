using UnityEngine;

public class ChangerSize : MonoBehaviour
{
    [SerializeField] private float _speed;
   
    private void Update()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
