namespace Mapper
{
    partial class MapperForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.radioClassBT = new System.Windows.Forms.RadioButton();
            this.radioSysBT = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBtType = new System.Windows.Forms.ComboBox();
            this.comboOncolor = new System.Windows.Forms.ComboBox();
            this.comboOffcolor = new System.Windows.Forms.ComboBox();
            this.checkBoxOnFlashing = new System.Windows.Forms.CheckBox();
            this.checkBoxOffFlashing = new System.Windows.Forms.CheckBox();
            this.ValidateBT = new System.Windows.Forms.Button();
            this.labelOffColor = new System.Windows.Forms.Label();
            this.labelOnColor = new System.Windows.Forms.Label();
            this.labelBTtype = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(12, 50);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 1;
            // 
            // radioClassBT
            // 
            this.radioClassBT.AutoSize = true;
            this.radioClassBT.Location = new System.Drawing.Point(166, 28);
            this.radioClassBT.Name = "radioClassBT";
            this.radioClassBT.Size = new System.Drawing.Size(109, 17);
            this.radioClassBT.TabIndex = 2;
            this.radioClassBT.TabStop = true;
            this.radioClassBT.Text = "Boutton classique";
            this.radioClassBT.UseVisualStyleBackColor = true;
            this.radioClassBT.CheckedChanged += new System.EventHandler(this.radioClassBT_CheckedChanged);
            // 
            // radioSysBT
            // 
            this.radioSysBT.AutoSize = true;
            this.radioSysBT.Location = new System.Drawing.Point(166, 51);
            this.radioSysBT.Name = "radioSysBT";
            this.radioSysBT.Size = new System.Drawing.Size(105, 17);
            this.radioSysBT.TabIndex = 3;
            this.radioSysBT.TabStop = true;
            this.radioSysBT.Text = "Boutton Systeme";
            this.radioSysBT.UseVisualStyleBackColor = true;
            this.radioSysBT.CheckedChanged += new System.EventHandler(this.radioSysBT_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 28);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID :";
            // 
            // comboBtType
            // 
            this.comboBtType.FormattingEnabled = true;
            this.comboBtType.Location = new System.Drawing.Point(12, 127);
            this.comboBtType.Name = "comboBtType";
            this.comboBtType.Size = new System.Drawing.Size(121, 21);
            this.comboBtType.TabIndex = 5;
            // 
            // comboOncolor
            // 
            this.comboOncolor.FormattingEnabled = true;
            this.comboOncolor.Location = new System.Drawing.Point(12, 217);
            this.comboOncolor.Name = "comboOncolor";
            this.comboOncolor.Size = new System.Drawing.Size(121, 21);
            this.comboOncolor.TabIndex = 6;
            // 
            // comboOffcolor
            // 
            this.comboOffcolor.FormattingEnabled = true;
            this.comboOffcolor.Location = new System.Drawing.Point(12, 292);
            this.comboOffcolor.Name = "comboOffcolor";
            this.comboOffcolor.Size = new System.Drawing.Size(121, 21);
            this.comboOffcolor.TabIndex = 7;
            // 
            // checkBoxOnFlashing
            // 
            this.checkBoxOnFlashing.AutoSize = true;
            this.checkBoxOnFlashing.Location = new System.Drawing.Point(12, 244);
            this.checkBoxOnFlashing.Name = "checkBoxOnFlashing";
            this.checkBoxOnFlashing.Size = new System.Drawing.Size(82, 17);
            this.checkBoxOnFlashing.TabIndex = 8;
            this.checkBoxOnFlashing.Text = "On Flashing";
            this.checkBoxOnFlashing.UseVisualStyleBackColor = true;
            // 
            // checkBoxOffFlashing
            // 
            this.checkBoxOffFlashing.AutoSize = true;
            this.checkBoxOffFlashing.Location = new System.Drawing.Point(12, 319);
            this.checkBoxOffFlashing.Name = "checkBoxOffFlashing";
            this.checkBoxOffFlashing.Size = new System.Drawing.Size(82, 17);
            this.checkBoxOffFlashing.TabIndex = 9;
            this.checkBoxOffFlashing.Text = "Off Flashing";
            this.checkBoxOffFlashing.UseVisualStyleBackColor = true;
            // 
            // ValidateBT
            // 
            this.ValidateBT.Location = new System.Drawing.Point(88, 362);
            this.ValidateBT.Name = "ValidateBT";
            this.ValidateBT.Size = new System.Drawing.Size(75, 23);
            this.ValidateBT.TabIndex = 10;
            this.ValidateBT.Text = "Valider";
            this.ValidateBT.UseVisualStyleBackColor = true;
            this.ValidateBT.Click += new System.EventHandler(this.ValidateBT_Click);
            // 
            // labelOffColor
            // 
            this.labelOffColor.AutoSize = true;
            this.labelOffColor.Location = new System.Drawing.Point(12, 273);
            this.labelOffColor.Name = "labelOffColor";
            this.labelOffColor.Size = new System.Drawing.Size(48, 13);
            this.labelOffColor.TabIndex = 11;
            this.labelOffColor.Text = "Off Color";
            // 
            // labelOnColor
            // 
            this.labelOnColor.AutoSize = true;
            this.labelOnColor.Location = new System.Drawing.Point(12, 201);
            this.labelOnColor.Name = "labelOnColor";
            this.labelOnColor.Size = new System.Drawing.Size(46, 13);
            this.labelOnColor.TabIndex = 12;
            this.labelOnColor.Text = "on Color";
            // 
            // labelBTtype
            // 
            this.labelBTtype.AutoSize = true;
            this.labelBTtype.Location = new System.Drawing.Point(12, 108);
            this.labelBTtype.Name = "labelBTtype";
            this.labelBTtype.Size = new System.Drawing.Size(65, 13);
            this.labelBTtype.TabIndex = 13;
            this.labelBTtype.Text = "Button Type";
            // 
            // MapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 421);
            this.Controls.Add(this.labelBTtype);
            this.Controls.Add(this.labelOnColor);
            this.Controls.Add(this.labelOffColor);
            this.Controls.Add(this.ValidateBT);
            this.Controls.Add(this.checkBoxOffFlashing);
            this.Controls.Add(this.checkBoxOnFlashing);
            this.Controls.Add(this.comboOffcolor);
            this.Controls.Add(this.comboOncolor);
            this.Controls.Add(this.comboBtType);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.radioSysBT);
            this.Controls.Add(this.radioClassBT);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MapperForm";
            this.Text = "Mapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapperForm_FormClosing);
            this.Load += new System.EventHandler(this.MapperForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.RadioButton radioClassBT;
        private System.Windows.Forms.RadioButton radioSysBT;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBtType;
        private System.Windows.Forms.ComboBox comboOncolor;
        private System.Windows.Forms.ComboBox comboOffcolor;
        private System.Windows.Forms.CheckBox checkBoxOnFlashing;
        private System.Windows.Forms.CheckBox checkBoxOffFlashing;
        private System.Windows.Forms.Button ValidateBT;
        private System.Windows.Forms.Label labelOffColor;
        private System.Windows.Forms.Label labelOnColor;
        private System.Windows.Forms.Label labelBTtype;
    }
}

