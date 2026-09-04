Imports System.Windows.Controls
Imports MySql.Data.MySqlClient

Public Class AdminInventory

    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtSearchProducts_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProducts.TextChanged
        LoadInventory()
    End Sub

    Private Sub LoadInventory()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare search query
                Dim query As String = "SELECT * FROM inventory"
                If txtSearchProducts.Text.Trim().Length > 0 Then  ' Check if search text is present
                    query &= " WHERE ProductName LIKE @searchText"  ' Add WHERE clause for searching by Name
                End If

                ' Execute query with parameter (if search is used)
                Using cmd As New MySqlCommand(query, connection)
                    If txtSearchProducts.Text.Trim().Length > 0 Then
                        cmd.Parameters.AddWithValue("@searchText", "%" & txtSearchProducts.Text.Trim() & "%")
                    End If
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvInven.DataSource = table
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " + ex.Message)
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPrice.Text = ""
        txtProductName.Text = ""
        txtQuantity.Text = ""
        cmbCategory.SelectedIndex = -1
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            If cmbCategory.SelectedIndex = -1 OrElse
              String.IsNullOrEmpty(txtProductName.Text) OrElse
      String.IsNullOrEmpty(txtQuantity.Text) OrElse
      String.IsNullOrEmpty(txtPrice.Text) Then

                MessageBox.Show("Please fill all fields to add a Product.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' Exit if any field is empty
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO inventory (Category ,ProductName, Quantity, Price ) 
                                        VALUES (@Category ,@ProductName ,@Quantity ,@Price) "
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product Added Successfully!")

                LoadInventory()
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'diria mag check if naay row nga gi select
        If dgvInven.SelectedRows.Count > 0 Then
            'diria mag kuha ug selected rows (primarily ang highlighted row)
            Dim selectedRow As DataGridViewRow = dgvInven.SelectedRows(0)
            'diria mag specify ug UserID ( or the primary key) from tbe selected row
            Dim Id As Integer = CInt(selectedRow.Cells("Id").Value)

            'diria ang update nga SQL Query
            Dim query As String = "UPDATE inventory SET "
            Dim hasUpdates As Boolean = False

            ' Maka add gihapon sya biskan dile ma inputan tanan field
            If Not String.IsNullOrEmpty(cmbCategory.Text) Then
                query += "Category = @Category,"
                hasUpdates = True
            End If

            ' Maka add gihapon sya biskan dile ma inputan tanan field
            If Not String.IsNullOrEmpty(txtProductName.Text) Then
                query += " ProductName = @ProductName,"
                hasUpdates = True
            End If

            ' Maka add gihapon sya biskan dile ma inputan tanan field
            If Not String.IsNullOrEmpty(txtQuantity.Text) Then
                query += " Quantity = @Quantity,"
                hasUpdates = True
            End If

            ' Maka add gihapon sya biskan dile ma inputan tanan field
            If Not String.IsNullOrEmpty(txtPrice.Text) Then
                query += " Price = @Price,"
                hasUpdates = True
            End If

            ' hawaon ang trailing comma if naay update na himo
            If hasUpdates Then
                query = query.Substring(0, query.Length - 1)
            End If

            ' Add WHERE clause
            query += " WHERE Id = @Id"

            ' Check if naay update nahitabo if wala mo show ni
            If Not hasUpdates Then
                MessageBox.Show("Please input the field you want to change")
                Exit Sub
            End If

            ' Update record sa MySQL
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Id", Id)

                    ' Add parameters for updated fields
                    If Not String.IsNullOrEmpty(cmbCategory.Text) Then
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtProductName.Text) Then
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtQuantity.Text) Then
                        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtPrice.Text) Then
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                    End If

                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using

            ' Reload the DataGridView
            LoadInventory()

            MessageBox.Show("Product updated Successfully")

        Else
            MessageBox.Show("Please Select a product to update.")
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'diria ka mag check usab ug naa kay naselect nga row
        If dgvInven.SelectedRows.Count > 0 Then

            'diria nimo makita ang selected nga row
            Dim selectedRow As DataGridViewRow = dgvInven.SelectedRows(0)

            'diria ka mag kuha ug UserId para ma identify unsa nga record
            Dim Id As Integer = CInt(selectedRow.Cells("Id").Value)

            'diria ka magpa confirm sa user ug gusto ba niya mag pa delete
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo)

            'diria ka mag handle kung unsay result sa imuha gipapili nga decision
            If result = DialogResult.Yes Then
                'then diria ka mag himo ug imuhang sql query to delete the record (specifically ang userID)
                Dim query As String = "DELETE FROM inventory WHERE Id = @Id"

                'diria ka mag execute sa imuhang na create nga Delete Query
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Using cmd As New MySqlCommand(query, connection)
                        'diria nimo i identify napud ang UserID as parameter
                        cmd.Parameters.AddWithValue("@Id", Id)
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    connection.Close()
                End Using
                LoadInventory()

                MessageBox.Show("Product deleted successfully.")
            End If
        Else
            MessageBox.Show("Please select a product to delete")
        End If


    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
        Dim inventory As New AdminDashboard()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs)
        Dim inventory As New AdminCashier()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs)
        Dim inventory As New AdminSales()
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


    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        Dim inventory As New AdminAccounts()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim inventory As New Login()
            inventory.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim inventory As New AdminDashboard()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click_1(sender As Object, e As EventArgs) Handles btnCashier.Click
        Dim inventory As New AdminCashier()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click_1(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim inventory As New AdminSales()
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class