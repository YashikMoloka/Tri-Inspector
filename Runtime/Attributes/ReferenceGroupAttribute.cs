using System;
using System.Diagnostics;

namespace TriInspector
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    [Conditional("UNITY_EDITOR")]
    public class ReferenceGroupAttribute : Attribute
    {
        public string Group;
        public ReferenceGroupAttribute(string group)
        {
            Group = group;
        }
    }
}