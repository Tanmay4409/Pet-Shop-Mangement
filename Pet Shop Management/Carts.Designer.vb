<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carts
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Carts))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Button7 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Button8 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView2 = New DataGridView()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Button6 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(796, 443)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(321, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 58)
        Label1.TabIndex = 1
        Label1.Text = "Carts"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(27, 72)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 309)
        Panel1.TabIndex = 2
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(104, 273)
        Button7.Name = "Button7"
        Button7.Size = New Size(107, 23)
        Button7.TabIndex = 6
        Button7.Text = "Clear selected"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 273)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 7
        Button5.Text = "Reload"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(232, 273)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "Clear cart?"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Freestyle Script", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(91, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 37)
        Label2.TabIndex = 0
        Label2.Text = "Accessories "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(48, 50)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(199, 217)
        DataGridView1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(DataGridView2)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(413, 72)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(304, 309)
        Panel2.TabIndex = 0
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(104, 273)
        Button8.Name = "Button8"
        Button8.Size = New Size(98, 23)
        Button8.TabIndex = 7
        Button8.Text = "Clear selected"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(226, 273)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 6
        Button3.Text = "Clear cart?"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(15, 273)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 6
        Button4.Text = "Reload"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(57, 50)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(192, 217)
        DataGridView2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Freestyle Script", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(117, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 37)
        Label3.TabIndex = 1
        Label3.Text = "Pet"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(27, 52)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(147, 15)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Move back to home page?"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(697, 385)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Log Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(321, 385)
        Button6.Name = "Button6"
        Button6.Size = New Size(107, 33)
        Button6.TabIndex = 5
        Button6.Text = "Checkout?"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Carts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 430)
        Controls.Add(Button6)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Carts"
        Text = "Carts"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
