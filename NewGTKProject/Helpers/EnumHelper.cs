using System;

namespace OpcX
{
    /// <summary>
    /// Direction of connection.
    /// </summary>
    public enum Direction
    {
        Simplex = 1,
        Duplex = 2
    }

    /// <summary>
    /// Node type.
    /// </summary>
    public enum NodeType
    {
        Master = 11,
        Slave = 12
    }

    /// <summary>
    /// PLC connection type.
    /// </summary>
    public enum PLCConnectionType
    {
        ModbusTCP = 21
        //ModbusRTU = 22
    }

    /// <summary>
    /// Baud rates.
    /// </summary>
    public enum BaudRate
    {
        b_9600 = 9600,
        b_19200 = 19200,
        b_38400 = 38400,
        b_57600 = 57600,
        b_115200 = 115200,
        b_230400 = 230400
    }

    /// <summary>
    /// Database type.
    /// </summary>
    public enum DBType
    {
        MySQL = 51,
    }
}

