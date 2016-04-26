using System;

namespace OpcX
{
    /// <summary>
    /// Abstract class for Node.
    /// </summary>
    public abstract class Node : INode
    {
        /// <summary>
        /// The type.
        /// </summary>
        protected NodeType Type;

        /// <summary>
        /// If node is ready to work this field is set to true.
        /// </summary>
        protected bool Ready;

        #region INode implementation
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <returns>The type.</returns>
        public virtual int GetNodeType()
        {
            return (int)this.Type;
        }

        /// <summary>
        /// Determines whether this instance is ready.
        /// </summary>
        /// <returns><c>true</c> if this instance is ready; otherwise, <c>false</c>.</returns>
        public virtual bool IsReady()
        {
            return Ready;
        }
        #endregion
    }
}

