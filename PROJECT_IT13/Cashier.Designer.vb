<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button11 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel4 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Ivory
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = SystemColors.Info
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(272, 672)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Ivory
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Button10)
        Panel2.Dock = DockStyle.Left
        Panel2.ForeColor = SystemColors.Info
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(272, 672)
        Panel2.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Ivory
        Panel3.Controls.Add(Button11)
        Panel3.Controls.Add(Button12)
        Panel3.Controls.Add(Button13)
        Panel3.Controls.Add(Button14)
        Panel3.Controls.Add(Button15)
        Panel3.Dock = DockStyle.Left
        Panel3.ForeColor = SystemColors.Info
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(272, 672)
        Panel3.TabIndex = 5
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Ivory
        Button11.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = SystemColors.Desktop
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.ImageAlign = ContentAlignment.BottomLeft
        Button11.Location = New Point(6, 494)
        Button11.Name = "Button11"
        Button11.Size = New Size(263, 81)
        Button11.TabIndex = 4
        Button11.Text = "Logout"
        Button11.TextImageRelation = TextImageRelation.ImageBeforeText
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Ivory
        Button12.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button12.ForeColor = SystemColors.Desktop
        Button12.Image = CType(resources.GetObject("Button12.Image"), Image)
        Button12.ImageAlign = ContentAlignment.BottomLeft
        Button12.Location = New Point(6, 407)
        Button12.Name = "Button12"
        Button12.Size = New Size(263, 81)
        Button12.TabIndex = 3
        Button12.Text = "Inventory"
        Button12.TextImageRelation = TextImageRelation.ImageBeforeText
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.Ivory
        Button13.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = SystemColors.Desktop
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.ImageAlign = ContentAlignment.BottomLeft
        Button13.Location = New Point(6, 320)
        Button13.Name = "Button13"
        Button13.Size = New Size(263, 81)
        Button13.TabIndex = 2
        Button13.Text = "Sales"
        Button13.TextImageRelation = TextImageRelation.ImageBeforeText
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.Ivory
        Button14.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button14.ForeColor = SystemColors.Desktop
        Button14.Image = CType(resources.GetObject("Button14.Image"), Image)
        Button14.ImageAlign = ContentAlignment.BottomLeft
        Button14.Location = New Point(6, 233)
        Button14.Name = "Button14"
        Button14.Size = New Size(263, 81)
        Button14.TabIndex = 1
        Button14.Text = "Cashier"
        Button14.TextImageRelation = TextImageRelation.ImageBeforeText
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Ivory
        Button15.FlatAppearance.BorderColor = Color.Black
        Button15.FlatAppearance.BorderSize = 2
        Button15.FlatAppearance.MouseDownBackColor = Color.White
        Button15.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button15.ForeColor = SystemColors.Desktop
        Button15.Image = CType(resources.GetObject("Button15.Image"), Image)
        Button15.ImageAlign = ContentAlignment.BottomLeft
        Button15.Location = New Point(6, 146)
        Button15.Name = "Button15"
        Button15.Size = New Size(263, 81)
        Button15.TabIndex = 0
        Button15.Text = "Dashboard"
        Button15.TextImageRelation = TextImageRelation.ImageBeforeText
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Ivory
        Button6.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.Desktop
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.BottomLeft
        Button6.Location = New Point(6, 494)
        Button6.Name = "Button6"
        Button6.Size = New Size(263, 81)
        Button6.TabIndex = 4
        Button6.Text = "Logout"
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Ivory
        Button7.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = SystemColors.Desktop
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.BottomLeft
        Button7.Location = New Point(6, 407)
        Button7.Name = "Button7"
        Button7.Size = New Size(263, 81)
        Button7.TabIndex = 3
        Button7.Text = "Inventory"
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Ivory
        Button8.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = SystemColors.Desktop
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.BottomLeft
        Button8.Location = New Point(6, 320)
        Button8.Name = "Button8"
        Button8.Size = New Size(263, 81)
        Button8.TabIndex = 2
        Button8.Text = "Sales"
        Button8.TextImageRelation = TextImageRelation.ImageBeforeText
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Ivory
        Button9.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = SystemColors.Desktop
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.BottomLeft
        Button9.Location = New Point(6, 233)
        Button9.Name = "Button9"
        Button9.Size = New Size(263, 81)
        Button9.TabIndex = 1
        Button9.Text = "Cashier"
        Button9.TextImageRelation = TextImageRelation.ImageBeforeText
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Ivory
        Button10.FlatAppearance.BorderColor = Color.Black
        Button10.FlatAppearance.BorderSize = 2
        Button10.FlatAppearance.MouseDownBackColor = Color.White
        Button10.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = SystemColors.Desktop
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.ImageAlign = ContentAlignment.BottomLeft
        Button10.Location = New Point(6, 146)
        Button10.Name = "Button10"
        Button10.Size = New Size(263, 81)
        Button10.TabIndex = 0
        Button10.Text = "Dashboard"
        Button10.TextImageRelation = TextImageRelation.ImageBeforeText
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Ivory
        Button5.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.Desktop
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.BottomLeft
        Button5.Location = New Point(6, 494)
        Button5.Name = "Button5"
        Button5.Size = New Size(263, 81)
        Button5.TabIndex = 4
        Button5.Text = "Logout"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Ivory
        Button4.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.Desktop
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.BottomLeft
        Button4.Location = New Point(6, 407)
        Button4.Name = "Button4"
        Button4.Size = New Size(263, 81)
        Button4.TabIndex = 3
        Button4.Text = "Inventory"
        Button4.TextImageRelation = TextImageRelation.ImageBeforeText
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Ivory
        Button3.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Desktop
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.BottomLeft
        Button3.Location = New Point(6, 320)
        Button3.Name = "Button3"
        Button3.Size = New Size(263, 81)
        Button3.TabIndex = 2
        Button3.Text = "Sales"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Ivory
        Button2.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Desktop
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.BottomLeft
        Button2.Location = New Point(6, 233)
        Button2.Name = "Button2"
        Button2.Size = New Size(263, 81)
        Button2.TabIndex = 1
        Button2.Text = "Cashier"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Ivory
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = Color.White
        Button1.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Desktop
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.BottomLeft
        Button1.Location = New Point(6, 146)
        Button1.Name = "Button1"
        Button1.Size = New Size(263, 81)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkRed
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(275, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(937, 672)
        Panel4.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 0
        Label1.Text = "cash"
        ' 
        ' Cashier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1207, 672)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Name = "Cashier"
        Text = "Cashier"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
End Class
