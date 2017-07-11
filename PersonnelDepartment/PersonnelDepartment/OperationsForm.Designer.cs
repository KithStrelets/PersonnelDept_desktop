namespace PersonnelDepartment
{
    partial class OperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsForm));
            this.plusPersonBtn = new System.Windows.Forms.Button();
            this.minusPersonBtn = new System.Windows.Forms.Button();
            this.editPersonBtn = new System.Windows.Forms.Button();
            this.jobBtn = new System.Windows.Forms.Button();
            this.DeptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadData = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.infTable = new System.Windows.Forms.DataGridView();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marriedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkjobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isfiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkworkerscheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new PersonnelDepartment.AppData();
            this.personList = new System.Windows.Forms.GroupBox();
            this.personTableAdapter = new PersonnelDepartment.AppDataTableAdapters.personTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.personList.SuspendLayout();
            this.SuspendLayout();
            // 
            // plusPersonBtn
            // 
            this.plusPersonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusPersonBtn.BackgroundImage")));
            this.plusPersonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plusPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusPersonBtn.Location = new System.Drawing.Point(0, -2);
            this.plusPersonBtn.Name = "plusPersonBtn";
            this.plusPersonBtn.Size = new System.Drawing.Size(50, 40);
            this.plusPersonBtn.TabIndex = 0;
            this.plusPersonBtn.UseVisualStyleBackColor = true;
            this.plusPersonBtn.Click += new System.EventHandler(this.plusPersonBtn_Click);
            // 
            // minusPersonBtn
            // 
            this.minusPersonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusPersonBtn.BackgroundImage")));
            this.minusPersonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusPersonBtn.Location = new System.Drawing.Point(49, -2);
            this.minusPersonBtn.Name = "minusPersonBtn";
            this.minusPersonBtn.Size = new System.Drawing.Size(50, 40);
            this.minusPersonBtn.TabIndex = 1;
            this.minusPersonBtn.UseVisualStyleBackColor = true;
            this.minusPersonBtn.Click += new System.EventHandler(this.minusPersonBtn_Click);
            // 
            // editPersonBtn
            // 
            this.editPersonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editPersonBtn.BackgroundImage")));
            this.editPersonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editPersonBtn.Location = new System.Drawing.Point(98, -2);
            this.editPersonBtn.Name = "editPersonBtn";
            this.editPersonBtn.Size = new System.Drawing.Size(50, 40);
            this.editPersonBtn.TabIndex = 1;
            this.editPersonBtn.UseVisualStyleBackColor = true;
            this.editPersonBtn.Click += new System.EventHandler(this.editPersonBtn_Click);
            // 
            // jobBtn
            // 
            this.jobBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jobBtn.BackgroundImage")));
            this.jobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobBtn.Location = new System.Drawing.Point(210, -2);
            this.jobBtn.Name = "jobBtn";
            this.jobBtn.Size = new System.Drawing.Size(50, 40);
            this.jobBtn.TabIndex = 3;
            this.jobBtn.UseVisualStyleBackColor = true;
            this.jobBtn.Click += new System.EventHandler(this.jobBtn_Click);
            // 
            // DeptBtn
            // 
            this.DeptBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeptBtn.BackgroundImage")));
            this.DeptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeptBtn.Location = new System.Drawing.Point(154, -2);
            this.DeptBtn.Name = "DeptBtn";
            this.DeptBtn.Size = new System.Drawing.Size(50, 40);
            this.DeptBtn.TabIndex = 2;
            this.DeptBtn.UseVisualStyleBackColor = true;
            this.DeptBtn.Click += new System.EventHandler(this.DeptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reloadData);
            this.panel1.Controls.Add(this.reportBtn);
            this.panel1.Controls.Add(this.plusPersonBtn);
            this.panel1.Controls.Add(this.minusPersonBtn);
            this.panel1.Controls.Add(this.jobBtn);
            this.panel1.Controls.Add(this.editPersonBtn);
            this.panel1.Controls.Add(this.DeptBtn);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 42);
            this.panel1.TabIndex = 5;
            // 
            // reloadData
            // 
            this.reloadData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloadData.BackgroundImage")));
            this.reloadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reloadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadData.Location = new System.Drawing.Point(322, -2);
            this.reloadData.Name = "reloadData";
            this.reloadData.Size = new System.Drawing.Size(50, 40);
            this.reloadData.TabIndex = 5;
            this.reloadData.UseVisualStyleBackColor = true;
            this.reloadData.Click += new System.EventHandler(this.OperationsForm_Load);
            // 
            // reportBtn
            // 
            this.reportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportBtn.BackgroundImage")));
            this.reportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportBtn.Location = new System.Drawing.Point(266, -2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(50, 40);
            this.reportBtn.TabIndex = 5;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // infTable
            // 
            this.infTable.AutoGenerateColumns = false;
            this.infTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersonDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.marriedDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.fkdepartmentDataGridViewTextBoxColumn,
            this.fkjobDataGridViewTextBoxColumn,
            this.isfiredDataGridViewTextBoxColumn,
            this.archiveDataGridViewTextBoxColumn,
            this.fkworkerscheduleDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.infTable.DataSource = this.personBindingSource;
            this.infTable.Location = new System.Drawing.Point(2, 19);
            this.infTable.Name = "infTable";
            this.infTable.ReadOnly = true;
            this.infTable.Size = new System.Drawing.Size(1346, 483);
            this.infTable.TabIndex = 6;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "idperson";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            this.idpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marriedDataGridViewTextBoxColumn
            // 
            this.marriedDataGridViewTextBoxColumn.DataPropertyName = "married";
            this.marriedDataGridViewTextBoxColumn.HeaderText = "Женат/замужем";
            this.marriedDataGridViewTextBoxColumn.Name = "marriedDataGridViewTextBoxColumn";
            this.marriedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkdepartmentDataGridViewTextBoxColumn
            // 
            this.fkdepartmentDataGridViewTextBoxColumn.DataPropertyName = "fk_department";
            this.fkdepartmentDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.fkdepartmentDataGridViewTextBoxColumn.Name = "fkdepartmentDataGridViewTextBoxColumn";
            this.fkdepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkjobDataGridViewTextBoxColumn
            // 
            this.fkjobDataGridViewTextBoxColumn.DataPropertyName = "fk_job";
            this.fkjobDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.fkjobDataGridViewTextBoxColumn.Name = "fkjobDataGridViewTextBoxColumn";
            this.fkjobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isfiredDataGridViewTextBoxColumn
            // 
            this.isfiredDataGridViewTextBoxColumn.DataPropertyName = "isfired";
            this.isfiredDataGridViewTextBoxColumn.HeaderText = "Уволен";
            this.isfiredDataGridViewTextBoxColumn.Name = "isfiredDataGridViewTextBoxColumn";
            this.isfiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // archiveDataGridViewTextBoxColumn
            // 
            this.archiveDataGridViewTextBoxColumn.DataPropertyName = "archive";
            this.archiveDataGridViewTextBoxColumn.HeaderText = "Архивные данные";
            this.archiveDataGridViewTextBoxColumn.Name = "archiveDataGridViewTextBoxColumn";
            this.archiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkworkerscheduleDataGridViewTextBoxColumn
            // 
            this.fkworkerscheduleDataGridViewTextBoxColumn.DataPropertyName = "fk_workerschedule";
            this.fkworkerscheduleDataGridViewTextBoxColumn.HeaderText = "Расписание";
            this.fkworkerscheduleDataGridViewTextBoxColumn.Name = "fkworkerscheduleDataGridViewTextBoxColumn";
            this.fkworkerscheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            this.personBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personList
            // 
            this.personList.Controls.Add(this.infTable);
            this.personList.Location = new System.Drawing.Point(-2, 42);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(1357, 511);
            this.personList.TabIndex = 7;
            this.personList.TabStop = false;
            this.personList.Text = "Список сотрудников";
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.OperationsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.personList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plusPersonBtn;
        private System.Windows.Forms.Button minusPersonBtn;
        private System.Windows.Forms.Button editPersonBtn;
        private System.Windows.Forms.Button jobBtn;
        private System.Windows.Forms.Button DeptBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView infTable;
        private System.Windows.Forms.GroupBox personList;
        private System.Windows.Forms.Button reportBtn;
        private AppData appData;
        private System.Windows.Forms.BindingSource personBindingSource;
        private AppDataTableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marriedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkjobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isfiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkworkerscheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button reloadData;
    }
}