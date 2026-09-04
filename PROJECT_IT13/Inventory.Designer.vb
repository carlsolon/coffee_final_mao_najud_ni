<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
		Me.pnlDashboard = New System.Windows.Forms.Panel()
		Me.btnLogout = New System.Windows.Forms.Button()
		Me.btnInventory = New System.Windows.Forms.Button()
		Me.btnSales = New System.Windows.Forms.Button()
		Me.btnCashier = New System.Windows.Forms.Button()
		Me.btnDashboard = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.pnlDashboard.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlDashboard
		'
		Me.pnlDashboard.BackColor = System.Drawing.Color.Ivory
		Me.pnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDashboard.Controls.Add(Me.Button4)
		Me.pnlDashboard.Controls.Add(Me.btnLogout)
		Me.pnlDashboard.Controls.Add(Me.btnInventory)
		Me.pnlDashboard.Controls.Add(Me.btnSales)
		Me.pnlDashboard.Controls.Add(Me.btnCashier)
		Me.pnlDashboard.Controls.Add(Me.btnDashboard)
		Me.pnlDashboard.Location = New System.Drawing.Point(0, -1)
		Me.pnlDashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.pnlDashboard.Name = "pnlDashboard"
		Me.pnlDashboard.Size = New System.Drawing.Size(216, 643)
		Me.pnlDashboard.TabIndex = 6
		'
		'btnLogout
		'
		Me.btnLogout.BackColor = System.Drawing.Color.Ivory
		Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnLogout.FlatAppearance.BorderSize = 3
		Me.btnLogout.Font = New System.Drawing.Font("Times New Roman", 13.8!)
		Me.btnLogout.ForeColor = System.Drawing.Color.DarkRed
		Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
		Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLogout.Location = New System.Drawing.Point(7, 504)
		Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
		Me.btnLogout.Name = "btnLogout"
		Me.btnLogout.Size = New System.Drawing.Size(204, 59)
		Me.btnLogout.TabIndex = 9
		Me.btnLogout.Text = "Log Out"
		Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnLogout.UseVisualStyleBackColor = False
		'
		'btnInventory
		'
		Me.btnInventory.BackColor = System.Drawing.Color.Ivory
		Me.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnInventory.FlatAppearance.BorderSize = 3
		Me.btnInventory.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInventory.ForeColor = System.Drawing.Color.DarkRed
		Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
		Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnInventory.Location = New System.Drawing.Point(6, 371)
		Me.btnInventory.Margin = New System.Windows.Forms.Padding(2)
		Me.btnInventory.Name = "btnInventory"
		Me.btnInventory.Size = New System.Drawing.Size(204, 66)
		Me.btnInventory.TabIndex = 8
		Me.btnInventory.Text = "Inventory"
		Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnInventory.UseVisualStyleBackColor = False
		'
		'btnSales
		'
		Me.btnSales.BackColor = System.Drawing.Color.Ivory
		Me.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnSales.FlatAppearance.BorderSize = 3
		Me.btnSales.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSales.ForeColor = System.Drawing.Color.DarkRed
		Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
		Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSales.Location = New System.Drawing.Point(6, 301)
		Me.btnSales.Margin = New System.Windows.Forms.Padding(2)
		Me.btnSales.Name = "btnSales"
		Me.btnSales.Size = New System.Drawing.Size(204, 66)
		Me.btnSales.TabIndex = 7
		Me.btnSales.Text = "Sales"
		Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnSales.UseVisualStyleBackColor = False
		'
		'btnCashier
		'
		Me.btnCashier.BackColor = System.Drawing.Color.Ivory
		Me.btnCashier.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnCashier.FlatAppearance.BorderSize = 3
		Me.btnCashier.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCashier.ForeColor = System.Drawing.Color.DarkRed
		Me.btnCashier.Image = CType(resources.GetObject("btnCashier.Image"), System.Drawing.Image)
		Me.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnCashier.Location = New System.Drawing.Point(5, 231)
		Me.btnCashier.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCashier.Name = "btnCashier"
		Me.btnCashier.Size = New System.Drawing.Size(206, 66)
		Me.btnCashier.TabIndex = 6
		Me.btnCashier.Text = "Cashier"
		Me.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnCashier.UseVisualStyleBackColor = False
		'
		'btnDashboard
		'
		Me.btnDashboard.BackColor = System.Drawing.Color.Ivory
		Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDashboard.FlatAppearance.BorderSize = 3
		Me.btnDashboard.Font = New System.Drawing.Font("Times New Roman", 13.8!)
		Me.btnDashboard.ForeColor = System.Drawing.Color.DarkRed
		Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
		Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnDashboard.Location = New System.Drawing.Point(4, 161)
		Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2)
		Me.btnDashboard.Name = "btnDashboard"
		Me.btnDashboard.Size = New System.Drawing.Size(207, 66)
		Me.btnDashboard.TabIndex = 5
		Me.btnDashboard.Text = "Dashboard"
		Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnDashboard.UseVisualStyleBackColor = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SeaShell
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Button3)
		Me.Panel1.Controls.Add(Me.TextBox2)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(241, 34)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(826, 584)
		Me.Panel1.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(14, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 24)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Search: "
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(93, 16)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(214, 24)
		Me.TextBox1.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(325, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 24)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Quantity:"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(417, 16)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(171, 24)
		Me.TextBox2.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.SeaShell
		Me.Button1.Location = New System.Drawing.Point(442, 521)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(116, 43)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "ADD"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.SeaShell
		Me.Button2.Location = New System.Drawing.Point(573, 521)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(116, 43)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "UPDATE"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.SeaShell
		Me.Button3.Location = New System.Drawing.Point(695, 521)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(116, 43)
		Me.Button3.TabIndex = 6
		Me.Button3.Text = "DELETE"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Ivory
		Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button4.FlatAppearance.BorderSize = 3
		Me.Button4.Font = New System.Drawing.Font("Times New Roman", 13.8!)
		Me.Button4.ForeColor = System.Drawing.Color.DarkRed
		Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
		Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button4.Location = New System.Drawing.Point(7, 441)
		Me.Button4.Margin = New System.Windows.Forms.Padding(2)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(204, 59)
		Me.Button4.TabIndex = 10
		Me.Button4.Text = "Accounts"
		Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Inventory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkRed
		Me.ClientSize = New System.Drawing.Size(1092, 641)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.pnlDashboard)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "Inventory"
		Me.Text = "Inventory"
		Me.pnlDashboard.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlDashboard As Panel
	Friend WithEvents btnLogout As Button
	Friend WithEvents btnInventory As Button
	Friend WithEvents btnSales As Button
	Friend WithEvents btnCashier As Button
	Friend WithEvents btnDashboard As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents TextBox2 As TextBox
End Class
