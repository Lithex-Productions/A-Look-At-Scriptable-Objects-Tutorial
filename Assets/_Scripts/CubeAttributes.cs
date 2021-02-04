using UnityEngine;

namespace LP.ScriptableObjectsTutorial
{
    [CreateAssetMenu(fileName = "CubeAttributes", menuName = "Cube Attributes")]
    public class CubeAttributes : ScriptableObject
    {
        public string cubeName = string.Empty;
        public float size = 0;
        public Color color = new Color(0, 0, 0);
    }
}

