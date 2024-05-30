<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pets
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Pets))
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        Button2 = New Button()
        Label2 = New Label()
        DataGridView = New DataGridView()
        Breed = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Button5 = New Button()
        Button6 = New Button()
        LinkLabel1 = New LinkLabel()
        Button7 = New Button()
        Button4 = New Button()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, -13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(673, 412)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 100)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(147, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(407, 28)
        Label1.TabIndex = 2
        Label1.Text = "Please select the type of animal you would like to adopt"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 157)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(147, 23)
        ComboBox2.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(165, 157)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 28)
        Label2.TabIndex = 6
        Label2.Text = "Please select breed/other type"
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Columns.AddRange(New DataGridViewColumn() {Breed, Price})
        DataGridView.Location = New Point(12, 237)
        DataGridView.Name = "DataGridView"
        DataGridView.RowTemplate.Height = 25
        DataGridView.Size = New Size(253, 162)
        DataGridView.TabIndex = 8
        ' 
        ' Breed
        ' 
        Breed.HeaderText = "Breed"
        Breed.Name = "Breed"
        Breed.Width = 105
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.Name = "Price"
        Price.Width = 105
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 28)
        Label3.TabIndex = 9
        Label3.Text = "Pet Cart"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(278, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 23)
        Label6.TabIndex = 13
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(286, 237)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 41)
        Button5.TabIndex = 15
        Button5.Text = "Clear all Item"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(573, 360)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 16
        Button6.Text = "Log out"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = SystemColors.GradientActiveCaption
        LinkLabel1.Location = New Point(12, 39)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(121, 15)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Move to Home Page?"
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(284, 347)
        Button7.Name = "Button7"
        Button7.Size = New Size(77, 48)
        Button7.TabIndex = 18
        Button7.Text = "Confirm " & vbCrLf & "order"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(286, 284)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 57)
        Button4.TabIndex = 19
        Button4.Text = "Clear Selected " & vbCrLf & "Item" & vbCrLf
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.GradientActiveCaption
        Label5.Font = New Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(224, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(195, 58)
        Label5.TabIndex = 20
        Label5.Text = "Browse Pets"
        ' 
        ' Pets
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(672, 402)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button7)
        Controls.Add(LinkLabel1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(ComboBox2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox1)
        Name = "Pets"
        Text = "Pets"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button7 As Button
    Friend WithEvents Breed As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
End Class
