Public Class Form4



    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
            Dim cmd As OleDbCommand = New OleDbCommand()
            cmd.Connection = cn

            Dim q As String

            q = "insert into Guest_Info([First_Name],[Last_Name],[Address],[Phone_Res],[Phone_Office],[Email],[City],[State],[Nationality],[Occupation],[DOB],[Passport_No],[Place_of_Issue],[Date_of_Issue],[Visa_No],[Purpose_of_Visit],[Company_Name],[Contact_Through])values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox14.Text + "','" + TextBox9.Text + "','" + TextBox15.Text + "','" + DateTimePicker1.Text + "','" + TextBox16.Text + "','" + TextBox11.Text + "','" + DateTimePicker2.Text + "','" + TextBox12.Text + "','" + TextBox18.Text + "','" + TextBox13.Text + "','" + TextBox19.Text + "')"

            cmd.CommandText = q
            cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

            MsgBox("Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim firstname As String = Me.ReservationTableAdapter.FirstNameByFirstNameLastName(TextBox2.Text, TextBox3.Text)
        If firstname Is Nothing Then
            MsgBox("Not Found")

        Else
            TextBox4.Text = Me.ReservationTableAdapter.AddressByLastNameFirstName(TextBox2.Text, TextBox3.Text)
            TextBox20.Text = Me.ReservationTableAdapter.ArvDateByFirstNameLastName(TextBox2.Text, TextBox3.Text)
            TextBox22.Text = Me.ReservationTableAdapter.ArvTimeByLastNameFirstName(TextBox2.Text, TextBox3.Text)
            TextBox21.Text = Me.ReservationTableAdapter.DepDateByLastNameFirstName(TextBox2.Text, TextBox3.Text)
            TextBox23.Text = Me.ReservationTableAdapter.DepTimeByLastNameFirstName(TextBox2.Text, TextBox3.Text)
            ComboBox1.Text = Me.ReservationTableAdapter.RoomTypeByLastNameFirstName(TextBox2.Text, TextBox3.Text)
            TextBox24.Text = Me.ReservationTableAdapter.SpecialRequirementsByLastNameFirstName(TextBox2.Text, TextBox3.Text)

        End If
    End Sub

    Private Sub ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Project1DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project1DataSet.Guest_Info' table. You can move, or remove it, as needed.
        'Me.Guest_InfoTableAdapter.Fill(Me.Project1DataSet.Guest_Info)
        'TODO: This line of code loads data into the 'Project1DataSet.Reservation' table. You can move, or remove it, as needed.
        'Me.ReservationTableAdapter.Fill(Me.Project1DataSet.Reservation)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim guestid As Integer = Me.Guest_InfoTableAdapter.GuestIdByLastNameFirstName(TextBox2.Text, TextBox3.Text)
        Dim accomodation As String = "No"
        Dim occupancy As String = "Yes"

        'Dim rId As Integer

        'Integer.TryParse(ComboBox1.Text, rId)
        Try
            Dim cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\Visual Studio 2013\Projects\Project\Project\Project1.accdb;Persist Security Info=False")
            Dim cmd As OleDbCommand = New OleDbCommand()
            cmd.Connection = cn

            Dim r As String
            'r = "UPDATE Room_Info SET Occupancy=" & _
            '   "'" & occupancy & _
            '   "' WHERE Room_No=" & ComboBox1.Text & " ;  "
            Dim roomno As String
            roomno = Convert.ToInt32(ComboBox1.Text)

            r = "update Room_Detail set Occupancy=@occupancy,Accomodation=@accomodation,Guest_folio_ID=@guestid where Room_No=@roomNo"

            cmd.Parameters.AddWithValue("occupancy", occupancy)
            cmd.Parameters.AddWithValue("accomodation", accomodation)
            cmd.Parameters.AddWithValue("guestid", guestid)
            cmd.Parameters.AddWithValue("roomNo", roomno)

            cmd.CommandText = r
            cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()
            MsgBox("Room Allocated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class