<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserMgt))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddDis = New System.Windows.Forms.PictureBox()
        Me.btnEditDis = New System.Windows.Forms.PictureBox()
        Me.btnDeleteDis = New System.Windows.Forms.PictureBox()
        Me.btnCloseDis = New System.Windows.Forms.PictureBox()
        Me.btnCloseEn = New System.Windows.Forms.PictureBox()
        Me.btnDeleteEn = New System.Windows.Forms.PictureBox()
        Me.btnEditEn = New System.Windows.Forms.PictureBox()
        Me.btnAddEn = New System.Windows.Forms.PictureBox()
        Me.btnCloseTop = New System.Windows.Forms.PictureBox()
        Me.lvUsers = New System.Windows.Forms.ListView()
        Me.panelAddUser = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        CType(Me.btnAddDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAddUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Location = New System.Drawing.Point(423, 35)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(159, 13)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Search...."
        '
        'btnAddDis
        '
        Me.btnAddDis.BackColor = System.Drawing.Color.Transparent
        Me.btnAddDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDis.Image = CType(resources.GetObject("btnAddDis.Image"), System.Drawing.Image)
        Me.btnAddDis.Location = New System.Drawing.Point(328, 361)
        Me.btnAddDis.Name = "btnAddDis"
        Me.btnAddDis.Size = New System.Drawing.Size(60, 26)
        Me.btnAddDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddDis.TabIndex = 1
        Me.btnAddDis.TabStop = False
        '
        'btnEditDis
        '
        Me.btnEditDis.BackColor = System.Drawing.Color.Transparent
        Me.btnEditDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDis.Image = CType(resources.GetObject("btnEditDis.Image"), System.Drawing.Image)
        Me.btnEditDis.Location = New System.Drawing.Point(398, 361)
        Me.btnEditDis.Name = "btnEditDis"
        Me.btnEditDis.Size = New System.Drawing.Size(60, 26)
        Me.btnEditDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEditDis.TabIndex = 2
        Me.btnEditDis.TabStop = False
        '
        'btnDeleteDis
        '
        Me.btnDeleteDis.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteDis.Image = CType(resources.GetObject("btnDeleteDis.Image"), System.Drawing.Image)
        Me.btnDeleteDis.Location = New System.Drawing.Point(469, 361)
        Me.btnDeleteDis.Name = "btnDeleteDis"
        Me.btnDeleteDis.Size = New System.Drawing.Size(60, 26)
        Me.btnDeleteDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDeleteDis.TabIndex = 3
        Me.btnDeleteDis.TabStop = False
        '
        'btnCloseDis
        '
        Me.btnCloseDis.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseDis.Image = CType(resources.GetObject("btnCloseDis.Image"), System.Drawing.Image)
        Me.btnCloseDis.Location = New System.Drawing.Point(540, 361)
        Me.btnCloseDis.Name = "btnCloseDis"
        Me.btnCloseDis.Size = New System.Drawing.Size(60, 26)
        Me.btnCloseDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCloseDis.TabIndex = 4
        Me.btnCloseDis.TabStop = False
        '
        'btnCloseEn
        '
        Me.btnCloseEn.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseEn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseEn.Image = CType(resources.GetObject("btnCloseEn.Image"), System.Drawing.Image)
        Me.btnCloseEn.Location = New System.Drawing.Point(540, 361)
        Me.btnCloseEn.Name = "btnCloseEn"
        Me.btnCloseEn.Size = New System.Drawing.Size(60, 26)
        Me.btnCloseEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCloseEn.TabIndex = 8
        Me.btnCloseEn.TabStop = False
        '
        'btnDeleteEn
        '
        Me.btnDeleteEn.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteEn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteEn.Image = CType(resources.GetObject("btnDeleteEn.Image"), System.Drawing.Image)
        Me.btnDeleteEn.Location = New System.Drawing.Point(469, 361)
        Me.btnDeleteEn.Name = "btnDeleteEn"
        Me.btnDeleteEn.Size = New System.Drawing.Size(60, 26)
        Me.btnDeleteEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDeleteEn.TabIndex = 7
        Me.btnDeleteEn.TabStop = False
        '
        'btnEditEn
        '
        Me.btnEditEn.BackColor = System.Drawing.Color.Transparent
        Me.btnEditEn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditEn.Image = CType(resources.GetObject("btnEditEn.Image"), System.Drawing.Image)
        Me.btnEditEn.Location = New System.Drawing.Point(398, 361)
        Me.btnEditEn.Name = "btnEditEn"
        Me.btnEditEn.Size = New System.Drawing.Size(60, 26)
        Me.btnEditEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEditEn.TabIndex = 6
        Me.btnEditEn.TabStop = False
        '
        'btnAddEn
        '
        Me.btnAddEn.BackColor = System.Drawing.Color.Transparent
        Me.btnAddEn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEn.Image = CType(resources.GetObject("btnAddEn.Image"), System.Drawing.Image)
        Me.btnAddEn.Location = New System.Drawing.Point(328, 361)
        Me.btnAddEn.Name = "btnAddEn"
        Me.btnAddEn.Size = New System.Drawing.Size(60, 26)
        Me.btnAddEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddEn.TabIndex = 5
        Me.btnAddEn.TabStop = False
        '
        'btnCloseTop
        '
        Me.btnCloseTop.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseTop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseTop.Image = CType(resources.GetObject("btnCloseTop.Image"), System.Drawing.Image)
        Me.btnCloseTop.Location = New System.Drawing.Point(606, 10)
        Me.btnCloseTop.Name = "btnCloseTop"
        Me.btnCloseTop.Size = New System.Drawing.Size(18, 17)
        Me.btnCloseTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCloseTop.TabIndex = 9
        Me.btnCloseTop.TabStop = False
        '
        'lvUsers
        '
        Me.lvUsers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvUsers.GridLines = True
        Me.lvUsers.Location = New System.Drawing.Point(490, 75)
        Me.lvUsers.Name = "lvUsers"
        Me.lvUsers.Size = New System.Drawing.Size(261, 258)
        Me.lvUsers.TabIndex = 10
        Me.lvUsers.UseCompatibleStateImageBehavior = False
        Me.lvUsers.View = System.Windows.Forms.View.Details
        '
        'panelAddUser
        '
        Me.panelAddUser.BackColor = System.Drawing.Color.Transparent
        Me.panelAddUser.Controls.Add(Me.GroupBox2)
        Me.panelAddUser.Controls.Add(Me.GroupBox1)
        Me.panelAddUser.Location = New System.Drawing.Point(335, 65)
        Me.panelAddUser.Name = "panelAddUser"
        Me.panelAddUser.Size = New System.Drawing.Size(259, 279)
        Me.panelAddUser.TabIndex = 17
        Me.panelAddUser.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(8, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 134)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login Info"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(85, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 23)
        Me.ComboBox1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "ID"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(85, 101)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 21)
        Me.TextBox3.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Usertype"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Password"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.Location = New System.Drawing.Point(85, 46)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(144, 21)
        Me.TextBox8.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Username"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox9.Location = New System.Drawing.Point(85, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(144, 21)
        Me.TextBox9.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 135)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Position"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(85, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 21)
        Me.TextBox2.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Middle Name"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(85, 73)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(144, 21)
        Me.TextBox5.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Last Name"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox6.Location = New System.Drawing.Point(85, 46)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(144, 21)
        Me.TextBox6.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "First Name"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(85, 19)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(144, 21)
        Me.TextBox7.TabIndex = 25
        '
        'frmUserMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(636, 399)
        Me.Controls.Add(Me.lvUsers)
        Me.Controls.Add(Me.panelAddUser)
        Me.Controls.Add(Me.btnCloseTop)
        Me.Controls.Add(Me.btnCloseDis)
        Me.Controls.Add(Me.btnDeleteDis)
        Me.Controls.Add(Me.btnEditDis)
        Me.Controls.Add(Me.btnAddDis)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnCloseEn)
        Me.Controls.Add(Me.btnDeleteEn)
        Me.Controls.Add(Me.btnEditEn)
        Me.Controls.Add(Me.btnAddEn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUserMgt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.btnAddDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAddUser.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAddDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeleteDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseEn As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeleteEn As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditEn As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddEn As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseTop As System.Windows.Forms.PictureBox
    Friend WithEvents lvUsers As System.Windows.Forms.ListView
    Friend WithEvents panelAddUser As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
End Class
