
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.VBox vbox2;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label label1;
	private global::Gtk.TextView txtServerName;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label label2;
	private global::Gtk.TextView txtUserName;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Label label3;
	private global::Gtk.TextView txtPassword;
	private global::Gtk.VBox vbox4;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label label4;
	private global::Gtk.TextView txtTableName;
	private global::Gtk.HBox hbox10;
	private global::Gtk.Button btnConnect;
	private global::Gtk.HBox hbox3;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button Disconnect;
	private global::Gtk.Button btnNewTemperature;
	private global::Gtk.TextView txtNewTemperature;
	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(9));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Server");
		this.hbox4.Add (this.label1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		w2.Padding = ((uint)(28));
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtServerName = new global::Gtk.TextView ();
		this.txtServerName.CanFocus = true;
		this.txtServerName.Name = "txtServerName";
		this.txtServerName.AcceptsTab = false;
		this.hbox4.Add (this.txtServerName);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtServerName]));
		w3.Position = 1;
		this.vbox3.Add (this.hbox4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("User");
		this.hbox5.Add (this.label2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		w5.Padding = ((uint)(30));
		// Container child hbox5.Gtk.Box+BoxChild
		this.txtUserName = new global::Gtk.TextView ();
		this.txtUserName.CanFocus = true;
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.AcceptsTab = false;
		this.hbox5.Add (this.txtUserName);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtUserName]));
		w6.Position = 1;
		this.vbox3.Add (this.hbox5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox5]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
		this.hbox6.Add (this.label3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label3]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		w8.Padding = ((uint)(18));
		// Container child hbox6.Gtk.Box+BoxChild
		this.txtPassword = new global::Gtk.TextView ();
		this.txtPassword.CanFocus = true;
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.AcceptsTab = false;
		this.hbox6.Add (this.txtPassword);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtPassword]));
		w9.Position = 1;
		this.vbox3.Add (this.hbox6);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox6]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Table");
		this.hbox7.Add (this.label4);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label4]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		w12.Padding = ((uint)(28));
		// Container child hbox7.Gtk.Box+BoxChild
		this.txtTableName = new global::Gtk.TextView ();
		this.txtTableName.CanFocus = true;
		this.txtTableName.Name = "txtTableName";
		this.txtTableName.AcceptsTab = false;
		this.hbox7.Add (this.txtTableName);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.txtTableName]));
		w13.Position = 1;
		this.vbox4.Add (this.hbox7);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox7]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		this.vbox2.Add (this.vbox4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox4]));
		w15.Position = 1;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.btnConnect = new global::Gtk.Button ();
		this.btnConnect.CanFocus = true;
		this.btnConnect.Name = "btnConnect";
		this.btnConnect.UseUnderline = true;
		this.btnConnect.BorderWidth = ((uint)(9));
		this.btnConnect.Label = global::Mono.Unix.Catalog.GetString ("Connect");
		this.hbox10.Add (this.btnConnect);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.btnConnect]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		this.hbox10.Add (this.hbox3);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.hbox3]));
		w17.Position = 1;
		this.vbox2.Add (this.hbox10);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox10]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.Disconnect = new global::Gtk.Button ();
		this.Disconnect.CanFocus = true;
		this.Disconnect.Name = "Disconnect";
		this.Disconnect.UseUnderline = true;
		this.Disconnect.Label = global::Mono.Unix.Catalog.GetString ("Disconnect");
		this.hbox2.Add (this.Disconnect);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.Disconnect]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnNewTemperature = new global::Gtk.Button ();
		this.btnNewTemperature.CanFocus = true;
		this.btnNewTemperature.Name = "btnNewTemperature";
		this.btnNewTemperature.UseUnderline = true;
		this.btnNewTemperature.Label = global::Mono.Unix.Catalog.GetString ("New temperature");
		this.hbox2.Add (this.btnNewTemperature);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnNewTemperature]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtNewTemperature = new global::Gtk.TextView ();
		this.txtNewTemperature.CanFocus = true;
		this.txtNewTemperature.Name = "txtNewTemperature";
		this.txtNewTemperature.AcceptsTab = false;
		this.hbox2.Add (this.txtNewTemperature);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtNewTemperature]));
		w21.Position = 2;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w22.Position = 3;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox2.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusbar1]));
		w23.Position = 4;
		w23.Expand = false;
		w23.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 344;
		this.DefaultHeight = 177;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnConnect.Clicked += new global::System.EventHandler (this.ConnectToDatabase);
		this.Disconnect.Clicked += new global::System.EventHandler (this.Disconnect_clicked);
		this.btnNewTemperature.Clicked += new global::System.EventHandler (this.NewTemperature_clicked);
	}
}
