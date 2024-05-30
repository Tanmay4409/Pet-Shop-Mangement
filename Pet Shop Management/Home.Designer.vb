<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Label9 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label10 = New Label()
        Button2 = New Button()
        Label11 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(849, 463)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(735, 417)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "LogOut"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(45, 33)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(95, 77)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(52, 35)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(112, 79)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(56, 37)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(95, 77)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.SeaGreen
        Label2.Location = New Point(193, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 14)
        Label2.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(21, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(215, 192)
        Panel1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(67, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 18)
        Label4.TabIndex = 8
        Label4.Text = "Pets↓"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(36, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 48)
        Label7.TabIndex = 10
        Label7.Text = "Browse Variety of pets " & vbCrLf & "like Dogs,Cats,Bird,Fish" & vbCrLf & "and add them to your cart"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(295, 70)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(215, 192)
        Panel2.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(52, 117)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 64)
        Label8.TabIndex = 11
        Label8.Text = "Browse Accessories " & vbCrLf & "for your lovely pets " & vbCrLf & "and provide them " & vbCrLf & "the most of there needs"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(62, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 18)
        Label5.TabIndex = 9
        Label5.Text = "Accessories↓"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Location = New Point(582, 70)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(212, 192)
        Panel3.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(45, 117)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 64)
        Label9.TabIndex = 12
        Label9.Text = "We would love to hear " & vbCrLf & "feedback from you about" & vbCrLf & "our shop so just tell us what" & vbCrLf & " do you feel about our shop"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(66, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 18)
        Label6.TabIndex = 10
        Label6.Text = "Feedback↓"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(357, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 58)
        Label1.TabIndex = 8
        Label1.Text = "Home"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(12, 371)
        Label3.Name = "Label3"
        Label3.Size = New Size(340, 75)
        Label3.TabIndex = 10
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.GradientActiveCaption
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(12, 347)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 21)
        Label10.TabIndex = 13
        Label10.Text = "About us:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(347, 284)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 39)
        Button2.TabIndex = 14
        Button2.Text = "Show carts"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.GradientActiveCaption
        Label11.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(21, 46)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 23)
        Label11.TabIndex = 15
        Label11.Text = "Label11"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 448)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(Label10)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Home"
        Text = "Home"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
End Class
