<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ItemDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.Project1DataSet = New Project.Project1DataSet()
        Me.ItemDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item_DetailTableAdapter = New Project.Project1DataSetTableAdapters.Item_DetailTableAdapter()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ItemDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemDetailDataGridView
        '
        Me.ItemDetailDataGridView.AutoGenerateColumns = False
        Me.ItemDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.ParticularsDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.ItemDetailDataGridViewTextBoxColumn})
        Me.ItemDetailDataGridView.DataSource = Me.ItemDetailBindingSource
        Me.ItemDetailDataGridView.Location = New System.Drawing.Point(95, 146)
        Me.ItemDetailDataGridView.Name = "ItemDetailDataGridView"
        Me.ItemDetailDataGridView.Size = New System.Drawing.Size(442, 150)
        Me.ItemDetailDataGridView.TabIndex = 0
        '
        'Project1DataSet
        '
        Me.Project1DataSet.DataSetName = "Project1DataSet"
        Me.Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemDetailBindingSource
        '
        Me.ItemDetailBindingSource.DataMember = "Item_Detail"
        Me.ItemDetailBindingSource.DataSource = Me.Project1DataSet
        '
        'Item_DetailTableAdapter
        '
        Me.Item_DetailTableAdapter.ClearBeforeFill = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "Item_Code"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "Item_Code"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        '
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        '
        'ItemDetailDataGridViewTextBoxColumn
        '
        Me.ItemDetailDataGridViewTextBoxColumn.DataPropertyName = "Item_Detail"
        Me.ItemDetailDataGridViewTextBoxColumn.HeaderText = "Item_Detail"
        Me.ItemDetailDataGridViewTextBoxColumn.Name = "ItemDetailDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item List"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Project.My.Resources.Resources.back_button_png_hi
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(269, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.item_details
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(606, 381)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemDetailDataGridView)
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.ItemDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Project1DataSet As Project.Project1DataSet
    Friend WithEvents ItemDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Item_DetailTableAdapter As Project.Project1DataSetTableAdapters.Item_DetailTableAdapter
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDetailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
