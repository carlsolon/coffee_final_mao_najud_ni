Imports MySql.Data.MySqlClient

Public Class AdminDashboard
    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        Dim dashboard As New AdminCashier()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim dashboard As New AdminSales()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim dashboard As New AdminInventory()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Show a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim dashboard As New Login()
            dashboard.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        Dim dashboard As New AdminAccounts()
        dashboard.Show()
        Me.Hide()
    End Sub


End Class