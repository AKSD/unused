using System;
using System.Collections.Generic;
using System.Linq;

namespace OpcX
{
    /// <summary>
    /// Opc connection.
    /// </summary>
    public class OpcConnection
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive { get; private set; }

        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <value>The nodes.</value>
        public List<INode> Nodes { get; private set; }

        /// <summary>
        /// The type of connection of nodes.
        /// </summary>
        private Direction ConnectionDirection;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpcX.OpcConnection"/> class.
        /// </summary>
        /// <param name="direction">Direction.</param>
        public OpcConnection(Direction direction)
        {
            this.ConnectionDirection = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpcX.OpcConnection"/> class.
        /// </summary>
        /// <param name="nodes">Nodes.</param>
        /// <param name="direction">Direction.</param>
        public OpcConnection(List<INode> nodes, Direction direction)
            : this(direction)
        {
            this.Nodes = nodes;
        }

        /// <summary>
        /// Checks the connection.
        /// </summary>
        /// <returns><c>true</c>, if connection was checked, <c>false</c> otherwise.</returns>
        public bool CheckConnection()
        {
            return false;
        }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <returns><c>true</c>, if node was added, <c>false</c> otherwise.</returns>
        /// <param name="node">Node.</param>
        /// <param name="type">Type.</param>
        public bool AddNode(INode node, NodeType type)
        {
            bool added = false;

            if (Nodes.Count < Constants.MAX_NODE_COUNT)
            {
                if (Nodes.Any())
                {
                    if ((NodeType)node.GetNodeType() == NodeType.Master)
                    {
                        if (!Nodes.AsQueryable().Any(n => (NodeType)n.GetNodeType() == NodeType.Master))
                        {
                            added = true;
                        }
                    }
                    else
                    {
                        added = true;
                    }
                }
                else
                {
                    added = true;
                }
            }

            if (added)
            {
                Nodes.Add(node);
            }

            return added;
        }
    }
}