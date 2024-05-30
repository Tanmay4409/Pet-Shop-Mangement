Imports Microsoft.Data.SqlClient
Imports Mysqlx

Public Class A_customer
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim dataTable As New DataTable()
    Private Sub A_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        DataGridView1.Columns("ID").ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Successfully logged out")
        Admin_login.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Home_Admin.Show()
    End Sub
    Private Sub LoadDataIntoDataGridView()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM customerdata"
                Using adapter As New SqlDataAdapter(query, conn)
                    conn.Open()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim newValue As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim primaryKey As Object = DataGridView1.Rows(e.RowIndex).Cells("ID").Value
        Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim query As String = $"UPDATE customerdata SET {columnName} = @NewValue WHERE ID = @PrimaryKey"

        If (columnName = "Username" Or columnName = "Phone_no") Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Check if the new value for Username or Phone_no already exists in the table
                    Dim checkQuery As String = $"SELECT COUNT(*) FROM customerdata WHERE {columnName} = @NewValue"

                    Using checkCommand As New SqlCommand(checkQuery, connection)
                        checkCommand.Parameters.AddWithValue("@NewValue", newValue)
                        Dim count As Integer = CInt(checkCommand.ExecuteScalar())

                        If count > 0 Then
                            ' If the new value already exists in the table, show a message box and return without updating
                            MsgBox($"{columnName} '{newValue}' already exists.")
                            ReloadTableContents("customerdata", DataGridView1)
                            Return ' Exit the Sub
                        End If
                    End Using

                    ' If the new value doesn't exist, update the table
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@NewValue", newValue)
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKey)

                        command.ExecuteNonQuery()
                        ReloadTableContents("customerdata", DataGridView1)
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Cant have Empty fields,Please Provide some details")
                ReloadTableContents("customerdata", DataGridView1)
                Return
            End Try
        ElseIf (columnName = "Password") Then

            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@NewValue", newValue)
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKey)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                ' Reload the table contents after updating
                ReloadTableContents("customerdata", DataGridView1)
            Catch ex As Exception
                MsgBox("Must Have a Password")
                ReloadTableContents("customerdata", DataGridView1)
                Return
            End Try
        Else
            MsgBox("Error 101")
        End If


    End Sub
    Private Sub ReloadTableContents(tableName As String, dataGridView As DataGridView)
        Try
            Dim query As String = "SELECT * FROM " & tableName

            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dataGridView.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim primaryKey As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM customerdata WHERE ID = @PrimaryKey"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKey)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Remove the selected row from the DataGridView
                DataGridView1.Rows.Remove(selectedRow)
            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting the record: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

End Class