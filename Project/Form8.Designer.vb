<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.ProjectDataSet = New Project.ProjectDataSet()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter = New Project.ProjectDataSetTableAdapters.ReservationTableAdapter()
        Me.TableAdapterManager = New Project.ProjectDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Project1DataSet = New Project.Project1DataSet()
        Me.ReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter1 = New Project.Project1DataSetTableAdapters.ReservationTableAdapter()
        Me.ReservationDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.ProjectDataSet
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyTableAdapter = Nothing
        Me.TableAdapterManager.Department_ListTableAdapter = Nothing
        Me.TableAdapterManager.Employee_DetailTableAdapter = Nothing
        Me.TableAdapterManager.Guest_InfoTableAdapter = Nothing
        Me.TableAdapterManager.Item_DetailTableAdapter = Nothing
        Me.TableAdapterManager.Login_TableTableAdapter = Nothing
        Me.TableAdapterManager.MessageTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager.Room_DetailTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project.ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Project.My.Resources.Resources.back_button_png_hi
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(646, 603)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Reservation Information"
        '
        'Project1DataSet
        '
        Me.Project1DataSet.DataSetName = "Project1DataSet"
        Me.Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource1
        '
        Me.ReservationBindingSource1.DataMember = "Reservation"
        Me.ReservationBindingSource1.DataSource = Me.Project1DataSet
        '
        'ReservationTableAdapter1
        '
        Me.ReservationTableAdapter1.ClearBeforeFill = True
        '
        'ReservationDataGridView
        '
        Me.ReservationDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ReservationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationDataGridView.Location = New System.Drawing.Point(57, 216)
        Me.ReservationDataGridView.Name = "ReservationDataGridView"
        Me.ReservationDataGridView.Size = New System.Drawing.Size(878, 341)
        Me.ReservationDataGridView.TabIndex = 4
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 716)
        Me.Controls.Add(Me.ReservationDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource1, "Last Name", True))
        Me.Name = "Form8"
        Me.Text = "Reservation Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectDataSet As Project.ProjectDataSet
    Friend WithEvents ReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableAdapter As Project.ProjectDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents TableAdapterManager As Project.ProjectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Project1DataSet As Project.Project1DataSet
    Friend WithEvents ReservationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableAdapter1 As Project.Project1DataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents ReservationDataGridView As System.Windows.Forms.DataGridView
End Class
