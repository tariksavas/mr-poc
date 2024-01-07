using UnityEngine;

namespace Runtime
{
    public class BallSpawner : MonoBehaviour
    {
        [SerializeField] 
        private GameObject _ballPrefab;

        [SerializeField] 
        private float _spawnSpeed = 5f;

        private void Update()
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                SpawnBall();
            }
        }

        private void SpawnBall()
        {
            GameObject spawnedBall = Instantiate(_ballPrefab, transform.position, Quaternion.identity);
            
            Rigidbody spawnedBallRb = spawnedBall.GetComponent<Rigidbody>();
            spawnedBallRb.velocity = transform.forward * _spawnSpeed;
        }
    }
}
