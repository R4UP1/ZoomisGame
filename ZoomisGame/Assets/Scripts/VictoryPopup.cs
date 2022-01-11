using System;
using UnityEngine;

public class VictoryPopup : MonoBehaviour
{
    [SerializeField] public GameObject canvas;
    public static VictoryPopup Instance;

    private void Awake()
    {
        Instance = this;
    }
}
