Imports Microsoft.Data.SqlClient

Public Class A_accessories
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

    Private Sub A_accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        DataGridView1.Columns("accessory_id").ReadOnly = True
        DataGridView1.Columns("accessory_name").ReadOnly = True
    End Sub
    Private Sub LoadDataIntoDataGridView()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM Accessories"
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
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim newValue As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim primaryKey As Object = DataGridView1.Rows(e.RowIndex).Cells("accessory_id").Value
        Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim query As String = $"UPDATE Accessories SET {columnName} = @NewValue WHERE accessory_id = @PrimaryKey"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NewValue", newValue)
                command.Parameters.AddWithValue("@PrimaryKey", primaryKey)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class