Public Class CashierCashier
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim cashiercashierd As New CashierDashboard()
        cashiercashierd.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim cashiercashierd As New CashierInventory()
        cashiercashierd.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim cashierdashboard As New Login()
            cashierdashboard.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub CashierCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class