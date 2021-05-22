namespace ТЭК
{
    partial class EquipmentListForm
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.EarthquakeCB = new System.Windows.Forms.CheckBox();
            this.FloodsCB = new System.Windows.Forms.CheckBox();
            this.FiresCB = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.youlocationBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьКоординатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(142, 95);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(808, 466);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // EarthquakeCB
            // 
            this.EarthquakeCB.AutoSize = true;
            this.EarthquakeCB.Location = new System.Drawing.Point(26, 95);
            this.EarthquakeCB.Name = "EarthquakeCB";
            this.EarthquakeCB.Size = new System.Drawing.Size(106, 17);
            this.EarthquakeCB.TabIndex = 1;
            this.EarthquakeCB.Text = "Землетрясения";
            this.EarthquakeCB.UseVisualStyleBackColor = true;
            this.EarthquakeCB.Click += new System.EventHandler(this.EarthquakeCB_Click);
            // 
            // FloodsCB
            // 
            this.FloodsCB.AutoSize = true;
            this.FloodsCB.Location = new System.Drawing.Point(26, 133);
            this.FloodsCB.Name = "FloodsCB";
            this.FloodsCB.Size = new System.Drawing.Size(88, 17);
            this.FloodsCB.TabIndex = 2;
            this.FloodsCB.Text = "Наводнения";
            this.FloodsCB.UseVisualStyleBackColor = true;
            this.FloodsCB.Click += new System.EventHandler(this.FloodsCB_Click);
            // 
            // FiresCB
            // 
            this.FiresCB.AutoSize = true;
            this.FiresCB.Location = new System.Drawing.Point(26, 168);
            this.FiresCB.Name = "FiresCB";
            this.FiresCB.Size = new System.Drawing.Size(68, 17);
            this.FiresCB.TabIndex = 3;
            this.FiresCB.Text = "Пожары";
            this.FiresCB.UseVisualStyleBackColor = true;
            this.FiresCB.Click += new System.EventHandler(this.FiresCB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 4;
            // 
            // youlocationBTN
            // 
            this.youlocationBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.youlocationBTN.Location = new System.Drawing.Point(346, 69);
            this.youlocationBTN.Name = "youlocationBTN";
            this.youlocationBTN.Size = new System.Drawing.Size(30, 20);
            this.youlocationBTN.TabIndex = 5;
            this.youlocationBTN.Text = "ok";
            this.youlocationBTN.UseVisualStyleBackColor = true;
            this.youlocationBTN.Click += new System.EventHandler(this.youlocationBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите координаты";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКоординатыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьКоординатыToolStripMenuItem
            // 
            this.загрузитьКоординатыToolStripMenuItem.Name = "загрузитьКоординатыToolStripMenuItem";
            this.загрузитьКоординатыToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.загрузитьКоординатыToolStripMenuItem.Text = " Загрузить координаты";
            this.загрузитьКоординатыToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКоординатыToolStripMenuItem_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 8;
            // 
            // EquipmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 587);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.youlocationBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FiresCB);
            this.Controls.Add(this.FloodsCB);
            this.Controls.Add(this.EarthquakeCB);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EquipmentListForm";
            this.Text = "EquipmentListForm";
            this.Load += new System.EventHandler(this.EquipmentListForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.CheckBox EarthquakeCB;
        private System.Windows.Forms.CheckBox FloodsCB;
        private System.Windows.Forms.CheckBox FiresCB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button youlocationBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКоординатыToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
    }
}