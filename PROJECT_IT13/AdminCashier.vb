Imports MySql.Data.MySqlClient

Public Class AdminCashier

    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        dgvBuy.Columns.Add("Category", "Category")
        dgvBuy.Columns.Add("ProductName", "ProductName")
        dgvBuy.Columns.Add("Price", "Price")
        dgvBuy.Columns.Add("Quantity", "Quantity")
        dgvBuy.Columns.Add("TotalPrice", "TotalPrice")
        dgvBuy.Columns.Add("DateAndTime", "DateAndTime")

        cmbCategory.Items.Add("Coffee")
        cmbCategory.Items.Add("Milk Tea")
        cmbCategory.Items.Add("Dessert")
        cmbCategory.Items.Add("Fruit Tea")
        LoadCashier()
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        LoadCashier()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the search text box
        txtSearchProduct.Text = String.Empty
        ' Reset the ComboBox 
        cmbCategory.SelectedIndex = -1 ' No item selected
        LoadCashier()
    End Sub

    Private Sub LoadCashier()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare the base query
                Dim query As String = "SELECT * FROM inventory WHERE 1=1"

                ' Add conditions for category filtering
                If cmbCategory.SelectedItem IsNot Nothing AndAlso cmbCategory.SelectedItem.ToString() <> "" Then
                    query &= " AND category = @category"
                End If

                ' Add conditions for search text filtering
                If txtSearchProduct.Text.Trim().Length > 0 Then
                    query &= " AND ProductName LIKE @searchText"
                End If

                ' Execute query with parameters
                Using cmd As New MySqlCommand(query, connection)
                    ' Bind the category parameter
                    If cmbCategory.SelectedItem IsNot Nothing AndAlso cmbCategory.SelectedItem.ToString() <> "" Then
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString())
                    End If

                    ' Bind the search text parameter
                    If txtSearchProduct.Text.Trim().Length > 0 Then
                        cmd.Parameters.AddWithValue("@searchText", "%" & txtSearchProduct.Text.Trim() & "%")
                    End If

                    ' Fill the DataTable and bind it to the DataGridView
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvProduct.DataSource = table
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
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

                        dgvProduct.DataSource = table
                    End Using
                End If

                connection.Close()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim cashier As New Login()
            cashier.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim cashier As New AdminDashboard()
        cashier.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim cashier As New AdminSales()
        cashier.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click
        Dim cashier As New AdminAccounts()
        cashier.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click_1(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim cashier As New AdminInventory()
        cashier.Show()
        Me.Hide()
    End Sub


    Private Sub LoadProducts()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to fetch data from the inventory table
                Dim query As String = "SELECT ProductID, ProductName, ProductPrice FROM inventory"
                Using cmd As New MySqlCommand(query, connection)
                    ' Use a data adapter to fill the DataGridView with the data
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvProduct.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
        ' Initialize totalPrice as 0
        Dim totalPrice As Decimal = 0

        ' Loop through each row in DgvPayment (skip new rows)
        For Each row As DataGridViewRow In dgvBuy.Rows
            If row.IsNewRow Then Continue For ' Skip the new row placeholder

            ' Ensure that the total price column has a valid value
            If Not IsDBNull(row.Cells("TotalPrice").Value) Then
                Dim currentTotalPrice As Decimal
                If Decimal.TryParse(row.Cells("TotalPrice").Value.ToString(), currentTotalPrice) Then
                    totalPrice += currentTotalPrice
                End If
            End If
        Next

        ' Display the total price in the TxtTotalBills TextBox
        txtTotalPrice.Text = totalPrice.ToString("F2") ' Format as a decimal with two decimal places
    End Sub

    Private Sub btnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click
        ' Check if there are rows to save
        If dgvBuy.Rows.Count = 0 Then
            MessageBox.Show("No items to save. Please add products to the payment list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate the cash input
        If String.IsNullOrEmpty(txtCash.Text) Then
            MessageBox.Show("Please enter the amount of cash received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cashReceived As Decimal
        If Not Decimal.TryParse(txtCash.Text, cashReceived) Then
            MessageBox.Show("Invalid cash value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate the total price of the order
        Dim totalOrderPrice As Decimal = 0
        For Each row As DataGridViewRow In dgvBuy.Rows
            If row.IsNewRow Then Continue For ' Skip new row placeholder
            totalOrderPrice += CDec(row.Cells("TotalPrice").Value)
        Next

        ' Check if cash received is enough
        If cashReceived < totalOrderPrice Then
            MessageBox.Show("The cash received is not enough to cover the total order. Please provide more cash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed with order processing
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Loop through each row in dgvBuy and process orders
                For Each row As DataGridViewRow In dgvBuy.Rows
                    If row.IsNewRow Then Continue For ' Skip new row placeholder

                    ' Retrieve data from DataGridView
                    Dim productName As String = row.Cells("ProductName").Value.ToString()
                    Dim priceStr As String = row.Cells("Price").Value.ToString()
                    Dim quantityStr As String = row.Cells("Quantity").Value.ToString()
                    Dim totalPriceStr As String = row.Cells("TotalPrice").Value.ToString()
                    Dim category As String = "Unknown" ' Default category if not available

                    ' Ensure the Category exists in dgvBuy and retrieve it
                    If dgvBuy.Columns.Contains("Category") AndAlso row.Cells("Category").Value IsNot Nothing Then
                        category = row.Cells("Category").Value.ToString()
                    End If

                    Dim currentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                    ' Insert data into the orders table
                    Dim insertQuery As String = "INSERT INTO orders (Category, ProductName, Price, Quantity, TotalPrice, DateAndTime) VALUES (@Category, @ProductName, @Price, @Quantity, @TotalPrice, @DateAndTime)"
                    Using insertCmd As New MySqlCommand(insertQuery, connection)
                        insertCmd.Parameters.AddWithValue("@Category", category)
                        insertCmd.Parameters.AddWithValue("@ProductName", productName)
                        insertCmd.Parameters.AddWithValue("@Price", priceStr)
                        insertCmd.Parameters.AddWithValue("@Quantity", quantityStr)
                        insertCmd.Parameters.AddWithValue("@TotalPrice", totalPriceStr)
                        insertCmd.Parameters.AddWithValue("@DateAndTime", currentDateTime)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    ' Deduct quantity from inventory
                    Dim quantityToBuy As Integer = CInt(quantityStr)
                    Dim updateQuery As String = "UPDATE inventory SET Quantity = Quantity - @Quantity WHERE ProductName = @ProductName"
                    Using updateCmd As New MySqlCommand(updateQuery, connection)
                        updateCmd.Parameters.AddWithValue("@Quantity", quantityToBuy)
                        updateCmd.Parameters.AddWithValue("@ProductName", productName)
                        updateCmd.ExecuteNonQuery()
                    End Using
                Next

                connection.Close()
            End Using

            ' Inform the user and clear the payment table
            MessageBox.Show("All items have been successfully saved to the database and inventory updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvBuy.Rows.Clear() ' Clear rows after saving
            txtCash.Clear() ' Clear the cash textbox after processing the order

        Catch ex As MySqlException
            MessageBox.Show("Error saving to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        ' Ensure the cash entered is a valid number
        Dim cash As Decimal
        If Decimal.TryParse(txtCash.Text, cash) AndAlso cash >= 0 Then
            ' Calculate and display the exchange if the total price is available
            CalculateExchange(cash)
        Else
            ' If input is invalid, clear the exchange value
            txtChange.Text = ""
        End If
    End Sub

    Private Sub CalculateExchange(cash As Decimal)
        ' Get the total price from TxtTotalBills
        Dim totalPrice As Decimal
        If Decimal.TryParse(txtTotalPrice.Text, totalPrice) Then
            ' Calculate the exchange amount
            Dim exchange As Decimal = cash - totalPrice
            ' Update the TxtExchange TextBox with the calculated exchange value
            If exchange >= 0 Then
                txtChange.Text = exchange.ToString("F2") ' Format to 2 decimal places
            Else
                txtChange.Text = "Insufficient cash"
            End If
        Else
            ' If total price is not valid, clear the exchange value
            txtChange.Text = ""
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if a product is selected
        If dgvProduct.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product from the inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = dgvProduct.SelectedRows(0)
        Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
        Dim category As String = selectedRow.Cells("Category").Value.ToString()
        Dim priceStr As String = selectedRow.Cells("Price").Value.ToString()
        Dim currentStock As Integer = CInt(selectedRow.Cells("Quantity").Value)

        ' Prompt for quantity
        Dim quantityStr As String = InputBox($"Enter quantity for {productName} (Available: {currentStock}):", "Enter Quantity")
        Dim quantity As Integer

        ' Validate quantity
        If Not Integer.TryParse(quantityStr, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Invalid quantity entered. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if stock is sufficient
        If quantity > currentStock Then
            MessageBox.Show($"Insufficient stock for {productName}. Available: {currentStock}, Requested: {quantity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate total price
        Dim totalPrice As Decimal = CDec(priceStr) * quantity
        Dim totalPriceStr As String = totalPrice.ToString()

        ' Deduct quantity from DataGridView
        Dim newStock As Integer = currentStock - quantity
        selectedRow.Cells("Quantity").Value = newStock

        ' Deduct quantity from the database
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim updateQuery As String = "UPDATE inventory SET Quantity = @NewQuantity WHERE ProductName = @ProductName"
                Using cmd As New MySqlCommand(updateQuery, connection)
                    cmd.Parameters.AddWithValue("@NewQuantity", newStock)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error updating inventory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Add product details to dgvBuy
        Dim currentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        dgvBuy.Rows.Add(category, productName, priceStr, quantityStr, totalPriceStr, currentDateTime)

        ' Update total price (if applicable)
        UpdateTotalPrice()

        ' Inform the user
        MessageBox.Show($"{productName} (x{quantity}) added to the payment list! Remaining stock: {newStock}.", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub UpdateTotalPrice()
        Dim totalPrice As Decimal = 0

        ' Loop through each row in DgvPayment
        For Each row As DataGridViewRow In dgvBuy.Rows
            If row.IsNewRow Then Continue For ' Skip the new row placeholder

            ' Ensure that the TotalPrice column has a valid value
            If Not IsDBNull(row.Cells("TotalPrice").Value) Then
                Dim currentTotalPrice As Decimal
                If Decimal.TryParse(row.Cells("TotalPrice").Value.ToString(), currentTotalPrice) Then
                    totalPrice += currentTotalPrice
                End If
            End If
        Next

        ' Update the TxtTotalBills textbox with the total price
        txtTotalPrice.Text = totalPrice.ToString("F2") ' Format as a decimal with two decimal places
    End Sub

    Private Sub btnClearProduct_Click(sender As Object, e As EventArgs) Handles btnClearProduct.Click
        ' Check if there are products in dgvBuy
        If dgvBuy.Rows.Count > 0 Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Loop through each row in dgvBuy
                    For Each row As DataGridViewRow In dgvBuy.Rows
                        If row.IsNewRow Then Continue For ' Skip new row placeholder

                        Dim productName As String = row.Cells("ProductName").Value.ToString()
                        Dim returnedQuantity As Integer = CInt(row.Cells("Quantity").Value)

                        ' Update the inventory in the database
                        Dim query As String = "UPDATE inventory SET Quantity = Quantity + @ReturnedQuantity WHERE ProductName = @ProductName"
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@ReturnedQuantity", returnedQuantity)
                            cmd.Parameters.AddWithValue("@ProductName", productName)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Update the inventory in dgvProduct
                        For Each productRow As DataGridViewRow In dgvProduct.Rows
                            If productRow.Cells("ProductName").Value.ToString() = productName Then
                                Dim currentStock As Integer = CInt(productRow.Cells("Quantity").Value)
                                productRow.Cells("Quantity").Value = currentStock + returnedQuantity
                                Exit For
                            End If
                        Next
                    Next

                    connection.Close()
                End Using

                ' Clear dgvBuy and reset textboxes
                dgvBuy.Rows.Clear()
                txtTotalPrice.Clear()
                txtCash.Clear()
                txtChange.Clear()

                MessageBox.Show("Products have been returned to the inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                MessageBox.Show("Error updating inventory: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No products to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvBuy.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product from the purchase list to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete the selected product(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' Loop through selected rows in reverse order to avoid index issues
            For i As Integer = dgvBuy.SelectedRows.Count - 1 To 0 Step -1
                Dim selectedRow As DataGridViewRow = dgvBuy.SelectedRows(i)
                Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
                Dim quantityToReturn As Integer = CInt(selectedRow.Cells("Quantity").Value)

                ' Update the inventory in dgvProduct
                For Each productRow As DataGridViewRow In dgvProduct.Rows
                    If productRow.Cells("ProductName").Value.ToString() = productName Then
                        Dim currentStock As Integer = CInt(productRow.Cells("Quantity").Value)
                        productRow.Cells("Quantity").Value = currentStock + quantityToReturn
                        Exit For
                    End If
                Next

                ' Remove the row from dgvBuy
                dgvBuy.Rows.RemoveAt(selectedRow.Index)
            Next

            ' Update the total price after deletion
            UpdateTotalPrice()

            MessageBox.Show("Selected product(s) deleted and quantity returned to inventory.", "Products Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class
