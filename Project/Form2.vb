Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form5.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        
        Try
            Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
            Dim cmd As OleDbCommand = New OleDbCommand()
            Dim t As String
            t = Now.ToLongTimeString
            Dim id As String
            id = Me.Employee_DetailTableAdapter1.EmployeeIDByName(Label2.Text)

            cmd.Connection = cn

            Dim q As String
            q = "update Login_Table set Logoff_Time=@Logoff where Employee_ID=@id"
            cmd.Parameters.AddWithValue("Logoff", t)
            cmd.Parameters.AddWithValue("employeeid", id)

            cmd.CommandText = q
            cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
        Form1.txtuser.Text = " "
        Form1.txtpass.Text = " "
        Form1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form10.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form13.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class