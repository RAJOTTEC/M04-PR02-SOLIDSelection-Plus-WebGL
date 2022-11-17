using UnityEngine;

public class MarkerSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] private GameObject markerPrefab;
    [SerializeField] private Vector3 offset;

    private GameObject _marker;

    public void OnSelect(Transform selection)
    {
        _marker = Instantiate(markerPrefab, selection);
        _marker.transform.localPosition += offset;
    }

    public void OnDeselect(Transform selection)
    {
        if (_marker != null)
        {
            Destroy(_marker);
        }
    }
}