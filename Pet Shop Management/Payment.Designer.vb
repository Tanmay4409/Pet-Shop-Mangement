<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Payment))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        Button4 = New Button()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(275, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 58)
        Label1.TabIndex = 2
        Label1.Text = "Checkout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(762, 460)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(627, 407)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(44, 97)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(282, 292)
        DataGridView1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(48, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 6
        Label2.Text = "Final List:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(48, 395)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(206, 395)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 23)
        Button3.TabIndex = 8
        Button3.Text = "Confirm Order"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(175, 79)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(99, 15)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Go Back to Carts?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(332, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 21)
        Label4.TabIndex = 11
        Label4.Text = "Total:"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(329, 152)
        Button4.Name = "Button4"
        Button4.Size = New Size(92, 23)
        Button4.TabIndex = 12
        Button4.Text = "Check Total"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Location = New Point(332, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 45)
        Label3.TabIndex = 13
        Label3.Text = "Note:To remove or add items " & vbCrLf & "in the list go back to previous " & vbCrLf & "pages"
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(760, 460)
        Controls.Add(Label3)
        Controls.Add(Button4)
        Controls.Add(Label4)
        Controls.Add(LinkLabel1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Payment"
        Text = "Payment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
End Class
