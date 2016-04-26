using System;

namespace OpcX
{
    /// <summary>
    /// Interface for nodes.
    /// </summary>
    public interface INode
    {
        int GetNodeType();
        bool IsReady();
    }
}

