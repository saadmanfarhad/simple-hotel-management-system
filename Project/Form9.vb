Public Class Form9

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project1DataSet.Guest_Info' table. You can move, or remove it, as needed.
        'Me.Guest_InfoTableAdapter.Fill(Me.Project1DataSet.Guest_Info)
        Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
        Dim cmd As OleDbCommand = New OleDbCommand()

        cmd.Connection = cn

        Dim q As String
        q = "select * from Guest_Info"

        cn.Open()
        cmd.CommandText = q
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)

        Dim dt As DataTable = New DataTable()
        da.Fill(dt)

        Guest_InfoDataGridView.DataSource = dt

        cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class