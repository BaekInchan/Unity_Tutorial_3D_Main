using System;
using UnityEngine;

public class StudyEventHandler2 : MonoBehaviour
{
    public class DataClass : EventArgs
    {
        public string dataName;

        public DataClass(string dataName)
        {
            this.dataName = dataName;
        }
    }
    private event EventHandler<DataClass> handler;

    private void Start()
    {
        handler += MethodB;

        DataClass dataClass = new DataClass("H");
        handler?.Invoke(this, dataClass);
    }

    private void MethodB(object o , DataClass e)
    {
        DataClass data = (DataClass)e;

        Debug.Log(e.dataName);
    }
}
