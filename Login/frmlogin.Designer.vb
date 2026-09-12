<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnShowPassword = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblSubtitle = New Label()
        lblWelcome = New Label()
        lblTagline = New Label()
        lblLogo = New Label()
        btnClose = New Button()
        btnMinimize = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        Panel1.Controls.Add(btnShowPassword)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(lblUsername)
        Panel1.Controls.Add(lblSubtitle)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Controls.Add(lblTagline)
        Panel1.Controls.Add(lblLogo)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnMinimize)
        Panel1.Location = New Point(1, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(484, 600)
        Panel1.TabIndex = 0
        ' 
        ' btnShowPassword
        ' 
        btnShowPassword.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(35))
        btnShowPassword.Cursor = Cursors.Hand
        btnShowPassword.FlatAppearance.BorderSize = 0
        btnShowPassword.FlatStyle = FlatStyle.Flat
        btnShowPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnShowPassword.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnShowPassword.Location = New Point(411, 375)
        btnShowPassword.Name = "btnShowPassword"
        btnShowPassword.Size = New Size(40, 29)
        btnShowPassword.TabIndex = 11
        btnShowPassword.TabStop = False
        btnShowPassword.Text = "👁"
        btnShowPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(50, 426)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(390, 50)
        btnLogin.TabIndex = 10
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(35))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.Gray
        txtPassword.Location = New Point(55, 375)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(350, 27)
        txtPassword.TabIndex = 9
        txtPassword.Text = "Enter your password"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(132), CByte(252))
        Label1.Location = New Point(55, 345)
        Label1.Name = "Label1"
        Label1.Size = New Size(390, 25)
        Label1.TabIndex = 8
        Label1.Text = "Password"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(35))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.Gray
        txtUsername.Location = New Point(55, 290)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(390, 27)
        txtUsername.TabIndex = 7
        txtUsername.Text = "Enter your username"
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 10F)
        lblUsername.ForeColor = Color.FromArgb(CByte(192), CByte(132), CByte(252))
        lblUsername.Location = New Point(55, 260)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(390, 25)
        lblUsername.TabIndex = 6
        lblUsername.Text = "Username"
        lblUsername.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.Silver
        lblSubtitle.Location = New Point(50, 210)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(370, 30)
        lblSubtitle.TabIndex = 5
        lblSubtitle.Text = "Log in to continue to Unicloth."
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWelcome
        ' 
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(50, 170)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(370, 45)
        lblWelcome.TabIndex = 4
        lblWelcome.Text = "Welcome Back!"
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTagline
        ' 
        lblTagline.BackColor = Color.Transparent
        lblTagline.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblTagline.Location = New Point(100, 118)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(300, 25)
        lblTagline.TabIndex = 3
        lblTagline.Text = "-----   C L O T H I N G  F O R  E V E R Y O N E   -----"
        lblTagline.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLogo
        ' 
        lblLogo.BackColor = Color.Transparent
        lblLogo.Font = New Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogo.ForeColor = Color.White
        lblLogo.Location = New Point(100, 70)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(300, 50)
        lblLogo.TabIndex = 2
        lblLogo.Text = "U N I C L O T H"
        lblLogo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnClose.Location = New Point(435, 15)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 31)
        btnClose.TabIndex = 1
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnMinimize
        ' 
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnMinimize.Location = New Point(405, 15)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(25, 25)
        btnMinimize.TabIndex = 0
        btnMinimize.Text = "-"
        btnMinimize.TextAlign = ContentAlignment.TopCenter
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        ClientSize = New Size(484, 661)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Unicloth - Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnShowPassword As Button

End Class
