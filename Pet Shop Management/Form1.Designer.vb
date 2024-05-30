<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login_Page))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button4 = New Button()
        CheckBox1 = New CheckBox()
        LinkLabel2 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 452)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(191, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 58)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to Our Pet Shop"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(9, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 30)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 30)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(12, 189)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(81, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Admin Login?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(12, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 15)
        Label4.TabIndex = 7
        Label4.Text = "Username or Password is incorrect.Please check and try again."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(18, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(111, 265)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Clear "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(205, 265)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 23)
        Button3.TabIndex = 10
        Button3.Text = "Create account"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(134, 23)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(137, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(134, 23)
        TextBox2.TabIndex = 12
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(700, 400)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 13
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = SystemColors.GradientActiveCaption
        CheckBox1.Location = New Point(277, 148)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = SystemColors.GradientActiveCaption
        LinkLabel2.Location = New Point(12, 214)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(100, 15)
        LinkLabel2.TabIndex = 16
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot Password?"
        ' 
        ' Login_Page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel2)
        Controls.Add(CheckBox1)
        Controls.Add(Button4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(LinkLabel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login_Page"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
