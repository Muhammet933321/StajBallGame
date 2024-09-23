using UnityEngine;
public class CameraSC : MonoBehaviour
{
    [SerializeField] Transform fallowTransform;
    [SerializeField] Vector3 offSet;
    void Update()
    {
        Vector3 newPos = fallowTransform.position + offSet;
        transform.position = newPos;
    }
}

