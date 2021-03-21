using UnityEditor;

namespace Game
{
    public class MenuItems
    {
        [MenuItem("Game/Создать объекты ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Game");
        }
    }
}