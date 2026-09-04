Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboard.Paint

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        Dim inventory As New Dashboard()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs)
        Dim inventory As New Cashier()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs)
        Dim inventory As New Sales()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim inventory As New Login()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class