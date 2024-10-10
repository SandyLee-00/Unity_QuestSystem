using UnityEngine;

[CreateAssetMenu(menuName = "Quest/SubTask/Action/NegativeCount", fileName = "NegativeCount")]
public class NegativeCount : SubTaskAction
{
    public override int Run(SubTask subTask, int currentSuccess, int successCount)
    {
        return successCount < 0 ? currentSuccess + successCount : currentSuccess;
    }
}

