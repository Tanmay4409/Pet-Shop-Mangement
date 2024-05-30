
Imports System
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class Login_Page
    Dim connString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Public Property UserNameEntered As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        Label4.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Admin_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Create_Account.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()

                    Dim query As String = "SELECT COUNT(*) FROM customerdata WHERE Username = @Username AND Password = @Password"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Username", username)
                        cmd.Parameters.AddWithValue("@Password", password)

                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If count > 0 Then
                            ' User found, close current form and open another form
                            UserNameEntered = TextBox1.Text
                            Me.Hide()
                            Home.Show()
                            TextBox1.Clear()
                            TextBox2.Clear()
                        Else
                            ' User not found, throw an exception
                            Throw New Exception("Invalid username or password.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter both username and password.")
        End If
        Dim tableName As String = "Cart1"
        Dim tableName1 As String = "Cart2"
        DeleteTableContents(tableName)
        DeleteTableContents(tableName1)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Forget_Password.Show()
    End Sub
    Private Sub DeleteTableContents(tableName As String)
        Try
            Using connection As New SqlConnection(connString)
                connection.Open()

                Dim query As String = "DELETE FROM " & tableName
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class