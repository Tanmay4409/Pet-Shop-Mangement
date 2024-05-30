<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_feedback
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(A_feedback))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        btnDelete = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(788, 424)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(701, 388)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "LogOut"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(283, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 58)
        Label1.TabIndex = 3
        Label1.Text = "Feedbacks"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 105)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(552, 255)
        DataGridView1.TabIndex = 4
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Red
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(345, 86)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(141, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Go Back to previous page"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 21)
        Label2.TabIndex = 7
        Label2.Text = "Feedbacks:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(584, 337)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(99, 23)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Clear Feedback"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' A_feedback
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(788, 423)
        Controls.Add(btnDelete)
        Controls.Add(Label2)
        Controls.Add(LinkLabel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "A_feedback"
        Text = "A_feedback"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
End Class
