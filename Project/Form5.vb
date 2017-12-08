Public Class Form5
    Dim i As String
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button12.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button1.Text = "101"
        Button2.Text = "102"
        Button3.Text = "103"
        Button12.Text = "104"
        Button5.Text = "105"
        Button6.Text = "106"
        Button7.Text = "107"
        Button8.Text = "108"
        Button9.Text = "109"
        Button10.Text = "110"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button12.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button1.Text = "201"
        Button2.Text = "202"
        Button3.Text = "203"
        Button12.Text = "204"
        Button5.Text = "205"
        Button6.Text = "206"
        Button7.Text = "207"
        Button8.Text = "208"
        Button9.Text = "209"
        Button10.Text = "210"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button12.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button1.Text = "301"
        Button2.Text = "302"
        Button3.Text = "303"
        Button12.Text = "304"
        Button5.Text = "305"
        Button6.Text = "306"
        Button7.Text = "307"
        Button8.Text = "308"
        Button9.Text = "309"
        Button10.Text = "310"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button12.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button1.Text)
        Form7.TextBox1.Text = i
        Dim guestid As String = Me.Room_DetailTableAdapter1.RateByRoomNo(Button1.Text)
        If guestid Is Nothing Then
            Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button1.Text)
            Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button1.Text)
            Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button1.Text)
            Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button1.Text)
            Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button1.Text)
            'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button1.Text)
            Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button1.Text)
            Form7.Show()
        Else
            Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button1.Text)
            Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button1.Text)
            Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button1.Text)
            Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button1.Text)
            Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button1.Text)
            Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIdByRoomNo(Button1.Text)
            Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button1.Text)
            Form7.Show()
        End If
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button2.Text)
        Form7.TextBox1.Text = i
        Dim guestid As String = Me.Room_DetailTableAdapter1.RateByRoomNo(Button2.Text)
        If guestid Is Nothing Then
            Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button2.Text)
            Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button2.Text)
            Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button2.Text)
            Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button2.Text)
            Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button2.Text)
            'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button2.Text)
            Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button2.Text)
            Form7.Show()
        Else
            Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button2.Text)
            Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button2.Text)
            Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button2.Text)
            Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button2.Text)
            Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button2.Text)
            Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIdByRoomNo(Button2.Text)
            Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button2.Text)
            Form7.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button3.Text)
        Form7.TextBox1.Text = i
        Dim guestid As String = Me.Room_DetailTableAdapter1.RateByRoomNo(Button3.Text)
        If guestid Is Nothing Then
            Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button3.Text)
            Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button3.Text)
            Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button3.Text)
            Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button3.Text)
            Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button3.Text)
            'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button3.Text)
            Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button3.Text)
            Form7.Show()
        Else
            Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button3.Text)
            Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button3.Text)
            Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button3.Text)
            Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button3.Text)
            Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button3.Text)
            Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIdByRoomNo(Button3.Text)
            Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button3.Text)
            Form7.Show()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button12.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button12.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button12.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button12.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button12.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button12.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button12.Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button12.Text)
        Form7.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button5.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button5.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button5.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button5.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button5.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button5.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button5.Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button5.Text)
        Form7.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button6.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button6.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button6.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button6.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button6.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button6.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button6.Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button6.Text)
        Form7.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button7.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button7.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button7.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button7.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button7.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button7.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button7 .Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button7.Text)
        Form7.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button8.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button8.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button8.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button8.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button8.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button8.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button8.Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button8.Text)
        Form7.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button9.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button9.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button9.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button9.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button9.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button9.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button1.Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button9.Text)
        Form7.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        i = Me.Room_DetailTableAdapter1.RoomNoByRoomNo(Button1.Text)
        Form7.TextBox1.Text = i
        Form7.TextBox2.Text = Me.Room_DetailTableAdapter1.RoomTypeByRoomNo(Button10.Text)
        Form7.TextBox3.Text = Me.Room_DetailTableAdapter1.FloorByRoomNo(Button10.Text)
        Form7.TextBox4.Text = Me.Room_DetailTableAdapter1.RateByRoomNo(Button10.Text)
        Form7.TextBox5.Text = Me.Room_DetailTableAdapter1.DescriptionByRoomNo(Button10.Text)
        Form7.TextBox6.Text = Me.Room_DetailTableAdapter1.OccupancyByRoom(Button10.Text)
        'Form7.TextBox7.Text = Me.Room_DetailTableAdapter1.GuestIDByRoomNo(Button10.Text)
        Form7.TextBox8.Text = Me.Room_DetailTableAdapter1.AccomodationByRoomNo(Button10.Text)
        Form7.Show()
    End Sub
End Class