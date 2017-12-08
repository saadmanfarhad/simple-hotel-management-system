Public Class Form1

    Private Sub cmdlog_Click(sender As Object, e As EventArgs) Handles cmdlog.Click
        Dim login = Me.Employee_DetailTableAdapter1.NamePasswordString(txtuser.Text, txtpass.Text)
        
        If login Is Nothing Then
            MsgBox("Incorrect Username or Password")
            txtpass.Text = ""
            txtuser.Text = ""
        Else
            Try
                Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
                Dim cmd As OleDbCommand = New OleDbCommand()
                Dim id As String
                id = Me.Employee_DetailTableAdapter1.EmployeeIDByName(txtuser.Text)
                Dim t As String
                t = Now.ToLongTimeString

                cmd.Connection = cn

                Dim q As String
                q = "insert into Login_Table([Employee_ID],[Login_Time]) values('" + id + "','" + t + "')"

                cmd.CommandText = q
                cn.Open()
                cmd.ExecuteNonQuery()

                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Welcome")
            Form2.Label2.Text = txtuser.Text
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
