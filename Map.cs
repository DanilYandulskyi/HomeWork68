using UnityEngine;
using System.Collections.Generic;

public class Map : MonoBehaviour
{
    [SerializeField] private List<Gold> _resources = new List<Gold>();

    public IReadOnlyList<Gold> Resources => _resources;

    public void AddResource(Gold resource)
    {
        _resources.Add(resource);
    }

    public void RemoveGold(Gold gold)
    {
        if (_resources.Contains(gold))
        {
            _resources.Remove(gold);
        }
    }
}
