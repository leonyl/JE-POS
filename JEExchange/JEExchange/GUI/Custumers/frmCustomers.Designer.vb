<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Me.panelAddCustomer = New System.Windows.Forms.Panel()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnCloseDis = New System.Windows.Forms.PictureBox()
        Me.btnCloseEn = New System.Windows.Forms.PictureBox()
        Me.btnAddDis = New System.Windows.Forms.PictureBox()
        Me.btnAddEn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditDis = New System.Windows.Forms.PictureBox()
        Me.btnEditEn = New System.Windows.Forms.PictureBox()
        Me.btnDeleteDis = New System.Windows.Forms.PictureBox()
        Me.btnDeleteEn = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.panelAddCustomer.SuspendLayout()
        CType(Me.btnCloseDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddEn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteEn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.panelAddCustomer.Location = New System.Drawing.Point(-23, -8)
        Me.panelAddCustomer.Name = "panelAddCustomer"
        Me.panelAddCustomer.Size = New System.Drawing.Size(294, 459)
        Me.panelAddCustomer.TabIndex = 35
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(55, 28)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(205, 15)
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.Text = "ID No"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(55, 243)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(205, 146)
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
        Me.TextBox7.Size = New System.Drawing.Size(203, 15)
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
        Me.TextBox6.Size = New System.Drawing.Size(203, 15)
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
        Me.TextBox4.Size = New System.Drawing.Size(203, 15)
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
        Me.TextBox3.Size = New System.Drawing.Size(205, 15)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "First Name"
        '
        'btnCloseDis
        '
        Me.btnCloseDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseDis.Image = CType(resources.GetObject("btnCloseDis.Image"), System.Drawing.Image)
        Me.btnCloseDis.Location = New System.Drawing.Point(643, 367)
        Me.btnCloseDis.Name = "btnCloseDis"
        Me.btnCloseDis.Size = New System.Drawing.Size(109, 33)
        Me.btnCloseDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCloseDis.TabIndex = 2
        Me.btnCloseDis.TabStop = False
        '
        'btnCloseEn
        '
        Me.btnCloseEn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseEn.Image = CType(resources.GetObject("btnCloseEn.Image"), System.Drawing.Image)
        Me.btnCloseEn.Location = New System.Drawing.Point(643, 367)
        Me.btnCloseEn.Name = "btnCloseEn"
        Me.btnCloseEn.Size = New System.Drawing.Size(109, 33)
        Me.btnCloseEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCloseEn.TabIndex = 3
        Me.btnCloseEn.TabStop = False
        '
        'btnAddDis
        '
        Me.btnAddDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDis.Image = CType(resources.GetObject("btnAddDis.Image"), System.Drawing.Image)
        Me.btnAddDis.Location = New System.Drawing.Point(284, 366)
        Me.btnAddDis.Name = "btnAddDis"
        Me.btnAddDis.Size = New System.Drawing.Size(110, 33)
        Me.btnAddDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAddDis.TabIndex = 0
        Me.btnAddDis.TabStop = False
        '
        'btnAddEn
        '
        Me.btnAddEn.Image = CType(resources.GetObject("btnAddEn.Image"), System.Drawing.Image)
        Me.btnAddEn.Location = New System.Drawing.Point(284, 366)
        Me.btnAddEn.Name = "btnAddEn"
        Me.btnAddEn.Size = New System.Drawing.Size(109, 33)
        Me.btnAddEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAddEn.TabIndex = 1
        Me.btnAddEn.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(284, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 300)
        Me.Panel1.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(324, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 35)
        Me.Panel2.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(284, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnEditDis
        '
        Me.btnEditDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDis.Image = CType(resources.GetObject("btnEditDis.Image"), System.Drawing.Image)
        Me.btnEditDis.Location = New System.Drawing.Point(404, 366)
        Me.btnEditDis.Name = "btnEditDis"
        Me.btnEditDis.Size = New System.Drawing.Size(109, 33)
        Me.btnEditDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnEditDis.TabIndex = 39
        Me.btnEditDis.TabStop = False
        '
        'btnEditEn
        '
        Me.btnEditEn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditEn.Image = CType(resources.GetObject("btnEditEn.Image"), System.Drawing.Image)
        Me.btnEditEn.Location = New System.Drawing.Point(404, 366)
        Me.btnEditEn.Name = "btnEditEn"
        Me.btnEditEn.Size = New System.Drawing.Size(109, 33)
        Me.btnEditEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnEditEn.TabIndex = 40
        Me.btnEditEn.TabStop = False
        '
        'btnDeleteDis
        '
        Me.btnDeleteDis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteDis.Image = CType(resources.GetObject("btnDeleteDis.Image"), System.Drawing.Image)
        Me.btnDeleteDis.Location = New System.Drawing.Point(525, 366)
        Me.btnDeleteDis.Name = "btnDeleteDis"
        Me.btnDeleteDis.Size = New System.Drawing.Size(109, 33)
        Me.btnDeleteDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteDis.TabIndex = 41
        Me.btnDeleteDis.TabStop = False
        '
        'btnDeleteEn
        '
        Me.btnDeleteEn.Image = CType(resources.GetObject("btnDeleteEn.Image"), System.Drawing.Image)
        Me.btnDeleteEn.Location = New System.Drawing.Point(525, 366)
        Me.btnDeleteEn.Name = "btnDeleteEn"
        Me.btnDeleteEn.Size = New System.Drawing.Size(109, 33)
        Me.btnDeleteEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDeleteEn.TabIndex = 42
        Me.btnDeleteEn.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(467, 300)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(11, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(405, 19)
        Me.TextBox1.TabIndex = 0
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 414)
        Me.Controls.Add(Me.btnDeleteDis)
        Me.Controls.Add(Me.btnDeleteEn)
        Me.Controls.Add(Me.btnEditDis)
        Me.Controls.Add(Me.btnEditEn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelAddCustomer)
        Me.Controls.Add(Me.btnAddDis)
        Me.Controls.Add(Me.btnAddEn)
        Me.Controls.Add(Me.btnCloseDis)
        Me.Controls.Add(Me.btnCloseEn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.panelAddCustomer.ResumeLayout(False)
        Me.panelAddCustomer.PerformLayout()
        CType(Me.btnCloseDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddEn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteEn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelAddCustomer As System.Windows.Forms.Panel
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseEn As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddEn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditEn As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeleteDis As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeleteEn As System.Windows.Forms.PictureBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
