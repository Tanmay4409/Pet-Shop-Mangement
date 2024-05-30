<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forget_Password
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Forget_Password))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(805, 451)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(240, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 58)
        Label1.TabIndex = 1
        Label1.Text = "Recover Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(67, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 30)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(187, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(165, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(186, 164)
        TextBox2.MaxLength = 10
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 23)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Location = New Point(113, 309)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 23)
        Button1.TabIndex = 8
        Button1.Text = "Change Password"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.Location = New Point(315, 309)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(41, 52)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(128, 15)
        LinkLabel1.TabIndex = 10
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Go back to login page?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(67, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 30)
        Label3.TabIndex = 11
        Label3.Text = "Phone No:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(32, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 30)
        Label4.TabIndex = 12
        Label4.Text = "New Password:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(186, 223)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(166, 23)
        TextBox3.TabIndex = 13
        ' 
        ' Forget_Password
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Forget_Password"
        Text = "Forget_Password"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
