namespace ADOSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label aythorLabel;
            System.Windows.Forms.Label memoLabel;
            this.infosys202031DataSet = new ADOSample.infosys202031DataSet();
            this.memoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoTableTableAdapter = new ADOSample.infosys202031DataSetTableAdapters.memoTableTableAdapter();
            this.tableAdapterManager = new ADOSample.infosys202031DataSetTableAdapters.TableAdapterManager();
            this.memoTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.memoTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aythorTextBox = new System.Windows.Forms.TextBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.memoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            aythorLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202031DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingNavigator)).BeginInit();
            this.memoTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infosys202031DataSet
            // 
            this.infosys202031DataSet.DataSetName = "infosys202031DataSet";
            this.infosys202031DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoTableBindingSource
            // 
            this.memoTableBindingSource.DataMember = "memoTable";
            this.memoTableBindingSource.DataSource = this.infosys202031DataSet;
            // 
            // memoTableTableAdapter
            // 
            this.memoTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.memoTableTableAdapter = this.memoTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADOSample.infosys202031DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memoTableBindingNavigator
            // 
            this.memoTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memoTableBindingNavigator.BindingSource = this.memoTableBindingSource;
            this.memoTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memoTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memoTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.memoTableBindingNavigatorSaveItem});
            this.memoTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memoTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memoTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memoTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memoTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memoTableBindingNavigator.Name = "memoTableBindingNavigator";
            this.memoTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memoTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.memoTableBindingNavigator.TabIndex = 0;
            this.memoTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // memoTableBindingNavigatorSaveItem
            // 
            this.memoTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memoTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memoTableBindingNavigatorSaveItem.Image")));
            this.memoTableBindingNavigatorSaveItem.Name = "memoTableBindingNavigatorSaveItem";
            this.memoTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.memoTableBindingNavigatorSaveItem.Text = "データの保存";
            this.memoTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.memoTableBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(45, 68);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 12);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(92, 68);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 19);
            this.idTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(45, 94);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 12);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoTableBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(92, 90);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // aythorLabel
            // 
            aythorLabel.AutoSize = true;
            aythorLabel.Location = new System.Drawing.Point(45, 118);
            aythorLabel.Name = "aythorLabel";
            aythorLabel.Size = new System.Drawing.Size(41, 12);
            aythorLabel.TabIndex = 5;
            aythorLabel.Text = "Aythor:";
            // 
            // aythorTextBox
            // 
            this.aythorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "Aythor", true));
            this.aythorTextBox.Location = new System.Drawing.Point(92, 115);
            this.aythorTextBox.Name = "aythorTextBox";
            this.aythorTextBox.Size = new System.Drawing.Size(200, 19);
            this.aythorTextBox.TabIndex = 6;
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(45, 143);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(37, 12);
            memoLabel.TabIndex = 7;
            memoLabel.Text = "Memo:";
            // 
            // memoTextBox
            // 
            this.memoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "Memo", true));
            this.memoTextBox.Location = new System.Drawing.Point(92, 140);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(200, 19);
            this.memoTextBox.TabIndex = 8;
            // 
            // memoTableDataGridView
            // 
            this.memoTableDataGridView.AutoGenerateColumns = false;
            this.memoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.memoTableDataGridView.DataSource = this.memoTableBindingSource;
            this.memoTableDataGridView.Location = new System.Drawing.Point(47, 209);
            this.memoTableDataGridView.Name = "memoTableDataGridView";
            this.memoTableDataGridView.RowTemplate.Height = 21;
            this.memoTableDataGridView.Size = new System.Drawing.Size(300, 220);
            this.memoTableDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aythor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aythor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "接続";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memoTableDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(aythorLabel);
            this.Controls.Add(this.aythorTextBox);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.memoTableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202031DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingNavigator)).EndInit();
            this.memoTableBindingNavigator.ResumeLayout(false);
            this.memoTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202031DataSet infosys202031DataSet;
        private System.Windows.Forms.BindingSource memoTableBindingSource;
        private infosys202031DataSetTableAdapters.memoTableTableAdapter memoTableTableAdapter;
        private infosys202031DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memoTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton memoTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox aythorTextBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.DataGridView memoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

