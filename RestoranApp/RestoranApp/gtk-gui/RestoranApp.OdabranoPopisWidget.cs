
// This file has been generated by the GUI designer. Do not modify.
namespace RestoranApp
{
	public partial class OdabranoPopisWidget
	{
		private global::Gtk.VBox vbox12;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView nodeview1;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelUkupnaCijena;

		private global::Gtk.Label label8;

		private global::Gtk.HButtonBox hbuttonbox1;

		private global::Gtk.Button buttonNaruci;

		private global::Gtk.Button buttonGotovo;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget RestoranApp.OdabranoPopisWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "RestoranApp.OdabranoPopisWidget";
			// Container child RestoranApp.OdabranoPopisWidget.Gtk.Container+ContainerChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview1 = new global::Gtk.NodeView();
			this.nodeview1.CanFocus = true;
			this.nodeview1.Name = "nodeview1";
			this.GtkScrolledWindow.Add(this.nodeview1);
			this.vbox12.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox12.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Ukupna cijena:");
			this.hbox7.Add(this.label6);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label6]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelUkupnaCijena = new global::Gtk.Label();
			this.labelUkupnaCijena.Name = "labelUkupnaCijena";
			this.labelUkupnaCijena.LabelProp = global::Mono.Unix.Catalog.GetString("-");
			this.hbox7.Add(this.labelUkupnaCijena);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelUkupnaCijena]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("kn");
			this.hbox7.Add(this.label8);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label8]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox12.Add(this.hbox7);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.hbox7]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonNaruci = new global::Gtk.Button();
			this.buttonNaruci.CanFocus = true;
			this.buttonNaruci.Name = "buttonNaruci";
			this.buttonNaruci.UseUnderline = true;
			this.buttonNaruci.Label = global::Mono.Unix.Catalog.GetString("Naruči još");
			this.hbuttonbox1.Add(this.buttonNaruci);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonNaruci]));
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonGotovo = new global::Gtk.Button();
			this.buttonGotovo.CanFocus = true;
			this.buttonGotovo.Name = "buttonGotovo";
			this.buttonGotovo.UseUnderline = true;
			this.buttonGotovo.Label = global::Mono.Unix.Catalog.GetString("Gotovo");
			this.hbuttonbox1.Add(this.buttonGotovo);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonGotovo]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox12.Add(this.hbuttonbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.hbuttonbox1]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.Add(this.vbox12);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
