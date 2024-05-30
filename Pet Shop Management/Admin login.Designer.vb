<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin_login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(778, 397)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 30)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 30)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(257, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 58)
        Label3.TabIndex = 3
        Label3.Text = "Admin Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(114, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(166, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(114, 183)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 23)
        TextBox2.TabIndex = 5
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(14, 220)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(94, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Customer login?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(20, 266)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 15)
        Label4.TabIndex = 7
        Label4.Text = "Username or Password is incorrect.."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(139, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(242, 229)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = SystemColors.GradientActiveCaption
        CheckBox1.Location = New Point(304, 185)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 16
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(678, 362)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 17
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Admin_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(778, 397)
        Controls.Add(Button4)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Admin_login"
        Text = "Admin_login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button4 As Button
End Class
