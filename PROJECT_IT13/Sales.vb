Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboard.Paint

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        Dim sales As New Dashboard()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs)
        Dim sales As New Cashier()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs)
        Dim sales As New Inventory()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim sales As New Login()
        sales.Show()
        Me.Hide()
    End Sub
End Class