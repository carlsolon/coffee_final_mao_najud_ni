Imports MySql.Data.MySqlClient
Public Class AdminAccounts
    Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"
    Private Sub AdminAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        LoadUsers()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Cashier")
        cmbCategory.Items.Add("Admin")
        cmbCategory.Items.Add("Cashier")

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare search query
                Dim query As String = "SELECT * FROM Users"
                If txtSearch.Text.Trim().Length > 0 Then  ' Check if search text is present
                    query &= " WHERE Name LIKE @searchText"  ' Add WHERE clause for searching by Name
                End If

                ' Execute query with parameter (if search is used)
                Using cmd As New MySqlCommand(query, connection)
                    If txtSearch.Text.Trim().Length > 0 Then
                        cmd.Parameters.AddWithValue("@searchText", "%" & txtSearch.Text.Trim() & "%")
                    End If
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvUsers.DataSource = table
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If String.IsNullOrEmpty(txtName.Text) OrElse
    String.IsNullOrEmpty(txtAge.Text) OrElse
      String.IsNullOrEmpty(txtContactNo.Text) OrElse
      String.IsNullOrEmpty(txtAddress.Text) OrElse
      String.IsNullOrEmpty(txtUsername.Text) OrElse
      String.IsNullOrEmpty(txtPassword.Text) OrElse
      cmbRole.SelectedIndex = -1 Then

                MessageBox.Show("Please fill all fields to add a user.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' Exit if any field is empty
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                'diria mag butang ug sql query to insert data into the users table
                Dim query As String = "INSERT INTO Users (Name ,Age, ContactNo ,Address,Username, Password,Role) 
   VALUES (@Name,@Age , @ContactNo ,@Address,@Username, @Password,@Role)"
                'diria mag create ug MySQL command object
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@Role", cmbRole.Text)

                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("User Added Successfully!")

                LoadUsers()
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message)
        End Try
    End Sub















    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim accounts As New AdminDashboard()
        accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        Dim accounts As New AdminCashier()
        accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim accounts As New AdminSales()
        accounts.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim accounts As New AdminInventory()
        accounts.Show()
        Me.Hide()
    End Sub





    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles BtnAccounts.Click

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the logout process
        If result = DialogResult.Yes Then
            Dim accounts As New Login()
            accounts.Show()
            Me.Hide() ' Hide the current form
        End If
    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtContactNo.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtAge.Text = ""
        txtContactNo.Text = ""
        txtAddress.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbRole.SelectedIndex = -1


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'diria ka mag check usab ug naa kay naselect nga row
        If dgvUsers.SelectedRows.Count > 0 Then

            'diria nimo makita ang selected nga row
            Dim selectedRow As DataGridViewRow = dgvUsers.SelectedRows(0)

            'diria ka mag kuha ug UserId para ma identify unsa nga record
            Dim Id As Integer = CInt(selectedRow.Cells("Id").Value)

            'diria ka magpa confirm sa user ug gusto ba niya mag pa delete
            Dim result As DialogResult = MessageBox.Show("Are you sure to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo)

            'diria ka mag handle kung unsay result sa imuha gipapili nga decision
            If result = DialogResult.Yes Then
                'then diria ka mag himo ug imuhang sql query to delete the record (specifically ang userID)
                Dim query As String = "DELETE FROM Users WHERE Id = @Id"

                'diria ka mag execute sa imuhang na create nga Delete Query
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Using cmd As New MySqlCommand(query, connection)
                        'diria nimo i identify napud ang UserID as parameter
                        cmd.Parameters.AddWithValue("@Id", Id)
                        cmd.Parameters.AddWithValue("@Name", txtName.Text)
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text)
                        cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text)
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text)

                        cmd.ExecuteNonQuery()
                    End Using
                    connection.Close()
                End Using
                LoadUsers()

                MessageBox.Show("User deleted successfully.")
            End If
        Else
            MessageBox.Show("Please select a user to delete")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected
        If dgvUsers.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvUsers.SelectedRows(0)
            ' Get the UserID (primary key) from the selected row
            Dim Id As Integer = CInt(selectedRow.Cells("Id").Value)

            ' Initialize the update query
            Dim query As String = "UPDATE Users SET "
            Dim hasUpdates As Boolean = False

            ' Dynamically build the query based on non-empty fields
            If Not String.IsNullOrEmpty(txtName.Text) Then
                query += "Name = @Name, "
                hasUpdates = True
            End If

            If Not String.IsNullOrEmpty(txtAge.Text) Then
                query += "Age = @Age, "
                hasUpdates = True
            End If

            If Not String.IsNullOrEmpty(txtContactNo.Text) Then
                query += "ContactNo = @ContactNo, "
                hasUpdates = True
            End If

            If Not String.IsNullOrEmpty(txtAddress.Text) Then
                query += "Address = @Address, "
                hasUpdates = True
            End If

            If Not String.IsNullOrEmpty(txtUsername.Text) Then
                query += "Username = @Username, "
                hasUpdates = True
            End If

            If Not String.IsNullOrEmpty(txtPassword.Text) Then
                query += "Password = @Password, "
                hasUpdates = True
            End If

            If Not String.IsNullOrEmpty(cmbRole.Text) Then
                query += "Role = @Role, "
                hasUpdates = True
            End If

            ' Remove the trailing comma if there are updates
            If hasUpdates Then
                query = query.Substring(0, query.Length - 2)
            End If

            ' Add the WHERE clause
            query += " WHERE Id = @Id"

            ' If no updates were specified, show a message and exit
            If Not hasUpdates Then
                MessageBox.Show("Please input the field you want to change.")
                Exit Sub
            End If

            ' Execute the update query
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Id", Id)

                    ' Add parameters for updated fields
                    If Not String.IsNullOrEmpty(txtName.Text) Then
                        cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtAge.Text) Then
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtContactNo.Text) Then
                        cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtAddress.Text) Then
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtUsername.Text) Then
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    End If

                    If Not String.IsNullOrEmpty(txtPassword.Text) Then
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    End If

                    If Not String.IsNullOrEmpty(cmbRole.Text) Then
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text)
                    End If

                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using

            ' Reload the DataGridView
            LoadUsers()

            MessageBox.Show("User updated Successfully.")
        Else
            MessageBox.Show("Please select a user to update.")
        End If
    End Sub







    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String

                If cmbCategory.SelectedIndex >= 0 Then ' Check if a valid item is selected
                    If cmbCategory.SelectedItem.ToString() = "All" Then
                        query = "SELECT * FROM users"
                    Else
                        query = "SELECT * FROM users WHERE Role = @Role"
                    End If

                    Using cmd As New MySqlCommand(query, connection)
                        If cmbCategory.SelectedItem.ToString() <> "All" Then
                            cmd.Parameters.AddWithValue("@Role", cmbCategory.SelectedItem.ToString())
                        End If

                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvUsers.DataSource = table
                    End Using
                End If

                connection.Close()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        ' Clear the search text box
        txtSearch.Text = String.Empty

        ' Reset the ComboBox selection
        cmbCategory.SelectedIndex = -1 ' No item selected

        ' Reload all data into the DataGridView
        LoadUsers()
    End Sub
End Class