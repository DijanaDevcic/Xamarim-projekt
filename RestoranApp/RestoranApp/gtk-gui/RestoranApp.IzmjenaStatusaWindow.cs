
// This file has been generated by the GUI designer. Do not modify.
namespace RestoranApp
{
	public partial class IzmjenaStatusaWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView nodeview1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.ComboBox combobox;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Button buttonIzbrisi;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget RestoranApp.IzmjenaStatusaWindow
			this.Name = "RestoranApp.IzmjenaStatusaWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("IzmjenaStatusaWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(10));
			// Container child RestoranApp.IzmjenaStatusaWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview1 = new global::Gtk.NodeView();
			this.nodeview1.CanFocus = true;
			this.nodeview1.Name = "nodeview1";
			this.GtkScrolledWindow.Add(this.nodeview1);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.combobox = global::Gtk.ComboBox.NewText();
			this.combobox.AppendText(global::Mono.Unix.Catalog.GetString("zaprimljeno"));
			this.combobox.AppendText(global::Mono.Unix.Catalog.GetString("priprema"));
			this.combobox.AppendText(global::Mono.Unix.Catalog.GetString("dostava"));
			this.combobox.AppendText(global::Mono.Unix.Catalog.GetString("izvršeno"));
			this.combobox.Name = "combobox";
			this.hbox1.Add(this.combobox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.combobox]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox1.Add(this.buttonSpremi);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSpremi]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox1.Add(this.fixed1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed1]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonIzbrisi = new global::Gtk.Button();
			this.buttonIzbrisi.CanFocus = true;
			this.buttonIzbrisi.Name = "buttonIzbrisi";
			this.buttonIzbrisi.UseUnderline = true;
			this.buttonIzbrisi.Label = global::Mono.Unix.Catalog.GetString("Izbrisi");
			this.hbox1.Add(this.buttonIzbrisi);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonIzbrisi]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 595;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
