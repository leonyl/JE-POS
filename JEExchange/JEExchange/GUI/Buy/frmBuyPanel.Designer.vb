<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyPanel))
        Me.panelSell = New System.Windows.Forms.Panel()
        Me.panelSearch = New System.Windows.Forms.Panel()
        Me.addcusDisabled = New System.Windows.Forms.PictureBox()
        Me.addcusEnabled = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.boxBuyForm = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vgmsDisabled = New System.Windows.Forms.PictureBox()
        Me.jewelryDisabled = New System.Windows.Forms.PictureBox()
        Me.jewelryEnabled = New System.Windows.Forms.PictureBox()
        Me.vgmsEnabled = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuyDisabled = New System.Windows.Forms.PictureBox()
        Me.btnBuyEnabled = New System.Windows.Forms.PictureBox()
        Me.btnAppCredDisabled = New System.Windows.Forms.PictureBox()
        Me.btnAppCredEnabled = New System.Windows.Forms.PictureBox()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.panelAddCustomer = New System.Windows.Forms.Panel()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnCloseCusDisabled = New System.Windows.Forms.PictureBox()
        Me.btnCloseCusEnabled = New System.Windows.Forms.PictureBox()
        Me.btnAddCusDisabled = New System.Windows.Forms.PictureBox()
        Me.btnAddCusEnabled = New System.Windows.Forms.PictureBox()
        Me.btnSearchCus = New System.Windows.Forms.Button()
        Me.btnSearchCus2 = New System.Windows.Forms.Button()
        Me.toolSidebar = New System.Windows.Forms.ToolStrip()
        Me.btnSBBuy = New System.Windows.Forms.ToolStripButton()
        Me.btnSBSell = New System.Windows.Forms.ToolStripButton()
        Me.btnSBTrade = New System.Windows.Forms.ToolStripButton()
        Me.btnSBLayaway = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.panelSell.SuspendLayout()
        Me.panelSearch.SuspendLayout()
        CType(Me.addcusDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addcusEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxBuyForm.SuspendLayout()
        CType(Me.vgmsDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jewelryDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jewelryEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgmsEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuyDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuyEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAppCredDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAppCredEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAddCustomer.SuspendLayout()
        CType(Me.btnCloseCusDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseCusEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddCusDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddCusEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSell
        '
        Me.panelSell.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelSell.Controls.Add(Me.panelSearch)
        Me.panelSell.Controls.Add(Me.panelAddCustomer)
        Me.panelSell.Controls.Add(Me.btnSearchCus)
        Me.panelSell.Controls.Add(Me.btnSearchCus2)
        Me.panelSell.Controls.Add(Me.boxBuyForm)
        Me.panelSell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSell.Location = New System.Drawing.Point(100, 0)
        Me.panelSell.Name = "panelSell"
        Me.panelSell.Size = New System.Drawing.Size(1280, 760)
        Me.panelSell.TabIndex = 10
        '
        'panelSearch
        '
        Me.panelSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelSearch.BackgroundImage = CType(resources.GetObject("panelSearch.BackgroundImage"), System.Drawing.Image)
        Me.panelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelSearch.Controls.Add(Me.addcusDisabled)
        Me.panelSearch.Controls.Add(Me.addcusEnabled)
        Me.panelSearch.Controls.Add(Me.TextBox2)
        Me.panelSearch.Controls.Add(Me.ListView1)
        Me.panelSearch.Location = New System.Drawing.Point(7, 45)
        Me.panelSearch.Name = "panelSearch"
        Me.panelSearch.Size = New System.Drawing.Size(282, 616)
        Me.panelSearch.TabIndex = 29
        Me.panelSearch.Visible = False
        '
        'addcusDisabled
        '
        Me.addcusDisabled.BackColor = System.Drawing.Color.Transparent
        Me.addcusDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addcusDisabled.Image = CType(resources.GetObject("addcusDisabled.Image"), System.Drawing.Image)
        Me.addcusDisabled.Location = New System.Drawing.Point(25, 553)
        Me.addcusDisabled.Name = "addcusDisabled"
        Me.addcusDisabled.Size = New System.Drawing.Size(231, 58)
        Me.addcusDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.addcusDisabled.TabIndex = 2
        Me.addcusDisabled.TabStop = False
        '
        'addcusEnabled
        '
        Me.addcusEnabled.BackColor = System.Drawing.Color.Transparent
        Me.addcusEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addcusEnabled.Image = CType(resources.GetObject("addcusEnabled.Image"), System.Drawing.Image)
        Me.addcusEnabled.Location = New System.Drawing.Point(25, 553)
        Me.addcusEnabled.Name = "addcusEnabled"
        Me.addcusEnabled.Size = New System.Drawing.Size(231, 58)
        Me.addcusEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.addcusEnabled.TabIndex = 3
        Me.addcusEnabled.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(65, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 15)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Search...."
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(30, 123)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(220, 397)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'boxBuyForm
        '
        Me.boxBuyForm.BackColor = System.Drawing.Color.Transparent
        Me.boxBuyForm.BackgroundImage = CType(resources.GetObject("boxBuyForm.BackgroundImage"), System.Drawing.Image)
        Me.boxBuyForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.boxBuyForm.Controls.Add(Me.Label3)
        Me.boxBuyForm.Controls.Add(Me.vgmsDisabled)
        Me.boxBuyForm.Controls.Add(Me.jewelryDisabled)
        Me.boxBuyForm.Controls.Add(Me.jewelryEnabled)
        Me.boxBuyForm.Controls.Add(Me.vgmsEnabled)
        Me.boxBuyForm.Controls.Add(Me.Label10)
        Me.boxBuyForm.Controls.Add(Me.Label9)
        Me.boxBuyForm.Controls.Add(Me.Label2)
        Me.boxBuyForm.Controls.Add(Me.Label1)
        Me.boxBuyForm.Controls.Add(Me.btnBuyDisabled)
        Me.boxBuyForm.Controls.Add(Me.btnBuyEnabled)
        Me.boxBuyForm.Controls.Add(Me.btnAppCredDisabled)
        Me.boxBuyForm.Controls.Add(Me.btnAppCredEnabled)
        Me.boxBuyForm.Controls.Add(Me.ListView4)
        Me.boxBuyForm.Controls.Add(Me.TextBox5)
        Me.boxBuyForm.Controls.Add(Me.Label35)
        Me.boxBuyForm.Location = New System.Drawing.Point(550, 45)
        Me.boxBuyForm.Name = "boxBuyForm"
        Me.boxBuyForm.Size = New System.Drawing.Size(1043, 616)
        Me.boxBuyForm.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(904, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 39)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "20"
        '
        'vgmsDisabled
        '
        Me.vgmsDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vgmsDisabled.Image = CType(resources.GetObject("vgmsDisabled.Image"), System.Drawing.Image)
        Me.vgmsDisabled.Location = New System.Drawing.Point(415, 396)
        Me.vgmsDisabled.Name = "vgmsDisabled"
        Me.vgmsDisabled.Size = New System.Drawing.Size(160, 37)
        Me.vgmsDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.vgmsDisabled.TabIndex = 100
        Me.vgmsDisabled.TabStop = False
        '
        'jewelryDisabled
        '
        Me.jewelryDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.jewelryDisabled.Image = CType(resources.GetObject("jewelryDisabled.Image"), System.Drawing.Image)
        Me.jewelryDisabled.Location = New System.Drawing.Point(577, 396)
        Me.jewelryDisabled.Name = "jewelryDisabled"
        Me.jewelryDisabled.Size = New System.Drawing.Size(160, 37)
        Me.jewelryDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.jewelryDisabled.TabIndex = 101
        Me.jewelryDisabled.TabStop = False
        '
        'jewelryEnabled
        '
        Me.jewelryEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.jewelryEnabled.Image = CType(resources.GetObject("jewelryEnabled.Image"), System.Drawing.Image)
        Me.jewelryEnabled.Location = New System.Drawing.Point(577, 396)
        Me.jewelryEnabled.Name = "jewelryEnabled"
        Me.jewelryEnabled.Size = New System.Drawing.Size(160, 37)
        Me.jewelryEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.jewelryEnabled.TabIndex = 103
        Me.jewelryEnabled.TabStop = False
        '
        'vgmsEnabled
        '
        Me.vgmsEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vgmsEnabled.Image = CType(resources.GetObject("vgmsEnabled.Image"), System.Drawing.Image)
        Me.vgmsEnabled.Location = New System.Drawing.Point(415, 396)
        Me.vgmsEnabled.Name = "vgmsEnabled"
        Me.vgmsEnabled.Size = New System.Drawing.Size(160, 37)
        Me.vgmsEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.vgmsEnabled.TabIndex = 102
        Me.vgmsEnabled.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Brown
        Me.Label10.Location = New System.Drawing.Point(875, 464)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(704, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 17)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Credit Available"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(723, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "25.00$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(844, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "25,000.00$"
        '
        'btnBuyDisabled
        '
        Me.btnBuyDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuyDisabled.Image = CType(resources.GetObject("btnBuyDisabled.Image"), System.Drawing.Image)
        Me.btnBuyDisabled.Location = New System.Drawing.Point(855, 525)
        Me.btnBuyDisabled.Name = "btnBuyDisabled"
        Me.btnBuyDisabled.Size = New System.Drawing.Size(95, 35)
        Me.btnBuyDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuyDisabled.TabIndex = 78
        Me.btnBuyDisabled.TabStop = False
        '
        'btnBuyEnabled
        '
        Me.btnBuyEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuyEnabled.Image = CType(resources.GetObject("btnBuyEnabled.Image"), System.Drawing.Image)
        Me.btnBuyEnabled.Location = New System.Drawing.Point(855, 525)
        Me.btnBuyEnabled.Name = "btnBuyEnabled"
        Me.btnBuyEnabled.Size = New System.Drawing.Size(95, 35)
        Me.btnBuyEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuyEnabled.TabIndex = 79
        Me.btnBuyEnabled.TabStop = False
        '
        'btnAppCredDisabled
        '
        Me.btnAppCredDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppCredDisabled.Image = CType(resources.GetObject("btnAppCredDisabled.Image"), System.Drawing.Image)
        Me.btnAppCredDisabled.Location = New System.Drawing.Point(713, 525)
        Me.btnAppCredDisabled.Name = "btnAppCredDisabled"
        Me.btnAppCredDisabled.Size = New System.Drawing.Size(95, 34)
        Me.btnAppCredDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAppCredDisabled.TabIndex = 76
        Me.btnAppCredDisabled.TabStop = False
        '
        'btnAppCredEnabled
        '
        Me.btnAppCredEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppCredEnabled.Image = CType(resources.GetObject("btnAppCredEnabled.Image"), System.Drawing.Image)
        Me.btnAppCredEnabled.Location = New System.Drawing.Point(713, 525)
        Me.btnAppCredEnabled.Name = "btnAppCredEnabled"
        Me.btnAppCredEnabled.Size = New System.Drawing.Size(95, 34)
        Me.btnAppCredEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAppCredEnabled.TabIndex = 77
        Me.btnAppCredEnabled.TabStop = False
        '
        'ListView4
        '
        Me.ListView4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(94, 100)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(852, 281)
        Me.ListView4.TabIndex = 66
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox5.Location = New System.Drawing.Point(398, 466)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(264, 97)
        Me.TextBox5.TabIndex = 65
        Me.TextBox5.Text = "Enter notes here...."
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Brown
        Me.Label35.Location = New System.Drawing.Point(136, 41)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(148, 29)
        Me.Label35.TabIndex = 50
        Me.Label35.Text = "Rj D. Madia"
        '
        'panelAddCustomer
        '
        Me.panelAddCustomer.BackColor = System.Drawing.Color.Transparent
        Me.panelAddCustomer.BackgroundImage = CType(resources.GetObject("panelAddCustomer.BackgroundImage"), System.Drawing.Image)
        Me.panelAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelAddCustomer.Controls.Add(Me.TextBox9)
        Me.panelAddCustomer.Controls.Add(Me.TextBox8)
        Me.panelAddCustomer.Controls.Add(Me.TextBox7)
        Me.panelAddCustomer.Controls.Add(Me.TextBox6)
        Me.panelAddCustomer.Controls.Add(Me.TextBox4)
        Me.panelAddCustomer.Controls.Add(Me.TextBox3)
        Me.panelAddCustomer.Controls.Add(Me.btnCloseCusDisabled)
        Me.panelAddCustomer.Controls.Add(Me.btnCloseCusEnabled)
        Me.panelAddCustomer.Controls.Add(Me.btnAddCusDisabled)
        Me.panelAddCustomer.Controls.Add(Me.btnAddCusEnabled)
        Me.panelAddCustomer.Location = New System.Drawing.Point(280, 117)
        Me.panelAddCustomer.Name = "panelAddCustomer"
        Me.panelAddCustomer.Size = New System.Drawing.Size(323, 473)
        Me.panelAddCustomer.TabIndex = 34
        Me.panelAddCustomer.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(55, 28)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(161, 15)
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.Text = "ID No"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(55, 243)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(161, 15)
        Me.TextBox8.TabIndex = 8
        Me.TextBox8.Text = "Address"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(57, 194)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(161, 15)
        Me.TextBox7.TabIndex = 7
        Me.TextBox7.Text = "Phone"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(57, 151)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(161, 15)
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Text = "Email"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(57, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(161, 15)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "Last Name"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(55, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 15)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "First Name"
        '
        'btnCloseCusDisabled
        '
        Me.btnCloseCusDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseCusDisabled.Image = CType(resources.GetObject("btnCloseCusDisabled.Image"), System.Drawing.Image)
        Me.btnCloseCusDisabled.Location = New System.Drawing.Point(34, 413)
        Me.btnCloseCusDisabled.Name = "btnCloseCusDisabled"
        Me.btnCloseCusDisabled.Size = New System.Drawing.Size(109, 33)
        Me.btnCloseCusDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCloseCusDisabled.TabIndex = 2
        Me.btnCloseCusDisabled.TabStop = False
        '
        'btnCloseCusEnabled
        '
        Me.btnCloseCusEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseCusEnabled.Image = CType(resources.GetObject("btnCloseCusEnabled.Image"), System.Drawing.Image)
        Me.btnCloseCusEnabled.Location = New System.Drawing.Point(34, 413)
        Me.btnCloseCusEnabled.Name = "btnCloseCusEnabled"
        Me.btnCloseCusEnabled.Size = New System.Drawing.Size(109, 33)
        Me.btnCloseCusEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCloseCusEnabled.TabIndex = 3
        Me.btnCloseCusEnabled.TabStop = False
        '
        'btnAddCusDisabled
        '
        Me.btnAddCusDisabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCusDisabled.Image = CType(resources.GetObject("btnAddCusDisabled.Image"), System.Drawing.Image)
        Me.btnAddCusDisabled.Location = New System.Drawing.Point(168, 413)
        Me.btnAddCusDisabled.Name = "btnAddCusDisabled"
        Me.btnAddCusDisabled.Size = New System.Drawing.Size(110, 33)
        Me.btnAddCusDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAddCusDisabled.TabIndex = 0
        Me.btnAddCusDisabled.TabStop = False
        '
        'btnAddCusEnabled
        '
        Me.btnAddCusEnabled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCusEnabled.Image = CType(resources.GetObject("btnAddCusEnabled.Image"), System.Drawing.Image)
        Me.btnAddCusEnabled.Location = New System.Drawing.Point(168, 414)
        Me.btnAddCusEnabled.Name = "btnAddCusEnabled"
        Me.btnAddCusEnabled.Size = New System.Drawing.Size(110, 33)
        Me.btnAddCusEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAddCusEnabled.TabIndex = 1
        Me.btnAddCusEnabled.TabStop = False
        '
        'btnSearchCus
        '
        Me.btnSearchCus.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCus.FlatAppearance.BorderSize = 0
        Me.btnSearchCus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearchCus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCus.Image = CType(resources.GetObject("btnSearchCus.Image"), System.Drawing.Image)
        Me.btnSearchCus.Location = New System.Drawing.Point(3, 188)
        Me.btnSearchCus.Name = "btnSearchCus"
        Me.btnSearchCus.Size = New System.Drawing.Size(42, 313)
        Me.btnSearchCus.TabIndex = 30
        Me.btnSearchCus.UseVisualStyleBackColor = False
        '
        'btnSearchCus2
        '
        Me.btnSearchCus2.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchCus2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCus2.FlatAppearance.BorderSize = 0
        Me.btnSearchCus2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearchCus2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearchCus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCus2.Image = CType(resources.GetObject("btnSearchCus2.Image"), System.Drawing.Image)
        Me.btnSearchCus2.Location = New System.Drawing.Point(6, 188)
        Me.btnSearchCus2.Name = "btnSearchCus2"
        Me.btnSearchCus2.Size = New System.Drawing.Size(42, 313)
        Me.btnSearchCus2.TabIndex = 33
        Me.btnSearchCus2.UseVisualStyleBackColor = False
        Me.btnSearchCus2.Visible = False
        '
        'toolSidebar
        '
        Me.toolSidebar.BackColor = System.Drawing.Color.Transparent
        Me.toolSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolSidebar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolSidebar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolSidebar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSBBuy, Me.btnSBSell, Me.btnSBTrade, Me.btnSBLayaway, Me.ToolStripButton9, Me.ToolStripButton10})
        Me.toolSidebar.Location = New System.Drawing.Point(0, 0)
        Me.toolSidebar.Name = "toolSidebar"
        Me.toolSidebar.Size = New System.Drawing.Size(100, 760)
        Me.toolSidebar.TabIndex = 36
        Me.toolSidebar.Text = "ToolStrip2"
        '
        'btnSBBuy
        '
        Me.btnSBBuy.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBBuy.Image = Global.JEExchange.My.Resources.Resources.buy
        Me.btnSBBuy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSBBuy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSBBuy.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.btnSBBuy.Name = "btnSBBuy"
        Me.btnSBBuy.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSBBuy.Size = New System.Drawing.Size(97, 87)
        Me.btnSBBuy.Text = "Buy"
        Me.btnSBBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSBSell
        '
        Me.btnSBSell.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBSell.Image = Global.JEExchange.My.Resources.Resources.sell
        Me.btnSBSell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSBSell.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSBSell.Name = "btnSBSell"
        Me.btnSBSell.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSBSell.Size = New System.Drawing.Size(97, 88)
        Me.btnSBSell.Text = "Sell"
        Me.btnSBSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSBTrade
        '
        Me.btnSBTrade.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBTrade.Image = Global.JEExchange.My.Resources.Resources.trade
        Me.btnSBTrade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSBTrade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSBTrade.Name = "btnSBTrade"
        Me.btnSBTrade.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSBTrade.Size = New System.Drawing.Size(97, 88)
        Me.btnSBTrade.Text = "Trade"
        Me.btnSBTrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSBLayaway
        '
        Me.btnSBLayaway.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBLayaway.Image = Global.JEExchange.My.Resources.Resources.layaway
        Me.btnSBLayaway.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSBLayaway.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSBLayaway.Name = "btnSBLayaway"
        Me.btnSBLayaway.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSBLayaway.Size = New System.Drawing.Size(97, 88)
        Me.btnSBLayaway.Text = "Layaway"
        Me.btnSBLayaway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton9.Image = Global.JEExchange.My.Resources.Resources.quote
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Padding = New System.Windows.Forms.Padding(3)
        Me.ToolStripButton9.Size = New System.Drawing.Size(97, 88)
        Me.ToolStripButton9.Text = "Quote"
        Me.ToolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton10.Image = Global.JEExchange.My.Resources.Resources.search_items
        Me.ToolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Padding = New System.Windows.Forms.Padding(3)
        Me.ToolStripButton10.Size = New System.Drawing.Size(97, 88)
        Me.ToolStripButton10.Text = "Search Items"
        Me.ToolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmBuyPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 760)
        Me.Controls.Add(Me.panelSell)
        Me.Controls.Add(Me.toolSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBuyPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy Panel"
        Me.panelSell.ResumeLayout(False)
        Me.panelSearch.ResumeLayout(False)
        Me.panelSearch.PerformLayout()
        CType(Me.addcusDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addcusEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxBuyForm.ResumeLayout(False)
        Me.boxBuyForm.PerformLayout()
        CType(Me.vgmsDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jewelryDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jewelryEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgmsEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuyDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuyEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAppCredDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAppCredEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAddCustomer.ResumeLayout(False)
        Me.panelAddCustomer.PerformLayout()
        CType(Me.btnCloseCusDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseCusEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddCusDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddCusEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolSidebar.ResumeLayout(False)
        Me.toolSidebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelSell As System.Windows.Forms.Panel
    Friend WithEvents panelSearch As System.Windows.Forms.Panel
    Friend WithEvents addcusDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents addcusEnabled As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents panelAddCustomer As System.Windows.Forms.Panel
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseCusDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseCusEnabled As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddCusDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddCusEnabled As System.Windows.Forms.PictureBox
    Private WithEvents btnSearchCus As System.Windows.Forms.Button
    Friend WithEvents boxBuyForm As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuyDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuyEnabled As System.Windows.Forms.PictureBox
    Friend WithEvents btnAppCredDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents btnAppCredEnabled As System.Windows.Forms.PictureBox
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Private WithEvents Label35 As System.Windows.Forms.Label
    Private WithEvents btnSearchCus2 As System.Windows.Forms.Button
    Friend WithEvents toolSidebar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSBBuy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSBSell As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSBTrade As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSBLayaway As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents jewelryEnabled As System.Windows.Forms.PictureBox
    Friend WithEvents vgmsEnabled As System.Windows.Forms.PictureBox
    Friend WithEvents jewelryDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents vgmsDisabled As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
