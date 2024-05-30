Imports Microsoft.Data.SqlClient

Public Class Payment
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim dataTable As New DataTable()
    Dim Username As String = Login_Page.UserNameEntered
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Hide()
        Button3.Hide()
        Dim form1 As Login_Page = CType(Application.OpenForms("Login_Page"), Login_Page)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Hide()
        Button3.Show()
        ReloadTableContents("Cart3", DataGridView1)
        DataGridView1.Columns("Item").ReadOnly = True
        DataGridView1.Columns("Price").ReadOnly = True
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Carts.Show()
        DropCart3Table()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MsgBox("Thank you for purchasing:  " & Username)
        DeleteDataFromTables()
        DropCart3Table()
        Home.Show()
    End Sub
    Private Sub DeleteDataFromTables()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                Dim command1 As New SqlCommand("DELETE FROM Cart1", connection, transaction)
                command1.ExecuteNonQuery()
                Dim command2 As New SqlCommand("DELETE FROM Cart2", connection, transaction)
                command2.ExecuteNonQuery()
                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error deleting data: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub DropCart3Table()
        Dim tableName As String = "cart3"
        Dim dropTableQuery As String = $"DROP TABLE {tableName}"

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(dropTableQuery, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub
    Private Sub CalculateTotal()
        Dim total As Integer = 0

        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Add the integer value to the total
            total += CInt(row.Cells("Price").Value)
        Next

        ' Display the total in the label
        Label4.Text = "Total: ₹" & total.ToString()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label4.Show()
        CalculateTotal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Successfully logged out")
        Login_Page.Show()
    End Sub
End Class