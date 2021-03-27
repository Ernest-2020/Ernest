using UnityEngine;

namespace Game
{
    public sealed class InputController : IExecute
    {
        private readonly PlayerBase PlBase;
        private readonly SaveDataRepository _saveDataRepository;
        private readonly KeyCode _savePlayer = KeyCode.C;
        private readonly KeyCode _loadPlayer = KeyCode.V;

        public InputController(PlayerBase player)
        {
            PlBase = player;

            _saveDataRepository = new SaveDataRepository();
        }

        public void Execute()
        {
            PlBase.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKeyDown(_savePlayer))
            {
                _saveDataRepository.Save(PlBase);
                Debug.Log("Game Save");
            }
            if (Input.GetKeyDown(_loadPlayer))
            {
                _saveDataRepository.Load(PlBase);
            }
        }
    }
}