
namespace ServCar
{
    partial class Vehicules
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.drivers = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.affecter = new System.Windows.Forms.Button();
            this.driverImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cars = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.matricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.couleur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carburant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kilometrage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.drivers);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.affecter);
            this.panel1.Controls.Add(this.driverImage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cars);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 454);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ServCar.Properties.Resources.logoY1;
            this.pictureBox5.Location = new System.Drawing.Point(12, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(165, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // drivers
            // 
            this.drivers.FlatAppearance.BorderSize = 0;
            this.drivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivers.ForeColor = System.Drawing.Color.White;
            this.drivers.Location = new System.Drawing.Point(63, 128);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(128, 29);
            this.drivers.TabIndex = 10;
            this.drivers.Text = "Conducteurs";
            this.drivers.UseVisualStyleBackColor = true;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ServCar.Properties.Resources.logout__2_;
            this.pictureBox4.Location = new System.Drawing.Point(35, 419);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(61, 409);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(134, 41);
            this.logout.TabIndex = 7;
            this.logout.Text = "Déconnexion";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dashboard
            // 
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Location = new System.Drawing.Point(69, 213);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(124, 35);
            this.dashboard.TabIndex = 8;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ServCar.Properties.Resources.dashboard__1___2_;
            this.pictureBox3.Location = new System.Drawing.Point(24, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ServCar.Properties.Resources.affect__1_;
            this.pictureBox2.Location = new System.Drawing.Point(27, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // affecter
            // 
            this.affecter.FlatAppearance.BorderSize = 0;
            this.affecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.affecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affecter.ForeColor = System.Drawing.Color.White;
            this.affecter.Location = new System.Drawing.Point(43, 165);
            this.affecter.Name = "affecter";
            this.affecter.Size = new System.Drawing.Size(134, 43);
            this.affecter.TabIndex = 4;
            this.affecter.Text = "Affecter";
            this.affecter.UseVisualStyleBackColor = true;
            this.affecter.Click += new System.EventHandler(this.affecter_Click);
            // 
            // driverImage
            // 
            this.driverImage.Image = global::ServCar.Properties.Resources.users;
            this.driverImage.Location = new System.Drawing.Point(27, 127);
            this.driverImage.Name = "driverImage";
            this.driverImage.Size = new System.Drawing.Size(33, 30);
            this.driverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.driverImage.TabIndex = 3;
            this.driverImage.TabStop = false;
            this.driverImage.Click += new System.EventHandler(this.driverImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServCar.Properties.Resources.veh__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cars
            // 
            this.cars.BackColor = System.Drawing.Color.Transparent;
            this.cars.FlatAppearance.BorderSize = 0;
            this.cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars.ForeColor = System.Drawing.Color.White;
            this.cars.Location = new System.Drawing.Point(35, 83);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(162, 37);
            this.cars.TabIndex = 0;
            this.cars.Text = "Véhicules";
            this.cars.UseVisualStyleBackColor = false;
            this.cars.Click += new System.EventHandler(this.cars_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Location = new System.Drawing.Point(367, 89);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(226, 20);
            this.searchBox.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matricule,
            this.marque,
            this.couleur,
            this.carburant,
            this.puissance,
            this.kilometrage});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(243, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 216);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // matricule
            // 
            this.matricule.Text = "Matricule";
            this.matricule.Width = 80;
            // 
            // marque
            // 
            this.marque.Text = "Marque";
            this.marque.Width = 80;
            // 
            // couleur
            // 
            this.couleur.Text = "Couleur";
            this.couleur.Width = 80;
            // 
            // carburant
            // 
            this.carburant.Text = "Carburant";
            this.carburant.Width = 80;
            // 
            // puissance
            // 
            this.puissance.Text = "Puissance";
            this.puissance.Width = 80;
            // 
            // kilometrage
            // 
            this.kilometrage.Text = "Kilométrage";
            this.kilometrage.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(394, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Véhicules";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.ajouter.FlatAppearance.BorderSize = 0;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.ajouter.Location = new System.Drawing.Point(421, 382);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(135, 40);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Ajouter Véhicule";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ServCar.Properties.Resources.search3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(599, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 20);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ServCar.Properties.Resources.edit;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(243, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ServCar.Properties.Resources.delete__2_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(705, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Vehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox driverImage;
        private System.Windows.Forms.Button affecter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button drivers;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ColumnHeader matricule;
        private System.Windows.Forms.ColumnHeader marque;
        private System.Windows.Forms.ColumnHeader couleur;
        private System.Windows.Forms.ColumnHeader carburant;
        private System.Windows.Forms.ColumnHeader puissance;
        private System.Windows.Forms.ColumnHeader kilometrage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

