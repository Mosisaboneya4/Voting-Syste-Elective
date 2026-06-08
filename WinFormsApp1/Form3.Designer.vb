<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel1 = New Panel()
        Label1 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBoxFullName = New TextBox()
        TextBoxPassword = New TextBox()
        ButtonSaveProfile = New Button()
        Panel4 = New Panel()
        TextBox2 = New TextBox()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        DataGridView2 = New DataGridView()
        PanelVoteBox = New Panel()
        PanelCandidateBox = New Panel()
        PanelUserHeader = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        PanelVoteBox.SuspendLayout()
        PanelCandidateBox.SuspendLayout()
        PanelUserHeader.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(240, 650)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(51, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 4
        Label1.Text = "Admin Sidebar"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(220, 53, 69)
        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.BorderSize = 0
        Button4.ForeColor = Color.White
        Button4.Location = New Point(10, 334)
        Button4.Name = "Button4"
        Button4.Size = New Size(180, 45)
        Button4.TabIndex = 3
        Button4.Text = "Logout"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(42, 42, 42)
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button3.ForeColor = Color.White
        Button3.Location = New Point(10, 262)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 45)
        Button3.TabIndex = 2
        Button3.Text = "Profile"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(42, 42, 42)
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button2.ForeColor = Color.White
        Button2.Location = New Point(10, 179)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 45)
        Button2.TabIndex = 1
        Button2.Text = "Manage Vote"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(42, 42, 42)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = Color.White
        Button1.Location = New Point(10, 96)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 45)
        Button1.TabIndex = 0
        Button1.Text = "Manage Users"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(245, 245, 245)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel5)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(240, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(760, 650)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(ButtonSaveProfile)
        Panel5.Controls.Add(TextBoxPassword)
        Panel5.Controls.Add(TextBoxFullName)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Label2)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(760, 220)
        Panel5.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(180, 90)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 23)
        Label5.TabIndex = 3
        Label5.Text = "admin@example.com"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(55, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 20)
        Label4.TabIndex = 2
        Label4.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(55, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 1
        Label3.Text = "New Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(55, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 0
        Label2.Text = "Full Name:"
        ' 
        ' TextBoxFullName
        ' 
        TextBoxFullName.Location = New Point(180, 36)
        TextBoxFullName.Name = "TextBoxFullName"
        TextBoxFullName.Size = New Size(320, 27)
        TextBoxFullName.TabIndex = 4
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(180, 136)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        TextBoxPassword.Size = New Size(320, 27)
        TextBoxPassword.TabIndex = 5
        ' 
        ' ButtonSaveProfile
        ' 
        ButtonSaveProfile.BackColor = Color.FromArgb(33, 150, 243)
        ButtonSaveProfile.FlatStyle = FlatStyle.Flat
        ButtonSaveProfile.FlatAppearance.BorderSize = 0
        ButtonSaveProfile.ForeColor = Color.White
        ButtonSaveProfile.Location = New Point(180, 180)
        ButtonSaveProfile.Name = "ButtonSaveProfile"
        ButtonSaveProfile.Size = New Size(160, 36)
        ButtonSaveProfile.TabIndex = 6
        ButtonSaveProfile.Text = "Save Profile"
        ButtonSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(PanelCandidateBox)
        Panel4.Controls.Add(PanelVoteBox)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 140)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(600, 310)
        Panel4.TabIndex = 1
        ' 
        ' PanelVoteBox
        ' 
        PanelVoteBox.BackColor = Color.FromArgb(250, 250, 250)
        PanelVoteBox.Controls.Add(Button5)
        PanelVoteBox.Controls.Add(TextBox1)
        PanelVoteBox.Controls.Add(ListBox1)
        PanelVoteBox.Controls.Add(Label6)
        PanelVoteBox.Location = New Point(16, 16)
        PanelVoteBox.Name = "PanelVoteBox"
        PanelVoteBox.Size = New Size(270, 278)
        PanelVoteBox.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(33, 37, 41)
        Label6.Location = New Point(16, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 28)
        Label6.TabIndex = 0
        Label6.Text = "Vote List"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(16, 52)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(238, 140)
        ListBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(16, 204)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(238, 27)
        TextBox1.TabIndex = 2
        TextBox1.PlaceholderText = "Vote title"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(76, 175, 80)
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.White
        Button5.Location = New Point(16, 238)
        Button5.Name = "Button5"
        Button5.Size = New Size(238, 36)
        Button5.TabIndex = 3
        Button5.Text = "Add Vote"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' PanelCandidateBox
        ' 
        PanelCandidateBox.BackColor = Color.FromArgb(250, 250, 250)
        PanelCandidateBox.Controls.Add(Button7)
        PanelCandidateBox.Controls.Add(Button6)
        PanelCandidateBox.Controls.Add(TextBox2)
        PanelCandidateBox.Controls.Add(DataGridView2)
        PanelCandidateBox.Controls.Add(Label7)
        PanelCandidateBox.Location = New Point(304, 16)
        PanelCandidateBox.Name = "PanelCandidateBox"
        PanelCandidateBox.Size = New Size(420, 278)
        PanelCandidateBox.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(33, 37, 41)
        Label7.Location = New Point(16, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 28)
        Label7.TabIndex = 0
        Label7.Text = "Candidates"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.WhiteSmoke
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243)
        DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.Location = New Point(16, 52)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(388, 150)
        DataGridView2.TabIndex = 0
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(16, 214)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(248, 27)
        TextBox2.TabIndex = 6
        TextBox2.PlaceholderText = "Candidate name"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(33, 150, 243)
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.White
        Button6.Location = New Point(16, 245)
        Button6.Name = "Button6"
        Button6.Size = New Size(118, 36)
        Button6.TabIndex = 4
        Button6.Text = "Add Candidate"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(220, 53, 69)
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.White
        Button7.Location = New Point(146, 245)
        Button7.Name = "Button7"
        Button7.Size = New Size(118, 36)
        Button7.TabIndex = 5
        Button7.Text = "Delete Candidate"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(PanelUserHeader)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 380)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(600, 70)
        Panel3.TabIndex = 0
        ' 
        ' PanelUserHeader
        ' 
        PanelUserHeader.BackColor = Color.FromArgb(33, 150, 243)
        PanelUserHeader.Controls.Add(Label8)
        PanelUserHeader.Dock = DockStyle.Top
        PanelUserHeader.Location = New Point(0, 0)
        PanelUserHeader.Name = "PanelUserHeader"
        PanelUserHeader.Size = New Size(600, 60)
        PanelUserHeader.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(16, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(190, 32)
        Label8.TabIndex = 0
        Label8.Text = "Manage Users"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.WhiteSmoke
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 60)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(600, 10)
        DataGridView1.TabIndex = 0
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 650)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form3"
        Text = "ADMIN DASHBOARD"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        PanelVoteBox.ResumeLayout(False)
        PanelCandidateBox.ResumeLayout(False)
        PanelUserHeader.ResumeLayout(False)
        PanelUserHeader.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelVoteBox As Panel
    Friend WithEvents PanelCandidateBox As Panel
    Friend WithEvents PanelUserHeader As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxFullName As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonSaveProfile As Button
End Class
