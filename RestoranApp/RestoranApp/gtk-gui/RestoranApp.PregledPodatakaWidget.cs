
// This file has been generated by the GUI designer. Do not modify.
namespace RestoranApp
{
	public partial class PregledPodatakaWidget
	{
		private global::Gtk.VBox vbox14;

		private global::Gtk.HBox hbox9;

		private global::Gtk.VBox vbox15;

		private global::Gtk.Label label11;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.VBox vbox16;

		private global::Gtk.Entry entryUlica;

		private global::Gtk.Entry entryKontakt;

		private global::Gtk.Entry entryNapomena;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Button buttonSpremi;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget RestoranApp.PregledPodatakaWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "RestoranApp.PregledPodatakaWidget";
			// Container child RestoranApp.PregledPodatakaWidget.Gtk.Container+ContainerChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Ulica i kućni broj:");
			this.vbox15.Add(this.label11);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label11]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Kontakt broj:");
			this.vbox15.Add(this.label12);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label12]));
			w2.Position = 1;
			w2.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Napomena:");
			this.vbox15.Add(this.label13);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label13]));
			w3.Position = 2;
			w3.Fill = false;
			this.hbox9.Add(this.vbox15);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox15]));
			w4.Position = 0;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vbox16 = new global::Gtk.VBox();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 6;
			// Container child vbox16.Gtk.Box+BoxChild
			this.entryUlica = new global::Gtk.Entry();
			this.entryUlica.CanFocus = true;
			this.entryUlica.Name = "entryUlica";
			this.entryUlica.IsEditable = true;
			this.entryUlica.InvisibleChar = '●';
			this.vbox16.Add(this.entryUlica);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.entryUlica]));
			w5.Position = 0;
			w5.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.entryKontakt = new global::Gtk.Entry();
			this.entryKontakt.CanFocus = true;
			this.entryKontakt.Name = "entryKontakt";
			this.entryKontakt.IsEditable = true;
			this.entryKontakt.InvisibleChar = '●';
			this.vbox16.Add(this.entryKontakt);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.entryKontakt]));
			w6.Position = 1;
			w6.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.entryNapomena = new global::Gtk.Entry();
			this.entryNapomena.CanFocus = true;
			this.entryNapomena.Name = "entryNapomena";
			this.entryNapomena.IsEditable = true;
			this.entryNapomena.InvisibleChar = '●';
			this.vbox16.Add(this.entryNapomena);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.entryNapomena]));
			w7.Position = 2;
			w7.Fill = false;
			this.hbox9.Add(this.vbox16);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox16]));
			w8.Position = 1;
			this.vbox14.Add(this.hbox9);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox9]));
			w9.Position = 0;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox10.Add(this.buttonSpremi);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.buttonSpremi]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox14.Add(this.hbox10);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox10]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.Add(this.vbox14);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
