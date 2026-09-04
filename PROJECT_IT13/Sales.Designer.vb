<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Panel3 = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkRed
        Panel3.Location = New Point(270, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1003, 672)
        Panel3.TabIndex = 3
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
        Panel1.Size = New Size(338, 672)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(271, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(792, 599)
        Panel2.TabIndex = 5
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
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1207, 672)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Sales"
        Text = "Sales"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
