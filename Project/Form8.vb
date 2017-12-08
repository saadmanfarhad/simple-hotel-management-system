Public Class Form8

    Private Sub ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.ReservationBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ProjectDataSet)
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project1DataSet.Reservation' table. You can move, or remove it, as needed.

        Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
        Dim cmd As OleDbCommand = New OleDbCommand()

        cmd.Connection = cn

        Dim q As String
        q = "select * from Reservation"

        cn.Open()
        cmd.CommandText = q
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)

        Dim dt As DataTable = New DataTable()
        da.Fill(dt)

        ReservationDataGridView.DataSource = dt

        cn.Close()

        'Me.ReservationTableAdapter1.Fill(Me.Project1DataSet.Reservation)
        'Me.ReservationDataGridView.DataSource = Project1DataSet
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class