using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class TextUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void UpdateText(List<Gold> resources)
    {
        int goldAmount = resources.Count;

        _text.text = $"Gold - {goldAmount}";
    }
}
