using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockRotate : MonoBehaviour
{
    #region Параметры вращения

    [Header("Минимальная скорость вращения бревна")] 
    [SerializeField] private float minRotateSpeed = 10f;

    [Header("Максимальная скорость вращения бревна")] 
    [SerializeField] private float maxRotateSpeed = 300f;
    
    [Header("Минимальный интервал между остановками")] 
    [SerializeField] private float minStoppedInterval = 3f;
    
    [Header("Максимальный интервал между остановками")] 
    [SerializeField] private float maxStoppedInterval = 10f;

    [Header("Минимальное время без движения")] 
    [SerializeField] private float minIdleTime = 1f;
    
    [Header("Максимальное время без движения")] 
    [SerializeField] private float maxIdleTime = 3f;
    
    [Header("Минимальное время для остановки")] 
    [SerializeField] private float minTimeToStop = 1f;
    
    [Header("Максимальное время для остановки")] 
    [SerializeField] private float maxTimeToStop = 3f;
    
    [Header("Минимальное время без движения")] 
    [SerializeField] private float minTimeToStart = 1f;
    
    [Header("Максимальное время без движения")] 
    [SerializeField] private float maxTimeToStart = 3f;

    #endregion
    
    
}
