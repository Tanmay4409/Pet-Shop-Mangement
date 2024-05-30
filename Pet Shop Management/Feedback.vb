Imports Microsoft.Data.SqlClient

Public Class Feedback
    Dim connectionString As String = "Data Source=(localdb)\PetShop;Initial Catalog=PetShop;Integrated Security=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim feedbackText As String = TextBox1.Text.Trim()

        If Not String.IsNullOrEmpty(feedbackText) Then
            Try
                ' Connect to the database
                Using conn As New SqlConnection(connectionString)
                    conn.Open()

                    ' Construct the SQL command for inserting a new row
                    Dim queryInsert As String = "INSERT INTO Feedback (Feedbacks) VALUES (@FeedbackText)"

                    ' Create and execute the SQL command
                    Using cmdInsert As New SqlCommand(queryInsert, conn)
                        cmdInsert.Parameters.AddWithValue("@FeedbackText", feedbackText)
                        cmdInsert.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Thank you for Feedback")
                End Using
                TextBox1.Clear()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please give some feedback ")
        End If
    End Sub
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MsgBox("Successfully logged out")
        Login_Page.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Home.Show()
    End Sub

End Class