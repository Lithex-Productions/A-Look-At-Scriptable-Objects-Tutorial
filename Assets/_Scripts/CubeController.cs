using UnityEngine;

namespace LP.ScriptableObjectsTutorial
{
    public class CubeController : MonoBehaviour
    {
        [SerializeField] private CubeAttributes Attributes = null;
        [SerializeField] private Material mat = null;

        private void Start()
        {
            gameObject.name = Attributes.cubeName;
            transform.localScale = new Vector3(Attributes.size, Attributes.size, Attributes.size);
            mat.color = Attributes.color;
        }
    }
}

