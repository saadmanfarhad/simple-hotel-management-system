Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
            Dim cmd As OleDbCommand = New OleDbCommand()
            Dim thisDate As Date
            thisDate = Today

            cmd.Connection = cn

            Dim q As String
            q = "insert into Item_Detail([Particulars],[Rate],[Item_Detail]) values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "')"

            cmd.CommandText = q
            cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

            MsgBox("Item Added")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class