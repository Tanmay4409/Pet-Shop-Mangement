Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports Mysqlx.Resultset
Imports System.Text.RegularExpressions

Public Class Create_Account
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"

    Private Sub Create_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        Dim phoneNo As String = TextBox3.Text.Trim()
        Try
            Dim regexPattern As String = "^[6-9]\d{9}$"
            If Regex.IsMatch(phoneNo, regexPattern) Then
                Try
                    If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) AndAlso Not String.IsNullOrEmpty(phoneNo) Then
                        Try
                            Using conn As New SqlConnection(connectionString)
                                conn.Open()

                                Dim query As String = "INSERT INTO customerdata (Username, Password, Phone_no) VALUES (@Username, @Password, @PhoneNo)"

                                Using cmd As New SqlCommand(query, conn)
                                    cmd.Parameters.AddWithValue("@Username", username)
                                    cmd.Parameters.AddWithValue("@Password", password)
                                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNo)

                                    Try
                                        cmd.ExecuteNonQuery()
                                        MessageBox.Show("Account Created successfully,Moving back to Login Page.")
                                        TextBox1.Clear()
                                        TextBox2.Clear()
                                        TextBox3.Clear()
                                        Me.Hide()
                                        Login_Page.Show()

                                    Catch ex As SqlException
                                        If ex.Number = 2627 Then ' Error number for duplicate key violation
                                            MessageBox.Show("Username/Phone NO: already exists. Please choose a different username.")
                                        Else
                                            MessageBox.Show("Error: " & ex.Message)
                                        End If
                                    End Try
                                End Using
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        End Try
                    Else
                        MessageBox.Show("Please enter values in all TextBoxes.")
                    End If
                Catch ex As Exception


                End Try
            Else
                MsgBox("Phone no is not correct")
            End If
        Catch ex As Exception
            MsgBox("Phone no is incorrect enter a valid 10 digit number")
        End Try
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Allow digits, backspace, and delete keys
        If Not Char.IsDigit(e.KeyChar) AndAlso
       e.KeyChar <> ChrW(8) AndAlso
       e.KeyChar <> ChrW(127) Then
            e.Handled = True ' Ignore non-numeric characters
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class