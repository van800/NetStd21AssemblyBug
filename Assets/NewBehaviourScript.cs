using System.Diagnostics.CodeAnalysis;
using UnityEngine;

[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(new ClassLibrary1.Class1());
        Debug.Log(new ClassLibrary2.Class2());
    }
}