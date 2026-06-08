<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelSidebar = New Panel()
        LabelTitle = New Label()
        ButtonLogout = New Button()
        ButtonProfile = New Button()
        ButtonVote = New Button()
        PanelHeader = New Panel()
        LabelHeader = New Label()
        LabelSubHeader = New Label()
        PanelContent = New Panel()
        PanelDashboard = New Panel()
        PanelProfile = New Panel()
        CardStats = New Panel()
        LabelStatTitle = New Label()
        LabelStatValue = New Label()
        DataGridView1 = New DataGridView()
        LabelUsername = New Label()
        LabelUsernameValue = New Label()
        LabelFullName = New Label()
        TextBoxFullName = New TextBox()
        LabelPassword = New Label()
        TextBoxPassword = New TextBox()
        ButtonSaveProfile = New Button()
        PanelSidebar.SuspendLayout()
        PanelHeader.SuspendLayout()
        PanelContent.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(24, 26, 32)
        PanelSidebar.Controls.Add(ButtonVote)
        PanelSidebar.Controls.Add(ButtonProfile)
        PanelSidebar.Controls.Add(ButtonLogout)
        PanelSidebar.Controls.Add(LabelTitle)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(220, 450)
        PanelSidebar.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.White
        LabelTitle.Location = New Point(20, 22)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(165, 32)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "User Dashboard"
        ' 
        ' ButtonLogout
        ' 
        ButtonLogout.BackColor = Color.FromArgb(211, 47, 47)
        ButtonLogout.FlatStyle = FlatStyle.Flat
        ButtonLogout.FlatAppearance.BorderSize = 0
        ButtonLogout.ForeColor = Color.White
        ButtonLogout.Location = New Point(20, 354)
        ButtonLogout.Name = "ButtonLogout"
        ButtonLogout.Size = New Size(180, 40)
        ButtonLogout.TabIndex = 1
        ButtonLogout.Text = "Logout"
        ButtonLogout.UseVisualStyleBackColor = False
        ' 
        ' ButtonProfile
        ' 
        ButtonProfile.BackColor = Color.FromArgb(48, 63, 159)
        ButtonProfile.FlatStyle = FlatStyle.Flat
        ButtonProfile.FlatAppearance.BorderSize = 0
        ButtonProfile.ForeColor = Color.White
        ButtonProfile.Location = New Point(20, 268)
        ButtonProfile.Name = "ButtonProfile"
        ButtonProfile.Size = New Size(180, 40)
        ButtonProfile.TabIndex = 2
        ButtonProfile.Text = "Profile"
        ButtonProfile.UseVisualStyleBackColor = False
        ' 
        ' ButtonVote
        ' 
        ButtonVote.BackColor = Color.FromArgb(76, 175, 80)
        ButtonVote.FlatStyle = FlatStyle.Flat
        ButtonVote.FlatAppearance.BorderSize = 0
        ButtonVote.ForeColor = Color.White
        ButtonVote.Location = New Point(20, 212)
        ButtonVote.Name = "ButtonVote"
        ButtonVote.Size = New Size(180, 40)
        ButtonVote.TabIndex = 3
        ButtonVote.Text = "Vote"
        ButtonVote.UseVisualStyleBackColor = False
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.White
        PanelHeader.Controls.Add(LabelHeader)
        PanelHeader.Controls.Add(LabelSubHeader)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(220, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(580, 140)
        PanelHeader.TabIndex = 1
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeader.ForeColor = Color.FromArgb(33, 37, 41)
        LabelHeader.Location = New Point(24, 28)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(260, 41)
        LabelHeader.TabIndex = 0
        LabelHeader.Text = "Welcome back, User"
        ' 
        ' LabelSubHeader
        ' 
        LabelSubHeader.AutoSize = True
        LabelSubHeader.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSubHeader.ForeColor = Color.DimGray
        LabelSubHeader.Location = New Point(24, 78)
        LabelSubHeader.Name = "LabelSubHeader"
        LabelSubHeader.Size = New Size(327, 23)
        LabelSubHeader.TabIndex = 1
        LabelSubHeader.Text = "Take part in the election and view your voting history."
        ' 
        ' PanelContent
        ' 
        PanelContent.BackColor = Color.FromArgb(245, 245, 245)
        PanelContent.Controls.Add(PanelProfile)
        PanelContent.Controls.Add(PanelDashboard)
        PanelContent.Dock = DockStyle.Fill
        PanelContent.Location = New Point(240, 140)
        PanelContent.Name = "PanelContent"
        PanelContent.Size = New Size(760, 510)
        PanelContent.TabIndex = 2
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.BackColor = Color.Transparent
        PanelDashboard.Controls.Add(CardStats)
        PanelDashboard.Controls.Add(DataGridView1)
        PanelDashboard.Dock = DockStyle.Fill
        PanelDashboard.Location = New Point(0, 0)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(760, 510)
        PanelDashboard.TabIndex = 0
        ' 
        ' PanelProfile
        ' 
        PanelProfile.BackColor = Color.White
        PanelProfile.Controls.Add(ButtonSaveProfile)
        PanelProfile.Controls.Add(TextBoxPassword)
        PanelProfile.Controls.Add(LabelPassword)
        PanelProfile.Controls.Add(TextBoxFullName)
        PanelProfile.Controls.Add(LabelFullName)
        PanelProfile.Controls.Add(LabelUsernameValue)
        PanelProfile.Controls.Add(LabelUsername)
        PanelProfile.Dock = DockStyle.Fill
        PanelProfile.Location = New Point(0, 0)
        PanelProfile.Name = "PanelProfile"
        PanelProfile.Size = New Size(760, 510)
        PanelProfile.TabIndex = 1
        PanelProfile.Visible = False
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUsername.ForeColor = Color.FromArgb(33, 37, 41)
        LabelUsername.Location = New Point(24, 24)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(91, 23)
        LabelUsername.TabIndex = 0
        LabelUsername.Text = "Username:"
        ' 
        ' LabelUsernameValue
        ' 
        LabelUsernameValue.AutoSize = True
        LabelUsernameValue.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelUsernameValue.ForeColor = Color.DimGray
        LabelUsernameValue.Location = New Point(180, 24)
        LabelUsernameValue.Name = "LabelUsernameValue"
        LabelUsernameValue.Size = New Size(113, 23)
        LabelUsernameValue.TabIndex = 1
        LabelUsernameValue.Text = "user@example.com"
        ' 
        ' LabelFullName
        ' 
        LabelFullName.AutoSize = True
        LabelFullName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelFullName.ForeColor = Color.FromArgb(33, 37, 41)
        LabelFullName.Location = New Point(24, 74)
        LabelFullName.Name = "LabelFullName"
        LabelFullName.Size = New Size(96, 23)
        LabelFullName.TabIndex = 2
        LabelFullName.Text = "Full Name:"
        ' 
        ' TextBoxFullName
        ' 
        TextBoxFullName.Location = New Point(180, 72)
        TextBoxFullName.Name = "TextBoxFullName"
        TextBoxFullName.Size = New Size(420, 27)
        TextBoxFullName.TabIndex = 3
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPassword.ForeColor = Color.FromArgb(33, 37, 41)
        LabelPassword.Location = New Point(24, 124)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(89, 23)
        LabelPassword.TabIndex = 4
        LabelPassword.Text = "Password:"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(180, 122)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        TextBoxPassword.Size = New Size(420, 27)
        TextBoxPassword.TabIndex = 5
        ' 
        ' ButtonSaveProfile
        ' 
        ButtonSaveProfile.BackColor = Color.FromArgb(33, 150, 243)
        ButtonSaveProfile.FlatStyle = FlatStyle.Flat
        ButtonSaveProfile.FlatAppearance.BorderSize = 0
        ButtonSaveProfile.ForeColor = Color.White
        ButtonSaveProfile.Location = New Point(180, 170)
        ButtonSaveProfile.Name = "ButtonSaveProfile"
        ButtonSaveProfile.Size = New Size(160, 36)
        ButtonSaveProfile.TabIndex = 6
        ButtonSaveProfile.Text = "Save Profile"
        ButtonSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' CardStats
        ' 
        CardStats.BackColor = Color.White
        CardStats.Controls.Add(LabelStatValue)
        CardStats.Controls.Add(LabelStatTitle)
        CardStats.Location = New Point(24, 24)
        CardStats.Name = "CardStats"
        CardStats.Size = New Size(524, 100)
        CardStats.TabIndex = 0
        ' 
        ' LabelStatTitle
        ' 
        LabelStatTitle.AutoSize = True
        LabelStatTitle.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelStatTitle.ForeColor = Color.FromArgb(33, 37, 41)
        LabelStatTitle.Location = New Point(20, 20)
        LabelStatTitle.Name = "LabelStatTitle"
        LabelStatTitle.Size = New Size(134, 23)
        LabelStatTitle.TabIndex = 0
        LabelStatTitle.Text = "Current Elections"
        ' 
        ' LabelStatValue
        ' 
        LabelStatValue.AutoSize = True
        LabelStatValue.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelStatValue.ForeColor = Color.FromArgb(76, 175, 80)
        LabelStatValue.Location = New Point(20, 48)
        LabelStatValue.Name = "LabelStatValue"
        LabelStatValue.Size = New Size(46, 46)
        LabelStatValue.TabIndex = 1
        LabelStatValue.Text = "05"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(24, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(710, 330)
        DataGridView1.TabIndex = 1
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1020, 650)
        Controls.Add(PanelContent)
        Controls.Add(PanelHeader)
        Controls.Add(PanelSidebar)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form4"
        Text = "USER DASHBOARD"
        PanelSidebar.ResumeLayout(False)
        PanelSidebar.PerformLayout()
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelContent.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents ButtonProfile As Button
    Friend WithEvents ButtonVote As Button
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents LabelSubHeader As Label
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents PanelProfile As Panel
    Friend WithEvents CardStats As Panel
    Friend WithEvents LabelStatTitle As Label
    Friend WithEvents LabelStatValue As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelUsernameValue As Label
    Friend WithEvents LabelFullName As Label
    Friend WithEvents TextBoxFullName As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonSaveProfile As Button
End Class
