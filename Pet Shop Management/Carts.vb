Imports System.ComponentModel.Design
Imports System.Runtime.ExceptionServices
Imports Microsoft.Data.SqlClient
Imports Mysqlx

Public Class Carts
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim dataTable As New DataTable()

    Private Sub Carts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView("SELECT * FROM Cart2", DataGridView1)
        LoadDataIntoDataGridView("SELECT * FROM Cart1", DataGridView2)
        DataGridView1.Columns("accessory_name").ReadOnly = True
        DataGridView1.Columns("Price").ReadOnly = True
        DataGridView2.Columns("Breed").ReadOnly = True
        DataGridView2.Columns("Price").ReadOnly = True
    End Sub
    Private Sub LoadDataIntoDataGridView(query As String, dataGridView As DataGridView)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dataGridView.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("You have been successfully logged out")
        Login_Page.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tableName As String = "Cart2"
        DeleteTableContents(tableName)
        ReloadTableContents("Cart2", DataGridView1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tableName As String = "Cart1"
        DeleteTableContents(tableName)
        ReloadTableContents("Cart1", DataGridView2)
    End Sub
    Private Sub DeleteTableContents(tableName As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM " & tableName
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()

                MessageBox.Show("Table contents deleted successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReloadTableContents("Cart2", DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReloadTableContents("Cart1", DataGridView2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CreateAndPopulateCart3()
    End Sub
    Private Sub CreateAndPopulateCart3()
        ' Create a SqlConnection
        Using connection As New SqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Check if Cart3 table exists and drop it if it does
            Dim checkTableQuery As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cart3'"
            Dim checkTableCommand As New SqlCommand(checkTableQuery, connection)
            Dim tableExists As Integer = Convert.ToInt32(checkTableCommand.ExecuteScalar())

            If tableExists > 0 Then
                ' Drop the Cart3 table if it exists
                Dim dropTableQuery As String = "DROP TABLE Cart3"
                Dim dropTableCommand As New SqlCommand(dropTableQuery, connection)
                dropTableCommand.ExecuteNonQuery()
            End If

            ' Create the Cart3 table
            Dim createTableQuery As String = "CREATE TABLE Cart3 (Item VARCHAR(255), Price DECIMAL(10, 2))"
            Dim createTableCommand As New SqlCommand(createTableQuery, connection)
            createTableCommand.ExecuteNonQuery()

            ' Check if Cart1 has data
            Dim selectCart1CountQuery As String = "SELECT COUNT(*) FROM Cart1"
            Dim selectCart1CountCommand As New SqlCommand(selectCart1CountQuery, connection)
            Dim cart1Count As Integer = Convert.ToInt32(selectCart1CountCommand.ExecuteScalar())

            ' Check if Cart2 has data
            Dim selectCart2CountQuery As String = "SELECT COUNT(*) FROM Cart2"
            Dim selectCart2CountCommand As New SqlCommand(selectCart2CountQuery, connection)
            Dim cart2Count As Integer = Convert.ToInt32(selectCart2CountCommand.ExecuteScalar())

            ' Insert data into the Cart3 table
            If cart1Count > 0 Then
                Dim insertDataQuery As String = "INSERT INTO Cart3 (Item, Price) SELECT Breed AS Item, Price FROM Cart1"
                Dim insertDataCommand As New SqlCommand(insertDataQuery, connection)
                insertDataCommand.ExecuteNonQuery()
            End If

            If cart2Count > 0 Then
                Dim insertDataQuery As String = "INSERT INTO Cart3 (Item, Price) SELECT accessory_name AS Item, Price FROM Cart2"
                Dim insertDataCommand As New SqlCommand(insertDataQuery, connection)
                insertDataCommand.ExecuteNonQuery()
            End If

            ' Notify if both Cart1 and Cart2 are empty
            If cart1Count = 0 AndAlso cart2Count = 0 Then
                MessageBox.Show("Both Accessory cart and Pet cart are empty. Nothing to add to the Checkout page")
            Else
                Me.Hide()
                Payment.Show()
            End If
        End Using
    End Sub
    Private Sub DeleteRecord(tableName As String, selectedRow As DataGridViewRow)
        If tableName = "Cart1" Then
            Dim itemName As String = selectedRow.Cells("Breed").Value.ToString() ' Assuming the column name is "Item"
            Dim price As Decimal = CDec(selectedRow.Cells("Price").Value) ' Assuming the column name is "Price"
            Dim query As String = $"DELETE FROM {tableName} WHERE Breed = @Item AND Price = @Price"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Item", itemName)
                    command.Parameters.AddWithValue("@Price", price)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Else
            Dim itemName As String = selectedRow.Cells("accessory_name").Value.ToString() ' Assuming the column name is "Item"
            Dim price As Decimal = CDec(selectedRow.Cells("Price").Value) ' Assuming the column name is "Price"
            Dim query As String = $"DELETE FROM {tableName} WHERE accessory_name = @Item AND Price = @Price"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Item", itemName)
                    command.Parameters.AddWithValue("@Price", price)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Delete the corresponding record from the database table
            Dim tableName As String = "Cart2" ' Replace "YourTable" with the actual table name
            DeleteRecord(tableName, selectedRow)

            ' Remove the row from the DataGridView
            DataGridView1.Rows.Remove(selectedRow)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)

            ' Delete the corresponding record from the database table
            Dim tableName As String = "Cart1" ' Replace "YourTable" with the actual table name
            DeleteRecord(tableName, selectedRow)

            ' Remove the row from the DataGridView
            DataGridView2.Rows.Remove(selectedRow)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub
End Class
