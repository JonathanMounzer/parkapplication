namespace ParkApplication
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choosecarlabel1 = new System.Windows.Forms.Label();
            this.addcarlabel1 = new System.Windows.Forms.Label();
            this.carcombobox = new System.Windows.Forms.ComboBox();
            this.addcartextbox1 = new System.Windows.Forms.TextBox();
            this.addcarbutton1 = new System.Windows.Forms.Button();
            this.zonecombobox = new System.Windows.Forms.ComboBox();
            this.zonelabel1 = new System.Windows.Forms.Label();
            this.HoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourlabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.CarErrorLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.TicketListView = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timmar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorLabelMain = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CheckPriceButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // choosecarlabel1
            // 
            this.choosecarlabel1.AutoSize = true;
            this.choosecarlabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosecarlabel1.Location = new System.Drawing.Point(227, 172);
            this.choosecarlabel1.Name = "choosecarlabel1";
            this.choosecarlabel1.Size = new System.Drawing.Size(84, 18);
            this.choosecarlabel1.TabIndex = 21;
            this.choosecarlabel1.Text = "Välj bil:";
            this.choosecarlabel1.Click += new System.EventHandler(this.choosecarlabel1_Click);
            // 
            // addcarlabel1
            // 
            this.addcarlabel1.AutoSize = true;
            this.addcarlabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcarlabel1.Location = new System.Drawing.Point(44, 172);
            this.addcarlabel1.Name = "addcarlabel1";
            this.addcarlabel1.Size = new System.Drawing.Size(125, 18);
            this.addcarlabel1.TabIndex = 22;
            this.addcarlabel1.Text = "Lägg till bil:";
            this.addcarlabel1.Click += new System.EventHandler(this.addcarlabel1_Click);
            // 
            // carcombobox
            // 
            this.carcombobox.FormattingEnabled = true;
            this.carcombobox.Location = new System.Drawing.Point(210, 204);
            this.carcombobox.Name = "carcombobox";
            this.carcombobox.Size = new System.Drawing.Size(121, 21);
            this.carcombobox.TabIndex = 23;
            this.carcombobox.SelectedIndexChanged += new System.EventHandler(this.carcombobox1_SelectedIndexChanged);
            // 
            // addcartextbox1
            // 
            this.addcartextbox1.Location = new System.Drawing.Point(59, 204);
            this.addcartextbox1.Name = "addcartextbox1";
            this.addcartextbox1.Size = new System.Drawing.Size(100, 20);
            this.addcartextbox1.TabIndex = 24;
            this.addcartextbox1.TextChanged += new System.EventHandler(this.addcartextbox1_TextChanged);
            // 
            // addcarbutton1
            // 
            this.addcarbutton1.Location = new System.Drawing.Point(73, 247);
            this.addcarbutton1.Name = "addcarbutton1";
            this.addcarbutton1.Size = new System.Drawing.Size(75, 23);
            this.addcarbutton1.TabIndex = 25;
            this.addcarbutton1.Text = "Lägg till";
            this.addcarbutton1.UseVisualStyleBackColor = true;
            this.addcarbutton1.Click += new System.EventHandler(this.addcarbutton1_Click);
            // 
            // zonecombobox
            // 
            this.zonecombobox.FormattingEnabled = true;
            this.zonecombobox.Location = new System.Drawing.Point(210, 338);
            this.zonecombobox.Name = "zonecombobox";
            this.zonecombobox.Size = new System.Drawing.Size(121, 21);
            this.zonecombobox.TabIndex = 27;
            this.zonecombobox.SelectedIndexChanged += new System.EventHandler(this.zonecombobox_SelectedIndexChanged);
            // 
            // zonelabel1
            // 
            this.zonelabel1.AutoSize = true;
            this.zonelabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zonelabel1.Location = new System.Drawing.Point(223, 306);
            this.zonelabel1.Name = "zonelabel1";
            this.zonelabel1.Size = new System.Drawing.Size(88, 18);
            this.zonelabel1.TabIndex = 26;
            this.zonelabel1.Text = "Välj Zon:";
            this.zonelabel1.Click += new System.EventHandler(this.zonelabel1_Click);
            // 
            // HoursUpDown
            // 
            this.HoursUpDown.Location = new System.Drawing.Point(48, 337);
            this.HoursUpDown.Name = "HoursUpDown";
            this.HoursUpDown.Size = new System.Drawing.Size(120, 20);
            this.HoursUpDown.TabIndex = 28;
            this.HoursUpDown.ValueChanged += new System.EventHandler(this.HoursUpDown_ValueChanged);
            // 
            // hourlabel1
            // 
            this.hourlabel1.AutoSize = true;
            this.hourlabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlabel1.Location = new System.Drawing.Point(44, 306);
            this.hourlabel1.Name = "hourlabel1";
            this.hourlabel1.Size = new System.Drawing.Size(133, 18);
            this.hourlabel1.TabIndex = 29;
            this.hourlabel1.Text = "Antal timmar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Köp din parkeringsbiljett genom att fylla in varje fält! Var noga med att välja r" +
    "ätt \r\nregistreringsnummer och zon.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "ParkApp";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.Location = new System.Drawing.Point(451, 172);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(188, 18);
            this.pricelabel.TabIndex = 37;
            this.pricelabel.Text = "Senaste biljettköp:";
            // 
            // CarErrorLabel
            // 
            this.CarErrorLabel.AutoSize = true;
            this.CarErrorLabel.Location = new System.Drawing.Point(70, 227);
            this.CarErrorLabel.Name = "CarErrorLabel";
            this.CarErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.CarErrorLabel.TabIndex = 39;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(469, 421);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 36);
            this.LogOutButton.TabIndex = 40;
            this.LogOutButton.Text = "Logga ut";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.Location = new System.Drawing.Point(397, 421);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(75, 36);
            this.BuyTicketButton.TabIndex = 41;
            this.BuyTicketButton.Text = "Köp biljett!";
            this.BuyTicketButton.UseVisualStyleBackColor = true;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // TicketListView
            // 
            this.TicketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.Regnr,
            this.Zon,
            this.Pris,
            this.Timmar,
            this.Ticket});
            this.TicketListView.Location = new System.Drawing.Point(347, 193);
            this.TicketListView.Name = "TicketListView";
            this.TicketListView.Size = new System.Drawing.Size(411, 155);
            this.TicketListView.TabIndex = 42;
            this.TicketListView.UseCompatibleStateImageBehavior = false;
            this.TicketListView.View = System.Windows.Forms.View.Details;
            this.TicketListView.SelectedIndexChanged += new System.EventHandler(this.TicketListView_SelectedIndexChanged);
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 103;
            // 
            // Regnr
            // 
            this.Regnr.Text = "Regnr";
            // 
            // Zon
            // 
            this.Zon.Text = "Zon";
            // 
            // Pris
            // 
            this.Pris.Text = "Pris";
            // 
            // Timmar
            // 
            this.Timmar.Text = "Timmar";
            this.Timmar.Width = 68;
            // 
            // Ticket
            // 
            this.Ticket.Text = "Ticketnr";
            this.Ticket.Width = 75;
            // 
            // ErrorLabelMain
            // 
            this.ErrorLabelMain.AutoSize = true;
            this.ErrorLabelMain.Location = new System.Drawing.Point(163, 486);
            this.ErrorLabelMain.Name = "ErrorLabelMain";
            this.ErrorLabelMain.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelMain.TabIndex = 43;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(59, 430);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 44;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(82, 400);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(52, 18);
            this.PriceLbl.TabIndex = 45;
            this.PriceLbl.Text = "Pris:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(236, 247);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 46;
            this.DeleteButton.Text = "Ta bort";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteButton_KeyPress);
            // 
            // CheckPriceButton
            // 
            this.CheckPriceButton.Location = new System.Drawing.Point(188, 421);
            this.CheckPriceButton.Name = "CheckPriceButton";
            this.CheckPriceButton.Size = new System.Drawing.Size(75, 36);
            this.CheckPriceButton.TabIndex = 47;
            this.CheckPriceButton.Text = "Se pris";
            this.CheckPriceButton.UseVisualStyleBackColor = true;
            this.CheckPriceButton.Click += new System.EventHandler(this.CheckPriceButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(469, 370);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 36);
            this.ClearButton.TabIndex = 48;
            this.ClearButton.Text = "Rensa";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 511);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CheckPriceButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ErrorLabelMain);
            this.Controls.Add(this.TicketListView);
            this.Controls.Add(this.BuyTicketButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CarErrorLabel);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hourlabel1);
            this.Controls.Add(this.HoursUpDown);
            this.Controls.Add(this.zonecombobox);
            this.Controls.Add(this.zonelabel1);
            this.Controls.Add(this.addcarbutton1);
            this.Controls.Add(this.addcartextbox1);
            this.Controls.Add(this.carcombobox);
            this.Controls.Add(this.addcarlabel1);
            this.Controls.Add(this.choosecarlabel1);
            this.Name = "Start";
            this.Text = "Start";
            this.Shown += new System.EventHandler(this.Start_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosecarlabel1;
        private System.Windows.Forms.Label addcarlabel1;
        private System.Windows.Forms.ComboBox carcombobox;
        private System.Windows.Forms.TextBox addcartextbox1;
        private System.Windows.Forms.Button addcarbutton1;
        private System.Windows.Forms.ComboBox zonecombobox;
        private System.Windows.Forms.Label zonelabel1;
        private System.Windows.Forms.NumericUpDown HoursUpDown;
        private System.Windows.Forms.Label hourlabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label CarErrorLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.ListView TicketListView;
        private System.Windows.Forms.Label ErrorLabelMain;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CheckPriceButton;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Regnr;
        private System.Windows.Forms.ColumnHeader Zon;
        private System.Windows.Forms.ColumnHeader Pris;
        private System.Windows.Forms.ColumnHeader Timmar;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ColumnHeader Ticket;
    }
}