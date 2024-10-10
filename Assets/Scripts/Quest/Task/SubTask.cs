using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest/SubTask/SubTask", fileName = "SubTask_")]
public class SubTask : ScriptableObject
{
    [Header("Text")]
    [SerializeField]
    private string codeName;

    [SerializeField]
    private string description;

    [Header("Action")]
    [SerializeField]
    private SubTaskAction action;

    [Header("Setting")]
    [SerializeField]
    private InitialSuccessValue initalSuccessValue;

    [SerializeField]
    private int needSuccessToComplete;

    public int CurrentSuccess { get; private set; }
    public int NeedSuccessToComplete => needSuccessToComplete;
    public string CodeName => codeName;
    public string Description => description;

    public void ReceiveReport(int successCount)
    {
        CurrentSuccess = action.Run(this, CurrentSuccess, successCount);
    }



}

