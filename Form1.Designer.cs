
namespace ExelAppV1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OK_SKU = new System.Windows.Forms.Button();
            this.File_Search = new System.Windows.Forms.Label();
            this.BtnSearcExcel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_SKU
            // 
            this.OK_SKU.Location = new System.Drawing.Point(128, 280);
            this.OK_SKU.Name = "OK_SKU";
            this.OK_SKU.Size = new System.Drawing.Size(75, 23);
            this.OK_SKU.TabIndex = 2;
            this.OK_SKU.Text = "OK";
            this.OK_SKU.UseVisualStyleBackColor = true;
            this.OK_SKU.Click += new System.EventHandler(this.OK_SKU_Click);
            // 
            // File_Search
            // 
            this.File_Search.AutoSize = true;
            this.File_Search.Location = new System.Drawing.Point(12, 9);
            this.File_Search.Name = "File_Search";
            this.File_Search.Size = new System.Drawing.Size(110, 13);
            this.File_Search.TabIndex = 3;
            this.File_Search.Text = "Selecione um Arquivo";
            // 
            // BtnSearcExcel
            // 
            this.BtnSearcExcel.Location = new System.Drawing.Point(15, 114);
            this.BtnSearcExcel.Name = "BtnSearcExcel";
            this.BtnSearcExcel.Size = new System.Drawing.Size(294, 23);
            this.BtnSearcExcel.TabIndex = 5;
            this.BtnSearcExcel.Text = "Abrir um Arquivo Excel";
            this.BtnSearcExcel.UseVisualStyleBackColor = true;
            this.BtnSearcExcel.Click += new System.EventHandler(this.BtnSearcExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 73);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(99, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 315);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSearcExcel);
            this.Controls.Add(this.File_Search);
            this.Controls.Add(this.OK_SKU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alpha Centauri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK_SKU;
        private System.Windows.Forms.Label File_Search;
        private System.Windows.Forms.Button BtnSearcExcel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

