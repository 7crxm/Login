Public Class frmLogin


    'CLOSE BUTTON
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'MINIMIZE BUTTON
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Remove the username text


        'Check if username is empty
        If txtUsername.Text.Trim() = "" Then

            MessageBox.Show("Please enter your username.",
                            "Unicloth",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtUsername.Focus()
            Exit Sub

        End If

        'Check if password is empty
        If txtPassword.Text.Trim() = "" Then

            MessageBox.Show("Please enter your password.",
                            "Unicloth",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtPassword.Focus()
            Exit Sub

        End If

        'Login credentials
        If (txtUsername.Text = "Timothy Agazon" AndAlso txtPassword.Text = "pogi123") Or
           (txtUsername.Text = "Kimberly Aliling" AndAlso txtPassword.Text = "monggoloid") Or
           (txtUsername.Text = "John Emmer Ablero" AndAlso txtPassword.Text = "bingot") Or
           (txtUsername.Text = "Raychelle Allapitan" AndAlso txtPassword.Text = "bading") Then

            MessageBox.Show("Welcome to Unicloth!",
                            "Login Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            '====================
            ' OPEN DASHBOARD FORM |
            '====================
            ' 1. Create a new instance of your clean dashboard class
            Dim dashboard As New frmDashboard()

            ' 2. Display the dashboard to the screen
            dashboard.Show()

            ' 3. Hide the login form so it isn't hanging around behind it
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End If

    End Sub

    'ENTER AND LEAVE EVENTS FOR USERNAME TEXTBOX
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter

        If txtUsername.Text = "Enter your username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.White
        End If

    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave

        If txtUsername.Text.Trim() = "" Then
            txtUsername.Text = "Enter your username"
            txtUsername.ForeColor = Color.Gray
        End If

    End Sub

    'ENTER AND LEAVE EVENTS FOR PASSWORD TEXTBOX
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter

        If txtPassword.Text = "Enter your password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.White
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        If txtPassword.Text.Trim() = "" Then
            txtPassword.Text = "Enter your password"
            txtPassword.ForeColor = Color.Gray
            txtPassword.UseSystemPasswordChar = False
        End If

    End Sub

    Private passwordVisible As Boolean = False

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnShowPassword.Click

        ' PASSWORD VISIBILITY TOGGLE BUTTON
        'Don't do anything if the textbox contains the placeholder
        If txtPassword.Text = "Enter your password" Then
            Exit Sub
        End If

        passwordVisible = Not passwordVisible

        If passwordVisible Then

            txtPassword.UseSystemPasswordChar = False
            btnShowPassword.Text = "◉"

        Else

            txtPassword.UseSystemPasswordChar = True
            btnShowPassword.Text = "👁"

        End If

        txtPassword.Focus()


    End Sub

End Class
