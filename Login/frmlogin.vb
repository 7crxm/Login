Imports System.Data.SqlClient

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

        ' Database Login configuration
        Dim connString As String = "Server=localhost;Database=UniclothDB;Trusted_Connection=True;"
        Dim query As String = "SELECT COUNT(*) FROM dbo.UniclothDB WHERE Username = @Username AND Password = @Password"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)

                ' Pass data securely from the form fields
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())

                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Welcome to Unicloth!",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                        '====================
                        ' OPEN DASHBOARD FORM |
                        '====================
                        Dim dashboard As New frmDashboard()
                        dashboard.Show()
                        Me.Hide()
                    Else
                        ' Fails if no username/password match is found in the database
                        MessageBox.Show("Invalid username or password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    ' Alerts you if the database server isn't running or connected
                    MessageBox.Show("Database Connection Error: " & ex.Message,
                                "System Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                End Try

            End Using
        End Using

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
