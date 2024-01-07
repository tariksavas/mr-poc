using System.Collections;
using UnityEngine;

namespace Runtime
{
    public class WallHandler : MonoBehaviour
    {
        [SerializeField] 
        private OVRSceneManager _ovrSceneManager;

        private Wall[] _walls;

        private void Awake()
        {
            _ovrSceneManager.SceneModelLoadedSuccessfully += OnSceneModelLoadedSuccessfully;
        }

        private void OnSceneModelLoadedSuccessfully()
        {
            StartCoroutine(HandleWalls());
        }

        private IEnumerator HandleWalls()
        {
            yield return new WaitForEndOfFrame();
        
            _walls = FindObjectsOfType<Wall>();
        }

        private void Update()
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                ChangeWallMaterialClicked();
            }
        }

        private void ChangeWallMaterialClicked()
        {
            for (int index = 0; index < _walls.Length; index++)
            {
                _walls[index].ChangeMaterial();
            }
        }

        private void OnDestroy()
        {
            _ovrSceneManager.SceneModelLoadedSuccessfully -= OnSceneModelLoadedSuccessfully;
        }
    }
}
