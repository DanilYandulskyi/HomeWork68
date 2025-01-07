using UnityEngine;
using System.Collections.Generic;

public class Base : MonoBehaviour
{
    [SerializeField] private List<Unit> _units = new List<Unit>();
    [SerializeField] private List<Gold> _collectedGold = new List<Gold>();

    [SerializeField] private TextUI _ui;
    [SerializeField] private Map _map;

    private void Start()
    {
        _ui.UpdateText(_collectedGold);

        foreach (Unit unit in _units)
        {
            unit.CollectedResource += CollectResource;
        }
    }
    
    private void Update()
    {
        if (_map.Resources.Count > 0)
        {
            for (int i = 0; i < _units.Count; i++)
            {
                if (_units[i].IsStanding)
                {
                    _units[i].StartMovingToResource(_map.Resources[0]);
                    _map.RemoveGold(_map.Resources[0]);
                    break;
                }
            }
        }
    }

    public void CollectResource(Gold resource)
    {
        _collectedGold.Add(resource);
        _ui.UpdateText(_collectedGold);
    }

    private void OnDisable()
    {
        foreach (Unit unit in _units)
        {
            unit.CollectedResource -= CollectResource;
        }
    }
}
