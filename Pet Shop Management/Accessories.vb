Imports Microsoft.Data.SqlClient
Imports Mysqlx

Public Class Accessories
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"

    Private Sub Accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
        DataGridView.Columns("accessory_name").ReadOnly = True
        DataGridView.Columns("Price").ReadOnly = True
        DataGridView.ScrollBars = ScrollBars.Vertical
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("Successfully logged out")
        Login_Page.Show()
        Button2.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Dim query As String = "SELECT accessory_name, price FROM Accessories"
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
            End Using
        End Using
    End Sub

    Private Sub AddItemToDataGridView(itemName As String)
        Dim query As String = "SELECT price FROM Accessories WHERE accessory_name = @itemName"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@itemName", itemName)
                connection.Open()
                Dim price As Object = command.ExecuteScalar()
                If price IsNot Nothing Then
                    If DataGridView.DataSource IsNot Nothing Then
                        ' Clear data binding if necessary
                        DataGridView.DataSource = Nothing
                        ' Ensure columns are defined
                        If DataGridView.Columns.Count = 0 Then
                            DataGridView.Columns.Add("accessory_name", "Accessory Name")
                            DataGridView.Columns.Add("price", "Price")
                        End If
                    End If

                    ' Add the new row
                    Dim row As String() = {itemName, price.ToString()}
                    DataGridView.Rows.Add(row)
                    DataGridView.Refresh() ' Refresh the DataGridView to ensure the new row is displayed
                Else
                    MessageBox.Show("Item not found in the database.")
                End If
            End Using
        End Using
    End Sub

    Private Sub SaveDataToCart()
        Dim query As String = "INSERT INTO Cart2 (accessory_name, price) VALUES (@AccessoryName, @Price)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                For Each row As DataGridViewRow In DataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim accessoryName As String = row.Cells("accessory_name").Value.ToString()
                        Dim price As Decimal = Decimal.Parse(row.Cells("price").Value.ToString())
                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@AccessoryName", accessoryName)
                        command.Parameters.AddWithValue("@Price", price)
                        command.ExecuteNonQuery()
                    End If
                Next
                MessageBox.Show("Data saved to Accessories cart successfully.")
            End Using
        End Using
    End Sub
    Private Sub btnDogFood_Click(sender As Object, e As EventArgs) Handles btnDogFood.Click
        AddItemToDataGridView("Dog Food")
    End Sub
    Private Sub btnCatFood_Click(sender As Object, e As EventArgs) Handles btnCatFood.Click
        AddItemToDataGridView("Cat Food")
    End Sub

    Private Sub btnBirdFood_Click(sender As Object, e As EventArgs) Handles btnBirdFood.Click
        AddItemToDataGridView("Bird Food")
    End Sub

    Private Sub btnFishFood_Click(sender As Object, e As EventArgs) Handles btnFishFood.Click
        AddItemToDataGridView("Fish Food")
    End Sub

    Private Sub btnDogBelt_Click(sender As Object, e As EventArgs) Handles btnDogBelt.Click
        AddItemToDataGridView("Dog Belt")
    End Sub

    Private Sub btnToy_Click(sender As Object, e As EventArgs) Handles btnToy.Click
        AddItemToDataGridView("Toy")
    End Sub

    Private Sub btnPetShampoo_Click(sender As Object, e As EventArgs) Handles btnPetShampoo.Click
        AddItemToDataGridView("Pet Shampoo")
    End Sub

    Private Sub btnPetBowl_Click(sender As Object, e As EventArgs) Handles btnPetBowl.Click
        AddItemToDataGridView("Pet Bowl")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView.Rows.Count > 1 Then
            SaveDataToCart()
            DataGridView.Rows.Clear()
        Else
            MsgBox("Add Items to the cart")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView.Rows.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)

            ' Remove the row from the DataGridView
            DataGridView.Rows.Remove(selectedRow)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnDogFood.Click, btnCatFood.Click, btnBirdFood.Click, btnFishFood.Click, btnDogBelt.Click, btnToy.Click, btnPetShampoo.Click, btnPetBowl.Click
        Button2.Show()
        Button3.Show()
        Button4.Show()
    End Sub
End Class
