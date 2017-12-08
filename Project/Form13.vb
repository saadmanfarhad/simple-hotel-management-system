Public Class Form13

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Project1DataSet.Reservation' table. You can move, or remove it, as needed.
        'Me.ReservationTableAdapter.Fill(Me.Project1DataSet.Reservation)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.ReservationTableAdapter.Fill(Me.Project1DataSet.Reservation)
        Me.ReservationBindingSource.Filter = "Dep_Date= '" + DateTimePicker1.Text + "'"

        Dim empty As Boolean
        empty = IsDataGridViewEmpty(DataGridView1)
        If empty Then
            MsgBox("Not Found")
        End If
    End Sub

    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    ' Check if the string only consists of spaces
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return isEmpty
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class