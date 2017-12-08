<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guest_InfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.GuestFolioNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneResDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneOfficeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassportNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceofIssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofIssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisaNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeofVisitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactThroughDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Project1DataSet = New Project.Project1DataSet()
        Me.Guest_InfoTableAdapter = New Project.Project1DataSetTableAdapters.Guest_InfoTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Guest_InfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Information"
        '
        'Guest_InfoDataGridView
        '
        Me.Guest_InfoDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guest_InfoDataGridView.AutoGenerateColumns = False
        Me.Guest_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guest_InfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuestFolioNoDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneResDataGridViewTextBoxColumn, Me.PhoneOfficeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.OccupationDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.PassportNoDataGridViewTextBoxColumn, Me.PlaceofIssueDataGridViewTextBoxColumn, Me.DateofIssueDataGridViewTextBoxColumn, Me.VisaNoDataGridViewTextBoxColumn, Me.PurposeofVisitDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.ContactThroughDataGridViewTextBoxColumn})
        Me.Guest_InfoDataGridView.DataSource = Me.GuestInfoBindingSource
        Me.Guest_InfoDataGridView.Location = New System.Drawing.Point(81, 160)
        Me.Guest_InfoDataGridView.Name = "Guest_InfoDataGridView"
        Me.Guest_InfoDataGridView.Size = New System.Drawing.Size(766, 253)
        Me.Guest_InfoDataGridView.TabIndex = 1
        '
        'GuestFolioNoDataGridViewTextBoxColumn
        '
        Me.GuestFolioNoDataGridViewTextBoxColumn.DataPropertyName = "Guest_Folio_No"
        Me.GuestFolioNoDataGridViewTextBoxColumn.HeaderText = "Guest_Folio_No"
        Me.GuestFolioNoDataGridViewTextBoxColumn.Name = "GuestFolioNoDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhoneResDataGridViewTextBoxColumn
        '
        Me.PhoneResDataGridViewTextBoxColumn.DataPropertyName = "Phone_Res"
        Me.PhoneResDataGridViewTextBoxColumn.HeaderText = "Phone_Res"
        Me.PhoneResDataGridViewTextBoxColumn.Name = "PhoneResDataGridViewTextBoxColumn"
        '
        'PhoneOfficeDataGridViewTextBoxColumn
        '
        Me.PhoneOfficeDataGridViewTextBoxColumn.DataPropertyName = "Phone_Office"
        Me.PhoneOfficeDataGridViewTextBoxColumn.HeaderText = "Phone_Office"
        Me.PhoneOfficeDataGridViewTextBoxColumn.Name = "PhoneOfficeDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'PassportNoDataGridViewTextBoxColumn
        '
        Me.PassportNoDataGridViewTextBoxColumn.DataPropertyName = "Passport_No"
        Me.PassportNoDataGridViewTextBoxColumn.HeaderText = "Passport_No"
        Me.PassportNoDataGridViewTextBoxColumn.Name = "PassportNoDataGridViewTextBoxColumn"
        '
        'PlaceofIssueDataGridViewTextBoxColumn
        '
        Me.PlaceofIssueDataGridViewTextBoxColumn.DataPropertyName = "Place_of_Issue"
        Me.PlaceofIssueDataGridViewTextBoxColumn.HeaderText = "Place_of_Issue"
        Me.PlaceofIssueDataGridViewTextBoxColumn.Name = "PlaceofIssueDataGridViewTextBoxColumn"
        '
        'DateofIssueDataGridViewTextBoxColumn
        '
        Me.DateofIssueDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Issue"
        Me.DateofIssueDataGridViewTextBoxColumn.HeaderText = "Date_of_Issue"
        Me.DateofIssueDataGridViewTextBoxColumn.Name = "DateofIssueDataGridViewTextBoxColumn"
        '
        'VisaNoDataGridViewTextBoxColumn
        '
        Me.VisaNoDataGridViewTextBoxColumn.DataPropertyName = "Visa_No"
        Me.VisaNoDataGridViewTextBoxColumn.HeaderText = "Visa_No"
        Me.VisaNoDataGridViewTextBoxColumn.Name = "VisaNoDataGridViewTextBoxColumn"
        '
        'PurposeofVisitDataGridViewTextBoxColumn
        '
        Me.PurposeofVisitDataGridViewTextBoxColumn.DataPropertyName = "Purpose_of_Visit"
        Me.PurposeofVisitDataGridViewTextBoxColumn.HeaderText = "Purpose_of_Visit"
        Me.PurposeofVisitDataGridViewTextBoxColumn.Name = "PurposeofVisitDataGridViewTextBoxColumn"
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "Company_Name"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "Company_Name"
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        '
        'ContactThroughDataGridViewTextBoxColumn
        '
        Me.ContactThroughDataGridViewTextBoxColumn.DataPropertyName = "Contact_Through"
        Me.ContactThroughDataGridViewTextBoxColumn.HeaderText = "Contact_Through"
        Me.ContactThroughDataGridViewTextBoxColumn.Name = "ContactThroughDataGridViewTextBoxColumn"
        '
        'GuestInfoBindingSource
        '
        Me.GuestInfoBindingSource.DataMember = "Guest_Info"
        Me.GuestInfoBindingSource.DataSource = Me.Project1DataSet
        '
        'Project1DataSet
        '
        Me.Project1DataSet.DataSetName = "Project1DataSet"
        Me.Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guest_InfoTableAdapter
        '
        Me.Guest_InfoTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Project.My.Resources.Resources.back_button_png_hi
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(399, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.White_Simple_Design_Background
        Me.ClientSize = New System.Drawing.Size(922, 502)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Guest_InfoDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Guest Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Guest_InfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guest_InfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Project1DataSet As Project.Project1DataSet
    Friend WithEvents GuestInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Guest_InfoTableAdapter As Project.Project1DataSetTableAdapters.Guest_InfoTableAdapter
    Friend WithEvents GuestFolioNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneResDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneOfficeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassportNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceofIssueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofIssueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisaNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurposeofVisitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactThroughDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
