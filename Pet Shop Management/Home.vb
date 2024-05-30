Imports Microsoft.Data.SqlClient

Public Class Home
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim dataTable As New DataTable()
    Dim Username As String = Login_Page.UserNameEntered
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MsgBox("You have been successfully logged out")
        Login_Page.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropCart3Table()
        Label11.Text = ("Welcome " & Username)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Pets.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Accessories.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Feedback.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Carts.Show()
    End Sub
    Public Sub DropCart3Table()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim dropTableQuery As String = "IF OBJECT_ID('Cart3', 'U') IS NOT NULL DROP TABLE Cart3"
            Dim dropTableCommand As New SqlCommand(dropTableQuery, connection)
            dropTableCommand.ExecuteNonQuery()
        End Using
    End Sub
End Class