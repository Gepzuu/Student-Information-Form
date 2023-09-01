<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textmname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gridlist = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butcreate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.butload = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.butdel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.butnew = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.butupdate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.textid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'textfname
        '
        Me.textfname.BackColor = System.Drawing.Color.Transparent
        Me.textfname.BorderRadius = 10
        Me.textfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textfname.DefaultText = ""
        Me.textfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textfname.Location = New System.Drawing.Point(22, 140)
        Me.textfname.Name = "textfname"
        Me.textfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textfname.PlaceholderText = "Firstname"
        Me.textfname.SelectedText = ""
        Me.textfname.Size = New System.Drawing.Size(232, 36)
        Me.textfname.TabIndex = 1
        '
        'textmname
        '
        Me.textmname.BackColor = System.Drawing.Color.Transparent
        Me.textmname.BorderRadius = 10
        Me.textmname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textmname.DefaultText = ""
        Me.textmname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textmname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textmname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textmname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textmname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textmname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textmname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textmname.Location = New System.Drawing.Point(22, 223)
        Me.textmname.Name = "textmname"
        Me.textmname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textmname.PlaceholderText = "Middlename"
        Me.textmname.SelectedText = ""
        Me.textmname.Size = New System.Drawing.Size(232, 36)
        Me.textmname.TabIndex = 2
        '
        'textlname
        '
        Me.textlname.BackColor = System.Drawing.Color.Transparent
        Me.textlname.BorderRadius = 10
        Me.textlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textlname.DefaultText = ""
        Me.textlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textlname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textlname.Location = New System.Drawing.Point(22, 304)
        Me.textlname.Name = "textlname"
        Me.textlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textlname.PlaceholderText = "Lastname"
        Me.textlname.SelectedText = ""
        Me.textlname.Size = New System.Drawing.Size(232, 36)
        Me.textlname.TabIndex = 3
        '
        'gridlist
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.gridlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.gridlist.BackgroundColor = System.Drawing.Color.DimGray
        Me.gridlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gridlist.ColumnHeadersHeight = 15
        Me.gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridlist.DefaultCellStyle = DataGridViewCellStyle9
        Me.gridlist.GridColor = System.Drawing.Color.Black
        Me.gridlist.Location = New System.Drawing.Point(280, 62)
        Me.gridlist.Name = "gridlist"
        Me.gridlist.RowHeadersVisible = False
        Me.gridlist.Size = New System.Drawing.Size(671, 384)
        Me.gridlist.TabIndex = 4
        Me.gridlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridlist.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridlist.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.gridlist.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.gridlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridlist.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridlist.ThemeStyle.HeaderStyle.Height = 15
        Me.gridlist.ThemeStyle.ReadOnly = False
        Me.gridlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridlist.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridlist.ThemeStyle.RowsStyle.Height = 22
        Me.gridlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "FirstName"
        Me.Column2.HeaderText = "FirstName"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "MiddleName"
        Me.Column3.HeaderText = "MiddleName"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "LastName"
        Me.Column4.HeaderText = "LastName"
        Me.Column4.Name = "Column4"
        '
        'butcreate
        '
        Me.butcreate.BackColor = System.Drawing.Color.Transparent
        Me.butcreate.BorderRadius = 3
        Me.butcreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.butcreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.butcreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butcreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butcreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.butcreate.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75!)
        Me.butcreate.ForeColor = System.Drawing.Color.White
        Me.butcreate.Location = New System.Drawing.Point(209, 3)
        Me.butcreate.Name = "butcreate"
        Me.butcreate.Size = New System.Drawing.Size(102, 38)
        Me.butcreate.TabIndex = 5
        Me.butcreate.Text = "CREATE"
        '
        'butload
        '
        Me.butload.Animated = True
        Me.butload.BackColor = System.Drawing.Color.Transparent
        Me.butload.BorderRadius = 10
        Me.butload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.butload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.butload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.butload.FillColor = System.Drawing.Color.Transparent
        Me.butload.FillColor2 = System.Drawing.Color.Aqua
        Me.butload.Font = New System.Drawing.Font("Tw Cen MT Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butload.ForeColor = System.Drawing.Color.Black
        Me.butload.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.butload.Location = New System.Drawing.Point(73, 375)
        Me.butload.Name = "butload"
        Me.butload.Size = New System.Drawing.Size(117, 40)
        Me.butload.TabIndex = 6
        Me.butload.Text = "LOAD"
        '
        'butdel
        '
        Me.butdel.BackColor = System.Drawing.Color.Transparent
        Me.butdel.BorderRadius = 3
        Me.butdel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.butdel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.butdel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butdel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butdel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.butdel.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdel.ForeColor = System.Drawing.Color.White
        Me.butdel.Location = New System.Drawing.Point(553, 3)
        Me.butdel.Name = "butdel"
        Me.butdel.Size = New System.Drawing.Size(96, 38)
        Me.butdel.TabIndex = 7
        Me.butdel.Text = "DELETE"
        '
        'butnew
        '
        Me.butnew.Animated = True
        Me.butnew.BackColor = System.Drawing.Color.Transparent
        Me.butnew.BorderRadius = 3
        Me.butnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.butnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.butnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butnew.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.butnew.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12.0!)
        Me.butnew.ForeColor = System.Drawing.Color.White
        Me.butnew.Location = New System.Drawing.Point(30, 3)
        Me.butnew.Name = "butnew"
        Me.butnew.Size = New System.Drawing.Size(98, 38)
        Me.butnew.TabIndex = 8
        Me.butnew.Text = "NEW"
        '
        'butupdate
        '
        Me.butupdate.Animated = True
        Me.butupdate.BackColor = System.Drawing.Color.Transparent
        Me.butupdate.BorderRadius = 3
        Me.butupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.butupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.butupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butupdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.butupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.butupdate.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75!)
        Me.butupdate.ForeColor = System.Drawing.Color.White
        Me.butupdate.Location = New System.Drawing.Point(387, 3)
        Me.butupdate.Name = "butupdate"
        Me.butupdate.Size = New System.Drawing.Size(96, 38)
        Me.butupdate.TabIndex = 9
        Me.butupdate.Text = "UPDATE"
        '
        'txtsearch
        '
        Me.txtsearch.Animated = True
        Me.txtsearch.AutoRoundedCorners = True
        Me.txtsearch.BorderRadius = 17
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(434, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "Search "
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.Size = New System.Drawing.Size(346, 36)
        Me.txtsearch.TabIndex = 10
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.BorderRadius = 3
        Me.Guna2GradientButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.75!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(800, 12)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(123, 36)
        Me.Guna2GradientButton1.TabIndex = 11
        Me.Guna2GradientButton1.Text = "Search LastName"
        Me.Guna2GradientButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.LinkLabel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.textlname)
        Me.Guna2GradientPanel1.Controls.Add(Me.textfname)
        Me.Guna2GradientPanel1.Controls.Add(Me.textmname)
        Me.Guna2GradientPanel1.Controls.Add(Me.butload)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Teal
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Crimson
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(274, 505)
        Me.Guna2GradientPanel1.TabIndex = 12
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 469)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 24)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(97, 62)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(71, 63)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 14
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Student Information"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.butnew)
        Me.Guna2GradientPanel2.Controls.Add(Me.butcreate)
        Me.Guna2GradientPanel2.Controls.Add(Me.butupdate)
        Me.Guna2GradientPanel2.Controls.Add(Me.butdel)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Crimson
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.Teal
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(274, 452)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(689, 53)
        Me.Guna2GradientPanel2.TabIndex = 13
        '
        'textid
        '
        Me.textid.BackColor = System.Drawing.Color.Transparent
        Me.textid.BorderRadius = 15
        Me.textid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textid.DefaultText = ""
        Me.textid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textid.FillColor = System.Drawing.Color.WhiteSmoke
        Me.textid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textid.Location = New System.Drawing.Point(290, 12)
        Me.textid.Name = "textid"
        Me.textid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textid.PlaceholderText = "StudentNo"
        Me.textid.SelectedText = ""
        Me.textid.Size = New System.Drawing.Size(93, 36)
        Me.textid.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.Location = New System.Drawing.Point(938, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(963, 505)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textid)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.gridlist)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textmname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gridlist As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents butcreate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents butload As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents butdel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents butnew As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents butupdate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents textid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
