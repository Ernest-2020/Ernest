using UnityEngine;

namespace Game
{
    public sealed class MiniMap : MonoBehaviour
    {
        private Transform _player;
        private void Start()
        {
            _player = Camera.main.transform;
            transform.parent = null;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position = _player.position + new Vector3(0f, 5.0f, 10f);

            var rt = Resources.Load<RenderTexture>("MiniMap/MiniMapTexture");

            GetComponent<Camera>().targetTexture = rt;
        }

        private void LateUpdate()
        {
            var newPosition = _player.position + new Vector3(0f, 10.0f, 10f);
            newPosition.y = transform.position.y;
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(90, _player.eulerAngles.y, 10f);
        }
    }

}