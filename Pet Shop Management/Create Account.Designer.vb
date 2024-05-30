<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Account
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Create_Account))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 449)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(36, 95)
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
        Label2.Location = New Point(36, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 30)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.GradientActiveCaption
        Label5.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(241, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(229, 58)
        Label5.TabIndex = 5
        Label5.Text = "Create Account"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(36, 315)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 23)
        Button1.TabIndex = 6
        Button1.Text = "Create Account"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(185, 315)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(40, 233)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(289, 15)
        LinkLabel1.TabIndex = 12
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already have an account move to login page instead?"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(225, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 23)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(225, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(148, 23)
        TextBox2.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(40, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 30)
        Label6.TabIndex = 16
        Label6.Text = "Phone No:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(225, 197)
        TextBox3.MaxLength = 10
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(148, 23)
        TextBox3.TabIndex = 17
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = SystemColors.GradientActiveCaption
        CheckBox1.Location = New Point(396, 142)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 19
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(40, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(322, 15)
        Label3.TabIndex = 20
        Label3.Text = "Note: Username/Phone No should not be already registered"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(700, 403)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 21
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Create_Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Create_Account"
        Text = "Create_Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
End Class
