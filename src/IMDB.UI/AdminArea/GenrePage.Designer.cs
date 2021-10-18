
namespace IMDB.UI.AdminArea
{
    partial class GenrePage
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
            this.grpCreateGenre = new System.Windows.Forms.GroupBox();
            this.btcCreateGenre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateGenre = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOnlyActiveElements = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFindById = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.grpFindById = new System.Windows.Forms.GroupBox();
            this.grpUpdateGenre = new System.Windows.Forms.GroupBox();
            this.txtUpdateGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateGenreId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeleteGenre = new System.Windows.Forms.TextBox();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.grpCreateGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpFindById.SuspendLayout();
            this.grpUpdateGenre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateGenre
            // 
            this.grpCreateGenre.Controls.Add(this.btcCreateGenre);
            this.grpCreateGenre.Controls.Add(this.label1);
            this.grpCreateGenre.Controls.Add(this.txtCreateGenre);
            this.grpCreateGenre.Location = new System.Drawing.Point(12, 12);
            this.grpCreateGenre.Name = "grpCreateGenre";
            this.grpCreateGenre.Size = new System.Drawing.Size(237, 143);
            this.grpCreateGenre.TabIndex = 0;
            this.grpCreateGenre.TabStop = false;
            this.grpCreateGenre.Text = "Create Genre";
            // 
            // btcCreateGenre
            // 
            this.btcCreateGenre.Location = new System.Drawing.Point(142, 93);
            this.btcCreateGenre.Name = "btcCreateGenre";
            this.btcCreateGenre.Size = new System.Drawing.Size(75, 23);
            this.btcCreateGenre.TabIndex = 3;
            this.btcCreateGenre.Text = "Create";
            this.btcCreateGenre.UseVisualStyleBackColor = true;
            this.btcCreateGenre.Click += new System.EventHandler(this.btcCreateGenre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create  Genre:";
            // 
            // txtCreateGenre
            // 
            this.txtCreateGenre.Location = new System.Drawing.Point(117, 37);
            this.txtCreateGenre.Name = "txtCreateGenre";
            this.txtCreateGenre.Size = new System.Drawing.Size(100, 22);
            this.txtCreateGenre.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 190);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnOnlyActiveElements
            // 
            this.btnOnlyActiveElements.Location = new System.Drawing.Point(392, 207);
            this.btnOnlyActiveElements.Name = "btnOnlyActiveElements";
            this.btnOnlyActiveElements.Size = new System.Drawing.Size(199, 26);
            this.btnOnlyActiveElements.TabIndex = 5;
            this.btnOnlyActiveElements.Text = "Show Only Active Elements";
            this.btnOnlyActiveElements.UseVisualStyleBackColor = true;
            this.btnOnlyActiveElements.Click += new System.EventHandler(this.btnOnlyActiveElements_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find Id :";
            // 
            // BtnFindById
            // 
            this.BtnFindById.Location = new System.Drawing.Point(148, 89);
            this.BtnFindById.Name = "BtnFindById";
            this.BtnFindById.Size = new System.Drawing.Size(75, 23);
            this.BtnFindById.TabIndex = 7;
            this.BtnFindById.Text = "Find";
            this.BtnFindById.UseVisualStyleBackColor = true;
            this.BtnFindById.Click += new System.EventHandler(this.BtnFindById_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(123, 28);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(100, 22);
            this.txtFindById.TabIndex = 8;
            // 
            // grpFindById
            // 
            this.grpFindById.Controls.Add(this.txtFindById);
            this.grpFindById.Controls.Add(this.label2);
            this.grpFindById.Controls.Add(this.BtnFindById);
            this.grpFindById.Location = new System.Drawing.Point(255, 16);
            this.grpFindById.Name = "grpFindById";
            this.grpFindById.Size = new System.Drawing.Size(239, 139);
            this.grpFindById.TabIndex = 9;
            this.grpFindById.TabStop = false;
            this.grpFindById.Text = "Find By Id";
            // 
            // grpUpdateGenre
            // 
            this.grpUpdateGenre.Controls.Add(this.btnUpdate);
            this.grpUpdateGenre.Controls.Add(this.txtUpdateGenreId);
            this.grpUpdateGenre.Controls.Add(this.txtUpdateGenre);
            this.grpUpdateGenre.Controls.Add(this.label4);
            this.grpUpdateGenre.Controls.Add(this.label3);
            this.grpUpdateGenre.Location = new System.Drawing.Point(500, 16);
            this.grpUpdateGenre.Name = "grpUpdateGenre";
            this.grpUpdateGenre.Size = new System.Drawing.Size(239, 139);
            this.grpUpdateGenre.TabIndex = 9;
            this.grpUpdateGenre.TabStop = false;
            this.grpUpdateGenre.Text = "Update Genre ";
            // 
            // txtUpdateGenre
            // 
            this.txtUpdateGenre.Location = new System.Drawing.Point(123, 54);
            this.txtUpdateGenre.Name = "txtUpdateGenre";
            this.txtUpdateGenre.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateGenre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Update Genre :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre Id :";
            // 
            // txtUpdateGenreId
            // 
            this.txtUpdateGenreId.Location = new System.Drawing.Point(123, 21);
            this.txtUpdateGenreId.Name = "txtUpdateGenreId";
            this.txtUpdateGenreId.ReadOnly = true;
            this.txtUpdateGenreId.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateGenreId.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteGenre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDeleteGenre);
            this.groupBox1.Location = new System.Drawing.Point(766, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Delete Genre:";
            // 
            // txtDeleteGenre
            // 
            this.txtDeleteGenre.Location = new System.Drawing.Point(117, 37);
            this.txtDeleteGenre.Name = "txtDeleteGenre";
            this.txtDeleteGenre.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteGenre.TabIndex = 2;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(142, 81);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenre.TabIndex = 3;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // GenrePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.grpUpdateGenre);
            this.Controls.Add(this.grpFindById);
            this.Controls.Add(this.btnOnlyActiveElements);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCreateGenre);
            this.Name = "GenrePage";
            this.Text = "GenrePage";
            this.Load += new System.EventHandler(this.GenrePage_Load);
            this.grpCreateGenre.ResumeLayout(false);
            this.grpCreateGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpFindById.ResumeLayout(false);
            this.grpFindById.PerformLayout();
            this.grpUpdateGenre.ResumeLayout(false);
            this.grpUpdateGenre.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateGenre;
        private System.Windows.Forms.Button btcCreateGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateGenre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOnlyActiveElements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFindById;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.GroupBox grpFindById;
        private System.Windows.Forms.GroupBox grpUpdateGenre;
        private System.Windows.Forms.TextBox txtUpdateGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateGenreId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeleteGenre;
    }
}