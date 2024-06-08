namespace FormUI
{
    partial class ColorForm
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
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColorAdd = new System.Windows.Forms.Button();
            this.tbxColorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgwColors = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColorUpdate = new System.Windows.Forms.Button();
            this.tbxColorNameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColors)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.Location = new System.Drawing.Point(303, 188);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(88, 24);
            this.btnColorDelete.TabIndex = 18;
            this.btnColorDelete.Text = "Sil";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            this.btnColorDelete.Click += new System.EventHandler(this.btnColorDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColorAdd);
            this.groupBox1.Controls.Add(this.tbxColorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 106);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renk Ekle";
            // 
            // btnColorAdd
            // 
            this.btnColorAdd.Location = new System.Drawing.Point(68, 66);
            this.btnColorAdd.Name = "btnColorAdd";
            this.btnColorAdd.Size = new System.Drawing.Size(75, 23);
            this.btnColorAdd.TabIndex = 12;
            this.btnColorAdd.Text = "Ekle";
            this.btnColorAdd.UseVisualStyleBackColor = true;
            this.btnColorAdd.Click += new System.EventHandler(this.btnColorAdd_Click);
            // 
            // tbxColorName
            // 
            this.tbxColorName.Location = new System.Drawing.Point(77, 24);
            this.tbxColorName.Name = "tbxColorName";
            this.tbxColorName.Size = new System.Drawing.Size(100, 20);
            this.tbxColorName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Renk :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ara :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(152, 17);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 15;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dgwColors
            // 
            this.dgwColors.Location = new System.Drawing.Point(12, 43);
            this.dgwColors.Name = "dgwColors";
            this.dgwColors.Size = new System.Drawing.Size(240, 169);
            this.dgwColors.TabIndex = 20;
            this.dgwColors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwColors_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColorUpdate);
            this.groupBox2.Controls.Add(this.tbxColorNameUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(247, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 106);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Güncelle";
            // 
            // btnColorUpdate
            // 
            this.btnColorUpdate.Location = new System.Drawing.Point(68, 66);
            this.btnColorUpdate.Name = "btnColorUpdate";
            this.btnColorUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnColorUpdate.TabIndex = 12;
            this.btnColorUpdate.Text = "Güncelle";
            this.btnColorUpdate.UseVisualStyleBackColor = true;
            this.btnColorUpdate.Click += new System.EventHandler(this.btnColorUpdate_Click);
            // 
            // tbxColorNameUpdate
            // 
            this.tbxColorNameUpdate.Location = new System.Drawing.Point(77, 24);
            this.tbxColorNameUpdate.Name = "tbxColorNameUpdate";
            this.tbxColorNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxColorNameUpdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Renk :";
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnColorDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgwColors);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwColors)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColorAdd;
        private System.Windows.Forms.TextBox tbxColorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgwColors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColorUpdate;
        private System.Windows.Forms.TextBox tbxColorNameUpdate;
        private System.Windows.Forms.Label label3;
    }
}