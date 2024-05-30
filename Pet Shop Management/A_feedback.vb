Imports Microsoft.Data.SqlClient

Public Class A_feedback
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim dataTable As New DataTable()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Successfully logged out")
        Admin_login.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Home_Admin.Show()
    End Sub

    Private Sub A_feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()

    End Sub
    Private Sub LoadDataIntoDataGridView()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM Feedback"
                Using adapter As New SqlDataAdapter(query, conn)
                    conn.Open()
                    adapter.Fill(DataTable)
                    DataGridView1.DataSource = DataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim feedback As String = Convert.ToString(selectedRow.Cells("feedbacks").Value)

                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()
                        Dim query As String = "DELETE FROM Feedback WHERE feedbacks = @Feedback"
                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@Feedback", feedback)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Remove the selected row from the DataGridView
                    DataGridView1.Rows.Remove(selectedRow)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting the feedback: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Please select a row to delete.")
            End If
        End If
    End Sub
End Class