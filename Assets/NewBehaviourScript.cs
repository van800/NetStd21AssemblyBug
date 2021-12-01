using System.Diagnostics.CodeAnalysis;
using UnityEngine;

[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(new ClassLibrary1.Class1());
    }
}