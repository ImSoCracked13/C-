namespace DesktopInformationSystem
{
    partial class MainForm
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_manage_admin = new System.Windows.Forms.Button();
            this.btn_manage_teacher = new System.Windows.Forms.Button();
            this.btn_manage_student = new System.Windows.Forms.Button();
            this.btn_group_by_admin = new System.Windows.Forms.Button();
            this.btn_group_by_teacher = new System.Windows.Forms.Button();
            this.btn_group_by_student = new System.Windows.Forms.Button();
            this.holderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DesktopInformationSystem.Database1DataSet();
            this.holderTableAdapter = new DesktopInformationSystem.Database1DataSetTableAdapters.HolderTableAdapter();
            this.tableAdapterManager = new DesktopInformationSystem.Database1DataSetTableAdapters.TableAdapterManager();
            this.database1DataSet1 = new DesktopInformationSystem.Database1DataSet();
            this.database1DataSet2 = new DesktopInformationSystem.Database1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.holderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(331, 356);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(128, 44);
            this.btn_load.TabIndex = 14;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_manage_admin
            // 
            this.btn_manage_admin.Location = new System.Drawing.Point(632, 367);
            this.btn_manage_admin.Name = "btn_manage_admin";
            this.btn_manage_admin.Size = new System.Drawing.Size(143, 23);
            this.btn_manage_admin.TabIndex = 13;
            this.btn_manage_admin.Text = "Manage Admin";
            this.btn_manage_admin.UseVisualStyleBackColor = true;
            this.btn_manage_admin.Click += new System.EventHandler(this.btn_manage_admin_Click);
            // 
            // btn_manage_teacher
            // 
            this.btn_manage_teacher.Location = new System.Drawing.Point(632, 324);
            this.btn_manage_teacher.Name = "btn_manage_teacher";
            this.btn_manage_teacher.Size = new System.Drawing.Size(143, 23);
            this.btn_manage_teacher.TabIndex = 12;
            this.btn_manage_teacher.Text = "Manage Teacher";
            this.btn_manage_teacher.UseVisualStyleBackColor = true;
            this.btn_manage_teacher.Click += new System.EventHandler(this.btn_manage_teacher_Click);
            // 
            // btn_manage_student
            // 
            this.btn_manage_student.Location = new System.Drawing.Point(632, 410);
            this.btn_manage_student.Name = "btn_manage_student";
            this.btn_manage_student.Size = new System.Drawing.Size(143, 23);
            this.btn_manage_student.TabIndex = 11;
            this.btn_manage_student.Text = "Manage Student";
            this.btn_manage_student.UseVisualStyleBackColor = true;
            this.btn_manage_student.Click += new System.EventHandler(this.btn_manage_student_Click);
            // 
            // btn_group_by_admin
            // 
            this.btn_group_by_admin.Location = new System.Drawing.Point(25, 367);
            this.btn_group_by_admin.Name = "btn_group_by_admin";
            this.btn_group_by_admin.Size = new System.Drawing.Size(154, 23);
            this.btn_group_by_admin.TabIndex = 10;
            this.btn_group_by_admin.Text = "Group by Admin";
            this.btn_group_by_admin.UseVisualStyleBackColor = true;
            this.btn_group_by_admin.Click += new System.EventHandler(this.btn_group_by_admin_Click);
            // 
            // btn_group_by_teacher
            // 
            this.btn_group_by_teacher.Location = new System.Drawing.Point(25, 324);
            this.btn_group_by_teacher.Name = "btn_group_by_teacher";
            this.btn_group_by_teacher.Size = new System.Drawing.Size(154, 23);
            this.btn_group_by_teacher.TabIndex = 9;
            this.btn_group_by_teacher.Text = "Group by Teacher";
            this.btn_group_by_teacher.UseVisualStyleBackColor = true;
            this.btn_group_by_teacher.Click += new System.EventHandler(this.btn_group_by_teacher_Click);
            // 
            // btn_group_by_student
            // 
            this.btn_group_by_student.Location = new System.Drawing.Point(25, 410);
            this.btn_group_by_student.Name = "btn_group_by_student";
            this.btn_group_by_student.Size = new System.Drawing.Size(154, 23);
            this.btn_group_by_student.TabIndex = 8;
            this.btn_group_by_student.Text = "Group by Student";
            this.btn_group_by_student.UseVisualStyleBackColor = true;
            this.btn_group_by_student.Click += new System.EventHandler(this.btn_group_by_student_Click);
            // 
            // holderBindingSource
            // 
            this.holderBindingSource.DataMember = "Holder";
            this.holderBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // holderTableAdapter
            // 
            this.holderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HolderTableAdapter = this.holderTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DesktopInformationSystem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 285);
            this.dataGridView1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_manage_admin);
            this.Controls.Add(this.btn_manage_teacher);
            this.Controls.Add(this.btn_manage_student);
            this.Controls.Add(this.btn_group_by_admin);
            this.Controls.Add(this.btn_group_by_teacher);
            this.Controls.Add(this.btn_group_by_student);
            this.Name = "MainForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_manage_admin;
        private System.Windows.Forms.Button btn_manage_teacher;
        private System.Windows.Forms.Button btn_manage_student;
        private System.Windows.Forms.Button btn_group_by_admin;
        private System.Windows.Forms.Button btn_group_by_teacher;
        private System.Windows.Forms.Button btn_group_by_student;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource holderBindingSource;
        private Database1DataSetTableAdapters.HolderTableAdapter holderTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSet database1DataSet1;
        private Database1DataSet database1DataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}