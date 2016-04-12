using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Data;

/// <summary>
/// Main window.
/// </summary>
public partial class MainWindow: Gtk.Window
{	
	private string ConnectString;
    private IDbConnection DbCon;
    private bool IsConnected = false;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainWindow"/> class.
	/// </summary>
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
        statusbar1.TooltipText = "";
	}

	/// <summary>
	/// Raises the delete event event.
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="a">The alpha component.</param>
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	/// <summary>
    /// Connects to database.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="e">E.</param>
	protected void ConnectToDatabase (object sender, EventArgs e)
	{
        ConnectString = string.Format(@"Server={0};Database={1};User ID={2};Password={3};",
                                      txtServerName.Buffer.Text,
                                      txtTableName.Buffer.Text,
                                      txtUserName.Buffer.Text,
                                      txtPassword.Buffer.Text);

		try
		{
			DbCon = new MySqlConnection(ConnectString);
            DbCon.Open();
		}
		catch (Exception ex) 
		{
			DbCon = null;
			MessageDialog dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, ex.Message);
			dialog.Show();

			return;
		}

        IsConnected = true;
        string cmdSummary = string.Empty;
        var dbcmd = ReadTemperatureFromDatabase(ref cmdSummary);

        statusbar1.TooltipText = cmdSummary;

		cmdSummary += "\nConnection string: " + ConnectString;

		MessageDialog summaryDialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, "Database successfully connected! " + cmdSummary);
		summaryDialog.Show ();

		if (dbcmd != null) 
		{
			dbcmd.Dispose ();
		}
	}

    /// <summary>
    /// Reads the temperature from database.
    /// </summary>
    /// <returns>The temperature from database.</returns>
    /// <param name="cmdSummary">Cmd summary.</param>
    private IDbCommand ReadTemperatureFromDatabase(ref string cmdSummary)
    {
        IDbCommand dbcmd = DbCon.CreateCommand();
        string sql = "USE adziedzi; SELECT Temperature FROM plc_data;";

        if (!string.IsNullOrWhiteSpace(sql))
        {
            dbcmd.CommandText = sql;
            using (IDataReader reader = dbcmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmdSummary = "Temperature = " + reader["Temperature"].ToString();
                }
            }
        }

        txtNewTemperature.Buffer.Text = cmdSummary;

        return dbcmd;
    }

    /// <summary>
    /// Disconnect_clicked the specified sender and e.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="e">E.</param>
    protected void Disconnect_clicked (object sender, EventArgs e)
    {
        if (IsConnected)
        {
            DbCon.Close();
            DbCon.Dispose();
            IsConnected = false;
        }
    }

    /// <summary>
    /// News the temperature_clicked.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="e">E.</param>
    protected void NewTemperature_clicked (object sender, EventArgs e)
    {
        if (IsConnected)
        {
            int newTemperature = int.Parse(txtNewTemperature.Buffer.Text);
            string sqlCommand = "USE adziedzi; UPDATE plc_data SET Temperature=" + newTemperature.ToString() + " WHERE ID=1;";

            MySqlCommand cmdDatabase = new MySqlCommand(sqlCommand, (MySqlConnection)DbCon);
            try
            {
                cmdDatabase.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageDialog dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, ex.Message);
                dialog.Show();
                return;
            }

            txtNewTemperature.Buffer.Text = "Temperature = " + newTemperature.ToString();
            statusbar1.TooltipText = "Temperature = " + newTemperature.ToString();
        }
    }
}
