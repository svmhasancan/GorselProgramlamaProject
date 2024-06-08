namespace FormUI
{
    partial class BrandForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrandUpdate = new System.Windows.Forms.Button();
            this.tbxBrandNameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrandDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrandAdd = new System.Windows.Forms.Button();
            this.tbxBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgwBrands = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrandUpdate);
            this.groupBox2.Controls.Add(this.tbxBrandNameUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(269, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 106);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marka Güncelle";
            // 
            // btnBrandUpdate
            // 
            this.btnBrandUpdate.Location = new System.Drawing.Point(68, 66);
            this.btnBrandUpdate.Name = "btnBrandUpdate";
            this.btnBrandUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBrandUpdate.TabIndex = 12;
            this.btnBrandUpdate.Text = "Güncelle";
            this.btnBrandUpdate.UseVisualStyleBackColor = true;
            this.btnBrandUpdate.Click += new System.EventHandler(this.btnBrandUpdate_Click);
            // 
            // tbxBrandNameUpdate
            // 
            this.tbxBrandNameUpdate.Location = new System.Drawing.Point(77, 24);
            this.tbxBrandNameUpdate.Name = "tbxBrandNameUpdate";
            this.tbxBrandNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbxBrandNameUpdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marka :";
            // 
            // btnBrandDelete
            // 
            this.btnBrandDelete.Location = new System.Drawing.Point(325, 194);
            this.btnBrandDelete.Name = "btnBrandDelete";
            this.btnBrandDelete.Size = new System.Drawing.Size(88, 24);
            this.btnBrandDelete.TabIndex = 25;
            this.btnBrandDelete.Text = "Sil";
            this.btnBrandDelete.UseVisualStyleBackColor = true;
            this.btnBrandDelete.Click += new System.EventHandler(this.btnBrandDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrandAdd);
            this.groupBox1.Controls.Add(this.tbxBrandName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 106);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Ekle";
            // 
            // btnBrandAdd
            // 
            this.btnBrandAdd.Location = new System.Drawing.Point(68, 66);
            this.btnBrandAdd.Name = "btnBrandAdd";
            this.btnBrandAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBrandAdd.TabIndex = 12;
            this.btnBrandAdd.Text = "Ekle";
            this.btnBrandAdd.UseVisualStyleBackColor = true;
            this.btnBrandAdd.Click += new System.EventHandler(this.btnBrandAdd_Click);
            // 
            // tbxBrandName
            // 
            this.tbxBrandName.Location = new System.Drawing.Point(77, 24);
            this.tbxBrandName.Name = "tbxBrandName";
            this.tbxBrandName.Size = new System.Drawing.Size(100, 20);
            this.tbxBrandName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ara :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(174, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 21;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // dgwBrands
            // 
            this.dgwBrands.Location = new System.Drawing.Point(34, 49);
            this.dgwBrands.Name = "dgwBrands";
            this.dgwBrands.Size = new System.Drawing.Size(240, 169);
            this.dgwBrands.TabIndex = 26;
            this.dgwBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBrands_CellClick);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBrandDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgwBrands);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrandUpdate;
        private System.Windows.Forms.TextBox tbxBrandNameUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrandDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrandAdd;
        private System.Windows.Forms.TextBox tbxBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgwBrands;
    }
}