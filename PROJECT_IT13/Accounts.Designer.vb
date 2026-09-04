<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
		Me.pnlDashboard = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnLogout = New System.Windows.Forms.Button()
		Me.btnInventory = New System.Windows.Forms.Button()
		Me.btnSales = New System.Windows.Forms.Button()
		Me.btnCashier = New System.Windows.Forms.Button()
		Me.btnDashboard = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.pnlDashboard.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlDashboard
		'
		Me.pnlDashboard.BackColor = System.Drawing.Color.Ivory
		Me.pnlDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlDashboard.Controls.Add(Me.Button1)
		Me.pnlDashboard.Controls.Add(Me.btnLogout)
		Me.pnlDashboard.Controls.Add(Me.btnInventory)
		Me.pnlDashboard.Controls.Add(Me.btnSales)
		Me.pnlDashboard.Controls.Add(Me.btnCashier)
		Me.pnlDashboard.Controls.Add(Me.btnDashboard)
		Me.pnlDashboard.Location = New System.Drawing.Point(0, -3)
		Me.pnlDashboard.Margin = New System.Windows.Forms.Padding(2)
		Me.pnlDashboard.Name = "pnlDashboard"
		Me.pnlDashboard.Size = New System.Drawing.Size(214, 650)
		Me.pnlDashboard.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Ivory
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.BorderSize = 3
		Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.8!)
		Me.Button1.ForeColor = System.Drawing.Color.DarkRed
		Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.Location = New System.Drawing.Point(5, 499)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(204, 59)
		Me.Button1.TabIndex = 10
		Me.Button1.Text = "Log Out"
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button1.UseVisualStyleBackColor = False
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
		Me.btnLogout.Location = New System.Drawing.Point(5, 436)
		Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
		Me.btnLogout.Name = "btnLogout"
		Me.btnLogout.Size = New System.Drawing.Size(204, 59)
		Me.btnLogout.TabIndex = 9
		Me.btnLogout.Text = "Accounts"
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
		Me.btnInventory.Location = New System.Drawing.Point(5, 366)
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
		Me.btnSales.Location = New System.Drawing.Point(5, 296)
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
		Me.btnCashier.Location = New System.Drawing.Point(4, 226)
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
		Me.btnDashboard.Location = New System.Drawing.Point(3, 156)
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
		Me.Panel1.BackColor = System.Drawing.Color.Ivory
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.TextBox2)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Controls.Add(Me.Button4)
		Me.Panel1.Controls.Add(Me.Button3)
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.TextBox1)
		Me.Panel1.Controls.Add(Me.ComboBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(245, 35)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(813, 568)
		Me.Panel1.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(19, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(231, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "MANAGE USERS"
		'
		'ComboBox1
		'
		Me.ComboBox1.DisplayMember = "DDD"
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(641, 85)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
		Me.ComboBox1.TabIndex = 1
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(25, 72)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(243, 42)
		Me.TextBox1.TabIndex = 2
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(284, 72)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(103, 42)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "SEARCH"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(393, 72)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(103, 42)
		Me.Button3.TabIndex = 4
		Me.Button3.Text = "ADD"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.Location = New System.Drawing.Point(502, 72)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(103, 42)
		Me.Button4.TabIndex = 5
		Me.Button4.Text = "DELETE"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.White
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel2.Location = New System.Drawing.Point(25, 133)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(761, 378)
		Me.Panel2.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(485, 528)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(192, 24)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "TOTAL RECORDS:"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(683, 521)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(103, 31)
		Me.TextBox2.TabIndex = 8
		'
		'Accounts
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkRed
		Me.ClientSize = New System.Drawing.Size(1092, 641)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.pnlDashboard)
		Me.Name = "Accounts"
		Me.Text = "Accounts"
		Me.pnlDashboard.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlDashboard As Panel
	Friend WithEvents Button1 As Button
	Friend WithEvents btnLogout As Button
	Friend WithEvents btnInventory As Button
	Friend WithEvents btnSales As Button
	Friend WithEvents btnCashier As Button
	Friend WithEvents btnDashboard As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Button4 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label2 As Label
End Class
