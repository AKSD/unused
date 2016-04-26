using EasyModbus;
using System;

namespace OpcX
{
    /// <summary>
    /// Node of type: PLC controller.
    /// </summary>
    public class NodePLC : Node
    {
        /// <summary>
        /// Gets the type of the connection.
        /// </summary>
        /// <value>The type of the connection.</value>
        public PLCConnectionType ConnType{ get; private set; }

        /// <summary>
        /// Gets the baud rate.
        /// </summary>
        /// <value>The baud rate.</value>
        public BaudRate BaudRate{ get; private set; }

        /// <summary>
        /// Gets the ip address.
        /// </summary>
        /// <value>The ip address.</value>
        public string IpAddress { get; private set; }

        /// <summary>
        /// Gets the base OpcConnection.
        /// </summary>
        /// <value>The base OpcConnection.</value>
        public OpcConnection BaseConnection { get; private set; }

        /// <summary>
        /// Gets the port.
        /// </summary>
        /// <value>The port.</value>
        public int Port{ get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpcX.NodePLC"/> class.
        /// </summary>
        public NodePLC()
        {
            Port = 502;
            BaudRate = BaudRate.b_9600;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpcX.NodePLC"/> class.
        /// </summary>
        /// <param name="ipAddress">Ip address.</param>
        /// <param name="baseConnection">Base connection.</param>
        public NodePLC(string ipAddress, OpcConnection baseConnection)
            : this()
        {
            this.IpAddress = ipAddress;
            this.BaseConnection = baseConnection;
            this.Ready = true;
        }
    }
}

