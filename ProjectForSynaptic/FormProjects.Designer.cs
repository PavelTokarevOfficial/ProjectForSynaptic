namespace ProjectForSynaptic
{
    partial class FormProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjects));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.listViewProjects = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxNewChallenge = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(36, 117);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Location = new System.Drawing.Point(36, 204);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(99, 23);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // listViewProjects
            // 
            this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2});
            this.listViewProjects.FullRowSelect = true;
            this.listViewProjects.GridLines = true;
            this.listViewProjects.HideSelection = false;
            this.listViewProjects.Location = new System.Drawing.Point(178, 12);
            this.listViewProjects.MultiSelect = false;
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.Size = new System.Drawing.Size(345, 215);
            this.listViewProjects.TabIndex = 4;
            this.listViewProjects.UseCompatibleStateImageBehavior = false;
            this.listViewProjects.View = System.Windows.Forms.View.Details;
            this.listViewProjects.SelectedIndexChanged += new System.EventHandler(this.listViewProjects_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Новые проекты";
            this.columnHeader7.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Статус";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 75);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 13);
            this.label.TabIndex = 19;
            this.label.Text = "Имя нового проекта";
            // 
            // textBoxNewChallenge
            // 
            this.textBoxNewChallenge.Location = new System.Drawing.Point(12, 91);
            this.textBoxNewChallenge.Name = "textBoxNewChallenge";
            this.textBoxNewChallenge.Size = new System.Drawing.Size(160, 20);
            this.textBoxNewChallenge.TabIndex = 24;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(36, 146);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 23);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(36, 175);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(99, 23);
            this.buttonDel.TabIndex = 26;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(533, 238);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxNewChallenge);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewProjects);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(549, 277);
            this.MinimumSize = new System.Drawing.Size(549, 277);
            this.Name = "FormProjects";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление проекта";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ListView listViewProjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxNewChallenge;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}