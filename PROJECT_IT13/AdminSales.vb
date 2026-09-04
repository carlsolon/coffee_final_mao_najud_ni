Imports System.Windows.Controls
Imports MySql.Data.MySqlClient

Public Class AdminSales

    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Create a new MySql connection object
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                ' Display a successful connection message
                MessageBox.Show("Connection Successful")
                ' Close the connection
                connection.Close()
            End Using
        Catch ex As Exception
            ' Display errors if any
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
        LoadSales()
    End Sub


    Private Sub LoadSales()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare the basic SQL query to retrieve all rows from the 'payment' table
                Dim query As String = "SELECT * FROM orders"

                ' Execute the query
                Using cmd As New MySqlCommand(query, connection)

                    ' Create a DataAdapter to fill the DataTable with the query result
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()

                    ' Fill the DataTable with data from the database
                    adapter.Fill(table)

                    ' Bind the DataTable to the DataGridView
                    dgvSales.DataSource = table
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            ' Display error message if there is any issue with the database or query execution
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub












    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        Dim sales As New AdminDashboard()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs)
        Dim sales As New AdminCashier()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs)
        Dim sales As New AdminInventory()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim sales As New Login()
        sales.Show()
        Me.Hide()
    End Sub












    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        Dim sales As New AdminAccounts()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim sales As New Login()
            sales.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub PnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles PnlDashboard.Paint

    End Sub

    Private Sub BtnDashboard_Click_1(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Dim sales As New AdminDashboard()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCashier_Click_1(sender As Object, e As EventArgs) Handles BtnCashier.Click
        Dim sales As New AdminCashier()
        sales.Show()
        Me.Hide()
    End Sub



    Private Sub BtnInventory_Click_1(sender As Object, e As EventArgs) Handles BtnInventory.Click
        Dim sales As New AdminInventory()
        sales.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSales_Click_1(sender As Object, e As EventArgs) Handles BtnSales.Click

    End Sub


End Class