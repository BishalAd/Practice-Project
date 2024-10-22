<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.CmbBillType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRevDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBillNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtRevenu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNepName = New System.Windows.Forms.TextBox()
        Me.TxtRegNo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtLetter = New System.Windows.Forms.Button()
        Me.ButtExport = New System.Windows.Forms.Button()
        Me.ButtPrint = New System.Windows.Forms.Button()
        Me.BtnYouTube = New System.Windows.Forms.Button()
        Me.BtnHlpBook = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.ButtUpdate = New System.Windows.Forms.Button()
        Me.ButtSearch = New System.Windows.Forms.Button()
        Me.lblNepNme = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbBillType
        '
        Me.CmbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbBillType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbBillType.FormattingEnabled = True
        Me.CmbBillType.Items.AddRange(New Object() {"साधारण", "दलित/महिला छुट", "अन्य"})
        Me.CmbBillType.Location = New System.Drawing.Point(849, 104)
        Me.CmbBillType.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CmbBillType.Name = "CmbBillType"
        Me.CmbBillType.Size = New System.Drawing.Size(102, 26)
        Me.CmbBillType.TabIndex = 229
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(737, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 45)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "रसिदको प्रकारः"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRevDate
        '
        Me.TxtRevDate.Font = New System.Drawing.Font("Copas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRevDate.Location = New System.Drawing.Point(559, 98)
        Me.TxtRevDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRevDate.Mask = "0000.00.00"
        Me.TxtRevDate.Name = "TxtRevDate"
        Me.TxtRevDate.Size = New System.Drawing.Size(103, 30)
        Me.TxtRevDate.TabIndex = 228
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(433, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 42)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "रसिदको मितिः"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtBillNo
        '
        Me.TxtBillNo.BackColor = System.Drawing.Color.White
        Me.TxtBillNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtBillNo.ForeColor = System.Drawing.Color.Blue
        Me.TxtBillNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtBillNo.Location = New System.Drawing.Point(308, 102)
        Me.TxtBillNo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtBillNo.Name = "TxtBillNo"
        Me.TxtBillNo.Size = New System.Drawing.Size(97, 19)
        Me.TxtBillNo.TabIndex = 227
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(226, 90)
        Me.Label18.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(190, 40)
        Me.Label18.TabIndex = 233
        Me.Label18.Text = "रसिद नं."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRevenu
        '
        Me.TxtRevenu.BackColor = System.Drawing.Color.White
        Me.TxtRevenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRevenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtRevenu.ForeColor = System.Drawing.Color.Blue
        Me.TxtRevenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtRevenu.Location = New System.Drawing.Point(106, 102)
        Me.TxtRevenu.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtRevenu.Name = "TxtRevenu"
        Me.TxtRevenu.Size = New System.Drawing.Size(101, 19)
        Me.TxtRevenu.TabIndex = 226
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(9, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 39)
        Me.Label4.TabIndex = 232
        Me.Label4.Text = "राजश्व रकमः-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNepName
        '
        Me.TxtNepName.BackColor = System.Drawing.Color.White
        Me.TxtNepName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNepName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtNepName.ForeColor = System.Drawing.Color.Blue
        Me.TxtNepName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtNepName.Location = New System.Drawing.Point(597, 28)
        Me.TxtNepName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtNepName.Name = "TxtNepName"
        Me.TxtNepName.Size = New System.Drawing.Size(328, 19)
        Me.TxtNepName.TabIndex = 225
        '
        'TxtRegNo
        '
        Me.TxtRegNo.BackColor = System.Drawing.Color.White
        Me.TxtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtRegNo.ForeColor = System.Drawing.Color.Blue
        Me.TxtRegNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtRegNo.Location = New System.Drawing.Point(94, 25)
        Me.TxtRegNo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtRegNo.Name = "TxtRegNo"
        Me.TxtRegNo.Size = New System.Drawing.Size(265, 22)
        Me.TxtRegNo.TabIndex = 224
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.ButtLetter)
        Me.Panel1.Controls.Add(Me.ButtExport)
        Me.Panel1.Controls.Add(Me.ButtPrint)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.ButtExit)
        Me.Panel1.Controls.Add(Me.ButtUpdate)
        Me.Panel1.Controls.Add(Me.ButtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(985, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 773)
        Me.Panel1.TabIndex = 236
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.Label44)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(213, 30)
        Me.Panel3.TabIndex = 84
        '
        'Label44
        '
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label44.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(30, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(153, 30)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Help"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnYouTube)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(183, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(30, 30)
        Me.Panel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnHlpBook)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(30, 30)
        Me.Panel4.TabIndex = 0
        '
        'ButtLetter
        '
        Me.ButtLetter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtLetter.BackColor = System.Drawing.Color.White
        Me.ButtLetter.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.ButtLetter.FlatAppearance.BorderSize = 2
        Me.ButtLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtLetter.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtLetter.Image = CType(resources.GetObject("ButtLetter.Image"), System.Drawing.Image)
        Me.ButtLetter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtLetter.Location = New System.Drawing.Point(38, 478)
        Me.ButtLetter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtLetter.Name = "ButtLetter"
        Me.ButtLetter.Size = New System.Drawing.Size(131, 35)
        Me.ButtLetter.TabIndex = 85
        Me.ButtLetter.Text = "चिठी प्रिन्ट"
        Me.ButtLetter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtLetter.UseVisualStyleBackColor = False
        '
        'ButtExport
        '
        Me.ButtExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtExport.BackColor = System.Drawing.Color.White
        Me.ButtExport.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.ButtExport.FlatAppearance.BorderSize = 2
        Me.ButtExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtExport.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtExport.Image = CType(resources.GetObject("ButtExport.Image"), System.Drawing.Image)
        Me.ButtExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtExport.Location = New System.Drawing.Point(38, 600)
        Me.ButtExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtExport.Name = "ButtExport"
        Me.ButtExport.Size = New System.Drawing.Size(131, 35)
        Me.ButtExport.TabIndex = 87
        Me.ButtExport.Text = "Export"
        Me.ButtExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtExport.UseVisualStyleBackColor = False
        '
        'ButtPrint
        '
        Me.ButtPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtPrint.BackColor = System.Drawing.Color.White
        Me.ButtPrint.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.ButtPrint.FlatAppearance.BorderSize = 2
        Me.ButtPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtPrint.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtPrint.Image = CType(resources.GetObject("ButtPrint.Image"), System.Drawing.Image)
        Me.ButtPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtPrint.Location = New System.Drawing.Point(38, 540)
        Me.ButtPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtPrint.Name = "ButtPrint"
        Me.ButtPrint.Size = New System.Drawing.Size(131, 35)
        Me.ButtPrint.TabIndex = 86
        Me.ButtPrint.Text = "प्रिन्ट गर्ने"
        Me.ButtPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtPrint.UseVisualStyleBackColor = False
        '
        'BtnYouTube
        '
        Me.BtnYouTube.BackgroundImage = CType(resources.GetObject("BtnYouTube.BackgroundImage"), System.Drawing.Image)
        Me.BtnYouTube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnYouTube.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnYouTube.ForeColor = System.Drawing.Color.Transparent
        Me.BtnYouTube.Location = New System.Drawing.Point(0, 0)
        Me.BtnYouTube.Name = "BtnYouTube"
        Me.BtnYouTube.Size = New System.Drawing.Size(30, 30)
        Me.BtnYouTube.TabIndex = 0
        Me.BtnYouTube.UseVisualStyleBackColor = True
        '
        'BtnHlpBook
        '
        Me.BtnHlpBook.BackgroundImage = CType(resources.GetObject("BtnHlpBook.BackgroundImage"), System.Drawing.Image)
        Me.BtnHlpBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHlpBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnHlpBook.Location = New System.Drawing.Point(0, 0)
        Me.BtnHlpBook.Name = "BtnHlpBook"
        Me.BtnHlpBook.Size = New System.Drawing.Size(30, 30)
        Me.BtnHlpBook.TabIndex = 0
        Me.BtnHlpBook.UseVisualStyleBackColor = True
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtExit.BackColor = System.Drawing.Color.White
        Me.ButtExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtExit.FlatAppearance.BorderSize = 2
        Me.ButtExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtExit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtExit.Image = CType(resources.GetObject("ButtExit.Image"), System.Drawing.Image)
        Me.ButtExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtExit.Location = New System.Drawing.Point(38, 668)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtExit.Name = "ButtExit"
        Me.ButtExit.Size = New System.Drawing.Size(131, 35)
        Me.ButtExit.TabIndex = 2
        Me.ButtExit.Text = "बन्द गर्ने"
        Me.ButtExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtExit.UseVisualStyleBackColor = False
        '
        'ButtUpdate
        '
        Me.ButtUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtUpdate.BackColor = System.Drawing.Color.White
        Me.ButtUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.ButtUpdate.FlatAppearance.BorderSize = 2
        Me.ButtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtUpdate.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtUpdate.Image = CType(resources.GetObject("ButtUpdate.Image"), System.Drawing.Image)
        Me.ButtUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtUpdate.Location = New System.Drawing.Point(38, 417)
        Me.ButtUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtUpdate.Name = "ButtUpdate"
        Me.ButtUpdate.Size = New System.Drawing.Size(131, 35)
        Me.ButtUpdate.TabIndex = 1
        Me.ButtUpdate.Text = "संशोधन गर्ने"
        Me.ButtUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtUpdate.UseVisualStyleBackColor = False
        '
        'ButtSearch
        '
        Me.ButtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtSearch.BackColor = System.Drawing.Color.White
        Me.ButtSearch.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.ButtSearch.FlatAppearance.BorderSize = 2
        Me.ButtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtSearch.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtSearch.Image = CType(resources.GetObject("ButtSearch.Image"), System.Drawing.Image)
        Me.ButtSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtSearch.Location = New System.Drawing.Point(38, 351)
        Me.ButtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtSearch.Name = "ButtSearch"
        Me.ButtSearch.Size = New System.Drawing.Size(131, 35)
        Me.ButtSearch.TabIndex = 0
        Me.ButtSearch.Text = "देखाउने"
        Me.ButtSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtSearch.UseVisualStyleBackColor = False
        '
        'lblNepNme
        '
        Me.lblNepNme.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNepNme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNepNme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNepNme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNepNme.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNepNme.ForeColor = System.Drawing.Color.Maroon
        Me.lblNepNme.Image = CType(resources.GetObject("lblNepNme.Image"), System.Drawing.Image)
        Me.lblNepNme.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNepNme.Location = New System.Drawing.Point(408, 17)
        Me.lblNepNme.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.lblNepNme.Name = "lblNepNme"
        Me.lblNepNme.Size = New System.Drawing.Size(557, 39)
        Me.lblNepNme.TabIndex = 231
        Me.lblNepNme.Text = "फर्मको नाम (देवनागरीमा):"
        Me.lblNepNme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRegNo
        '
        Me.lblRegNo.BackColor = System.Drawing.Color.Maroon
        Me.lblRegNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRegNo.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNo.ForeColor = System.Drawing.Color.White
        Me.lblRegNo.Image = CType(resources.GetObject("lblRegNo.Image"), System.Drawing.Image)
        Me.lblRegNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRegNo.Location = New System.Drawing.Point(9, 14)
        Me.lblRegNo.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(376, 46)
        Me.lblRegNo.TabIndex = 230
        Me.lblRegNo.Text = "दर्ता नम्वरः"
        Me.lblRegNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(-1, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 838)
        Me.Panel2.TabIndex = 237
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 773)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmbBillType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtRevDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBillNo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtRevenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNepName)
        Me.Controls.Add(Me.lblNepNme)
        Me.Controls.Add(Me.TxtRegNo)
        Me.Controls.Add(Me.lblRegNo)
        Me.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbBillType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRevDate As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBillNo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtRevenu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNepName As TextBox
    Friend WithEvents lblNepNme As Label
    Friend WithEvents TxtRegNo As TextBox
    Friend WithEvents lblRegNo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtLetter As Button
    Friend WithEvents ButtExport As Button
    Friend WithEvents ButtPrint As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnYouTube As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnHlpBook As Button
    Friend WithEvents ButtExit As Button
    Friend WithEvents ButtUpdate As Button
    Friend WithEvents ButtSearch As Button
    Friend WithEvents Panel2 As Panel
End Class
