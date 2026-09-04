Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login


    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles TxtUserName.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'sa yes mo log out
        If result = DialogResult.Yes Then
            Me.Hide() ' Hide the current form
        End If
    End Sub



    Private Sub CmbLogin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLogin.SelectedIndexChanged

        If CmbLogin.SelectedItem.ToString() = "Please select role" Then
            ' If placeholder is selected,mo reset ug mo kuan ang warning
            CmbLogin.SelectedIndex = 0
        Else

            Dim selectedRole As String = CmbLogin.SelectedItem.ToString()
            MessageBox.Show("You selected: " & selectedRole, "Role Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Check if username and password are entered
        If String.IsNullOrEmpty(TxtUserName.Text) OrElse String.IsNullOrEmpty(TxtPassword.Text) Then
            MessageBox.Show("Please enter your username and password.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the user has selected a valid role (not the placeholder)
        If CmbLogin.SelectedIndex = 0 Then
            MessageBox.Show("Please select a role before logging in", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate username and password against database
        Dim selectedRole As String = CmbLogin.SelectedItem.ToString()
        Dim username As String = TxtUserName.Text
        Dim password As String = TxtPassword.Text

        ' Replace with your actual connection string
        Dim connectionString As String = "Server=localhost;Database=coffee;Uid=root;"

        ' Use parameterized query to prevent SQL injection
        Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()  ' Read the first row (assuming unique username)

                    ' Check the retrieved role (assuming a "Role" field in the table)
                    Dim userRole As String = reader("Role").ToString()  ' Adjust column name if needed

                    reader.Close()

                    If userRole = "Admin" Then
                        Dim adminDashboard As New AdminDashboard
                        adminDashboard.Show()
                    ElseIf userRole = "Cashier" Then
                        Dim cashierDashboard As New CashierDashboard
                        cashierDashboard.Show()
                    Else
                        ' Handle unexpected roles or invalid data (optional)
                        MessageBox.Show("Invalid user role found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    Me.Hide() ' Hide the current login form
                Else
                    reader.Close()
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Initialize ComboBox with items
        CmbLogin.Items.Clear()
        CmbLogin.Items.Add("Please select role") ' Placeholder (non-selectable)
        CmbLogin.Items.Add("Admin")
        CmbLogin.Items.Add("Cashier")

        ' Set ComboBox to DropDownList to prevent typing
        CmbLogin.DropDownStyle = ComboBoxStyle.DropDownList
        CmbLogin.SelectedIndex = 0 ' Default selection to the placeholder
    End Sub


End Class
