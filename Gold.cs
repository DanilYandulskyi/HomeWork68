using UnityEngine;
using System.Collections.Generic;

public class Gold : MonoBehaviour
{
    public void StartFollow(Transform transform)
    {
        this.transform.SetParent(transform);
    }

    public void StopFollow()
    {
        transform.SetParent(null);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }
}