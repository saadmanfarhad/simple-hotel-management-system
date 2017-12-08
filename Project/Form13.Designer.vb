<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RfolioNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArvDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArvTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialRequirmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofRoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofDaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForeignerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResvTakenByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeofPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project1DataSet = New Project.Project1DataSet()
        Me.ReservationTableAdapter = New Project.Project1DataSetTableAdapters.ReservationTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RfolioNoDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.ArvDateDataGridViewTextBoxColumn, Me.ArvTimeDataGridViewTextBoxColumn, Me.DepDateDataGridViewTextBoxColumn, Me.DeptTimeDataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.SpecialRequirmentsDataGridViewTextBoxColumn, Me.NoofRoomDataGridViewTextBoxColumn, Me.NoofDaysDataGridViewTextBoxColumn, Me.ConfirmationDataGridViewTextBoxColumn, Me.ForeignerDataGridViewTextBoxColumn, Me.VIPDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ResvTakenByDataGridViewTextBoxColumn, Me.ModeofPaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(45, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(510, 153)
        Me.DataGridView1.TabIndex = 2
        '
        'RfolioNoDataGridViewTextBoxColumn
        '
        Me.RfolioNoDataGridViewTextBoxColumn.DataPropertyName = "Rfolio_No"
        Me.RfolioNoDataGridViewTextBoxColumn.HeaderText = "Rfolio_No"
        Me.RfolioNoDataGridViewTextBoxColumn.Name = "RfolioNoDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'ArvDateDataGridViewTextBoxColumn
        '
        Me.ArvDateDataGridViewTextBoxColumn.DataPropertyName = "Arv_Date"
        Me.ArvDateDataGridViewTextBoxColumn.HeaderText = "Arv_Date"
        Me.ArvDateDataGridViewTextBoxColumn.Name = "ArvDateDataGridViewTextBoxColumn"
        '
        'ArvTimeDataGridViewTextBoxColumn
        '
        Me.ArvTimeDataGridViewTextBoxColumn.DataPropertyName = "Arv_Time"
        Me.ArvTimeDataGridViewTextBoxColumn.HeaderText = "Arv_Time"
        Me.ArvTimeDataGridViewTextBoxColumn.Name = "ArvTimeDataGridViewTextBoxColumn"
        '
        'DepDateDataGridViewTextBoxColumn
        '
        Me.DepDateDataGridViewTextBoxColumn.DataPropertyName = "Dep_Date"
        Me.DepDateDataGridViewTextBoxColumn.HeaderText = "Dep_Date"
        Me.DepDateDataGridViewTextBoxColumn.Name = "DepDateDataGridViewTextBoxColumn"
        '
        'DeptTimeDataGridViewTextBoxColumn
        '
        Me.DeptTimeDataGridViewTextBoxColumn.DataPropertyName = "Dept_Time"
        Me.DeptTimeDataGridViewTextBoxColumn.HeaderText = "Dept_Time"
        Me.DeptTimeDataGridViewTextBoxColumn.Name = "DeptTimeDataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'SpecialRequirmentsDataGridViewTextBoxColumn
        '
        Me.SpecialRequirmentsDataGridViewTextBoxColumn.DataPropertyName = "Special_Requirments"
        Me.SpecialRequirmentsDataGridViewTextBoxColumn.HeaderText = "Special_Requirments"
        Me.SpecialRequirmentsDataGridViewTextBoxColumn.Name = "SpecialRequirmentsDataGridViewTextBoxColumn"
        '
        'NoofRoomDataGridViewTextBoxColumn
        '
        Me.NoofRoomDataGridViewTextBoxColumn.DataPropertyName = "No_of_Room"
        Me.NoofRoomDataGridViewTextBoxColumn.HeaderText = "No_of_Room"
        Me.NoofRoomDataGridViewTextBoxColumn.Name = "NoofRoomDataGridViewTextBoxColumn"
        '
        'NoofDaysDataGridViewTextBoxColumn
        '
        Me.NoofDaysDataGridViewTextBoxColumn.DataPropertyName = "No_of_Days"
        Me.NoofDaysDataGridViewTextBoxColumn.HeaderText = "No_of_Days"
        Me.NoofDaysDataGridViewTextBoxColumn.Name = "NoofDaysDataGridViewTextBoxColumn"
        '
        'ConfirmationDataGridViewTextBoxColumn
        '
        Me.ConfirmationDataGridViewTextBoxColumn.DataPropertyName = "Confirmation"
        Me.ConfirmationDataGridViewTextBoxColumn.HeaderText = "Confirmation"
        Me.ConfirmationDataGridViewTextBoxColumn.Name = "ConfirmationDataGridViewTextBoxColumn"
        '
        'ForeignerDataGridViewTextBoxColumn
        '
        Me.ForeignerDataGridViewTextBoxColumn.DataPropertyName = "Foreigner"
        Me.ForeignerDataGridViewTextBoxColumn.HeaderText = "Foreigner"
        Me.ForeignerDataGridViewTextBoxColumn.Name = "ForeignerDataGridViewTextBoxColumn"
        '
        'VIPDataGridViewTextBoxColumn
        '
        Me.VIPDataGridViewTextBoxColumn.DataPropertyName = "VIP"
        Me.VIPDataGridViewTextBoxColumn.HeaderText = "VIP"
        Me.VIPDataGridViewTextBoxColumn.Name = "VIPDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ResvTakenByDataGridViewTextBoxColumn
        '
        Me.ResvTakenByDataGridViewTextBoxColumn.DataPropertyName = "Resv_Taken_By"
        Me.ResvTakenByDataGridViewTextBoxColumn.HeaderText = "Resv_Taken_By"
        Me.ResvTakenByDataGridViewTextBoxColumn.Name = "ResvTakenByDataGridViewTextBoxColumn"
        '
        'ModeofPaymentDataGridViewTextBoxColumn
        '
        Me.ModeofPaymentDataGridViewTextBoxColumn.DataPropertyName = "Mode_of_Payment"
        Me.ModeofPaymentDataGridViewTextBoxColumn.HeaderText = "Mode_of_Payment"
        Me.ModeofPaymentDataGridViewTextBoxColumn.Name = "ModeofPaymentDataGridViewTextBoxColumn"
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.Project1DataSet
        '
        'Project1DataSet
        '
        Me.Project1DataSet.DataSetName = "Project1DataSet"
        Me.Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(202, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Project.My.Resources.Resources.back_button_png_hi
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(254, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Check-Out List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Choose Date"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.checkinout
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(603, 407)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form13"
        Me.Text = "Check Out"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Project1DataSet As Project.Project1DataSet
    Friend WithEvents ReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableAdapter As Project.Project1DataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RfolioNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArvDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArvTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpecialRequirmentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoofRoomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoofDaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfirmationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForeignerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResvTakenByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeofPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
