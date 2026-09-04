Imports MySql.Data.MySqlClient

Public Class CashierDashboard
    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        Dim cashierdashboard As New CashierCashier()
        cashierdashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim cashierdashboard As New CashierInventory()
        cashierdashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim cashierdashboard As New Login()
            cashierdashboard.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub CashierDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Diria mo mag create ug new MySql connection object
            Using connection As New MySqlConnection(connectionString)
                'diria nga part ang mag open ug connection
                connection.Open()
                'diria mag pa display ug successful message
                MessageBox.Show("Connection Successful")
                connection.Close()
            End Using
        Catch ex As Exception
            'diria mag display ug errors
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try

        LoadLow()
    End Sub

    Private Sub LoadLow()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare search query to select products with a quantity less than 10
                Dim query As String = "SELECT * FROM inventory WHERE Quantity < 10"

                ' Execute query with parameter (if search is used)
                Using cmd As New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvLow.DataSource = table
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " + ex.Message)
        End Try
    End Sub

End Class