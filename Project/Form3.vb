Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.Reservation' table. You can move, or remove it, as needed.
        'Me.ReservationTableAdapter.Fill(Me.ProjectDataSet.Reservation)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        Try
            Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
            Dim cmd As OleDbCommand = New OleDbCommand()
            Dim thisDate As Date
            thisDate = Today

            cmd.Connection = cn

            Dim q As String
            q = "insert into Reservation([Last Name],[First Name],[Arv_Date],[Arv_Time],[Dep_Date],[Dept_Time],[Room_Type],[Special_Requirments],[No_of_Room],[No_of_Days],[Confirmation],[Foreigner],[VIP],[Address],[Date],[Resv_Taken_By],[Mode_of_Payment]) values('" + TextBox3.Text + "','" + TextBox2.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "','" + DateTimePicker4.Text + "','" + DateTimePicker3.Text + "','" + ComboBox1.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "','" + TextBox7.Text + "','" + ComboBox4.Text + "','" + ComboBox6.Text + "','" + ComboBox5.Text + "','" + TextBox9.Text + "','" + Today + "','" + TextBox10.Text + "','" + ComboBox2.Text + "')"

            cmd.CommandText = q
            cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

            MsgBox("Submission Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = " "
        TextBox2.Text = " "
        ComboBox1.Text = " "
        TextBox6.Text = " "
        TextBox8.Text = " "
        TextBox7.Text = " "
        ComboBox4.Text = " "
        ComboBox6.Text = " "
        ComboBox5.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        ComboBox2.Text = " "
    End Sub
End Class