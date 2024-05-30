
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.Data.SqlClient
Imports Mysqlx

Public Class Pets

    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim connection As SqlConnection
    Dim dataTable As New DataTable()
    Dim adapter As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Pets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button7.Hide()
        Button4.Hide()
        Button5.Hide()
        LoadDataIntoDataGridView()
        DataGridView.Columns("Breed").ReadOnly = True
        DataGridView.Columns("Price").ReadOnly = True
        DataGridView.ScrollBars = ScrollBars.Vertical
        ComboBox1.Items.Add("Cat")
        ComboBox1.Items.Add("Dog")
        ComboBox1.Items.Add("Fish")
        ComboBox1.Items.Add("Birds")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MsgBox("Successfully logged out")
        Login_Page.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox2.Text = "" Then
            MsgBox("please Select an item")
        Else
            Dim selectedItem As String = ComboBox2.SelectedItem.ToString()
            AddItemToDataGridView(selectedItem)
            Button7.Show()
            Button4.Show()
            Button5.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView.Rows.Clear()
    End Sub
    Private Sub LoadDataIntoDataGridView()
        Dim query As String = "SELECT pet_name,Breed, price FROM pet_details"
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
            End Using
        End Using
    End Sub
    Private Sub AddItemToDataGridView(itemName As String)
        Dim query As String = "SELECT Price FROM pet_details WHERE Breed = @ItemName"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ItemName", itemName)
                connection.Open()
                Dim price As Object = command.ExecuteScalar()
                If price IsNot Nothing Then
                    DataGridView.DataSource = Nothing ' Remove data binding
                    Dim row As String() = {itemName, price.ToString()}
                    DataGridView.Rows.Add(row)
                Else
                    MessageBox.Show("Item not found in the database.")
                End If
            End Using
        End Using
    End Sub
    Private Sub SaveDataToCart()
        Dim query As String = "INSERT INTO Cart1 (Breed,Price) VALUES ( @Breed ,@Price)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                For Each row As DataGridViewRow In DataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim Breedname As String = row.Cells("Breed").Value.ToString()
                        Dim price As Decimal = Decimal.Parse(row.Cells("Price").Value.ToString())
                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@Breed", Breedname)
                        command.Parameters.AddWithValue("@Price", price)
                        command.ExecuteNonQuery()
                    End If
                Next

                MessageBox.Show("Data saved to Pet Cart table successfully.")
            End Using
        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DataGridView.Rows.Count > 1 Then
            SaveDataToCart()
            DataGridView.Rows.Clear()
        Else
            MsgBox("Add Items to the cart")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        Dim selectedValue As String = ComboBox1.SelectedItem.ToString()
        If selectedValue = "Cat" Then
            ComboBox2.Items.Add("Persian")
            ComboBox2.Items.Add("Maine Coon")
            ComboBox2.Items.Add("Siamese")
            ComboBox2.Items.Add("Ragdoll")
            ComboBox2.Items.Add("British Shorthair")
        ElseIf selectedValue = "Dog" Then
            ComboBox2.Items.Add("Labrador Retriever")
            ComboBox2.Items.Add("German Shepherd")
            ComboBox2.Items.Add("Golden Retriever")
            ComboBox2.Items.Add("Bulldog")
            ComboBox2.Items.Add("Boxer")
        ElseIf selectedValue = "Fish" Then
            ComboBox2.Items.Add("Goldfish")
            ComboBox2.Items.Add("Betta")
            ComboBox2.Items.Add("Guppy")
            ComboBox2.Items.Add("Neon Tetra")
            ComboBox2.Items.Add("Angelfish")
        ElseIf selectedValue = "Birds" Then
            ComboBox2.Items.Add("Budgerigar")
            ComboBox2.Items.Add("Cockatiel")
            ComboBox2.Items.Add("Lovebird")
            ComboBox2.Items.Add("Canary")
            ComboBox2.Items.Add("Finch")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)

            ' Remove the row from the DataGridView
            DataGridView.Rows.Remove(selectedRow)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub
End Class
