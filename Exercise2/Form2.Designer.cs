namespace Exercise2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dBJadwalAkademikDataSet1 = new Exercise2.DBJadwalAkademikDataSet1();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Exercise2.DBJadwalAkademikDataSet1TableAdapters.MahasiswaTableAdapter();
            this.dBJadwalAkademikDataSet2 = new Exercise2.DBJadwalAkademikDataSet2();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter1 = new Exercise2.DBJadwalAkademikDataSet2TableAdapters.MahasiswaTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamhsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBJadwalAkademikDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJadwalAkademikDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBJadwalAkademikDataSet1
            // 
            this.dBJadwalAkademikDataSet1.DataSetName = "DBJadwalAkademikDataSet1";
            this.dBJadwalAkademikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.dBJadwalAkademikDataSet1;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // dBJadwalAkademikDataSet2
            // 
            this.dBJadwalAkademikDataSet2.DataSetName = "DBJadwalAkademikDataSet2";
            this.dBJadwalAkademikDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.dBJadwalAkademikDataSet2;
            // 
            // mahasiswaTableAdapter1
            // 
            this.mahasiswaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmhsDataGridViewTextBoxColumn,
            this.namamhsDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(56, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // idmhsDataGridViewTextBoxColumn
            // 
            this.idmhsDataGridViewTextBoxColumn.DataPropertyName = "id_mhs";
            this.idmhsDataGridViewTextBoxColumn.HeaderText = "id_mhs";
            this.idmhsDataGridViewTextBoxColumn.Name = "idmhsDataGridViewTextBoxColumn";
            // 
            // namamhsDataGridViewTextBoxColumn
            // 
            this.namamhsDataGridViewTextBoxColumn.DataPropertyName = "nama_mhs";
            this.namamhsDataGridViewTextBoxColumn.HeaderText = "nama_mhs";
            this.namamhsDataGridViewTextBoxColumn.Name = "namamhsDataGridViewTextBoxColumn";
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "no_telp";
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(56, 259);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(112, 48);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBJadwalAkademikDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJadwalAkademikDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DBJadwalAkademikDataSet1 dBJadwalAkademikDataSet1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private DBJadwalAkademikDataSet1TableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private DBJadwalAkademikDataSet2 dBJadwalAkademikDataSet2;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private DBJadwalAkademikDataSet2TableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamhsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
    }
}