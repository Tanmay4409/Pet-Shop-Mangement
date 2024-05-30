Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class Forget_Password
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Dim dataTable As New DataTable()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login_Page.Show()
    End Sub

    Private Sub Forget_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim phoneNumber As String = TextBox2.Text.Trim()
        Dim newPassword As String = TextBox3.Text.Trim()
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(phoneNumber) OrElse String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Please enter both username, phone number, and new password.")
            Return
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM customerdata WHERE username = @Username AND Phone_no = @Phone_no"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Phone_no", phoneNumber)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        Dim updateQuery As String = "UPDATE customerdata SET password = @NewPassword WHERE username = @Username AND  Phone_no= @Phone_no"
                        Using updateCommand As New SqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@NewPassword", newPassword)
                            updateCommand.Parameters.AddWithValue("@Username", username)
                            updateCommand.Parameters.AddWithValue("@Phone_no", phoneNumber)
                            updateCommand.ExecuteNonQuery()
                            MessageBox.Show("Password updated successfully.")
                            Me.Hide()
                            Login_Page.Show()
                        End Using
                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox3.Clear()
                    Else
                        MessageBox.Show("Username and/or phone number not found in the database.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the password: " & ex.Message)
        End Try
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Allow digits, backspace, and delete keys
        If Not Char.IsDigit(e.KeyChar) AndAlso
       e.KeyChar <> ChrW(8) AndAlso
       e.KeyChar <> ChrW(127) Then
            e.Handled = True ' Ignore non-numeric characters
        End If
    End Sub

End Class