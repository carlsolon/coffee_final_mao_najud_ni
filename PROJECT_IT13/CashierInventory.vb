Imports MySql.Data.MySqlClient

Public Class CashierInventory

    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim cashiercinventory As New CashierDashboard()
        cashiercinventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        Dim cashiercinventory As New CashierCashier()
        cashiercinventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click

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

    Private Sub CashierInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        LoadInventory()
        cmbCategory.Items.Add("Coffee")
        cmbCategory.Items.Add("Milk Tea")
        cmbCategory.Items.Add("Dessert")
        cmbCategory.Items.Add("Fruit Tea")

    End Sub

    Private Sub LoadInventory()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare search query
                Dim query As String = "SELECT * FROM inventory"


                ' Execute query with parameter (if search is used)
                Using cmd As New MySqlCommand(query, connection)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvAllProducts.DataSource = table
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " + ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbCategory.SelectedIndex = -1 ' No item selected

        ' Reload all data into the DataGridView
        LoadInventory()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String

                If cmbCategory.SelectedIndex >= 0 Then ' Check if a valid item is selected
                    If cmbCategory.SelectedItem.ToString() = "All" Then
                        query = "SELECT * FROM inventory"
                    Else
                        query = "SELECT * FROM inventory WHERE Category = @Category"
                    End If

                    Using cmd As New MySqlCommand(query, connection)
                        If cmbCategory.SelectedItem.ToString() <> "All" Then
                            cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
                        End If

                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvAllProducts.DataSource = table
                    End Using
                End If

                connection.Close()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class