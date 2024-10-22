<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.TxtRegNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNepName = New System.Windows.Forms.TextBox()
        Me.lblFirmName = New System.Windows.Forms.Label()
        Me.CmbBillType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRevDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBillNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtRevenu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.BtnYouTube = New System.Windows.Forms.Button()
        Me.BtnHlpBook = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtExport = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.ButtSearch = New System.Windows.Forms.Button()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtRegNo
        '
        Me.TxtRegNo.BackColor = System.Drawing.Color.White
        Me.TxtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TxtRegNo.ForeColor = System.Drawing.Color.Blue
        Me.TxtRegNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtRegNo.Location = New System.Drawing.Point(108, 16)
        Me.TxtRegNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRegNo.Name = "TxtRegNo"
        Me.TxtRegNo.Size = New System.Drawing.Size(249, 22)
        Me.TxtRegNo.TabIndex = 200
        Me.TxtRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(11, 10)
        Me.Label11.Margin = New System.Windows.Forms.Padding(12, 65, 3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(382, 34)
        Me.Label11.TabIndex = 201
        Me.Label11.Text = "दर्ता नम्वरः-"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNepName
        '
        Me.TxtNepName.BackColor = System.Drawing.Color.White
        Me.TxtNepName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNepName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtNepName.ForeColor = System.Drawing.Color.Blue
        Me.TxtNepName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtNepName.Location = New System.Drawing.Point(563, 18)
        Me.TxtNepName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNepName.Name = "TxtNepName"
        Me.TxtNepName.Size = New System.Drawing.Size(365, 19)
        Me.TxtNepName.TabIndex = 202
        '
        'lblFirmName
        '
        Me.lblFirmName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFirmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirmName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFirmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFirmName.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirmName.ForeColor = System.Drawing.Color.Maroon
        Me.lblFirmName.Image = CType(resources.GetObject("lblFirmName.Image"), System.Drawing.Image)
        Me.lblFirmName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirmName.Location = New System.Drawing.Point(450, 10)
        Me.lblFirmName.Margin = New System.Windows.Forms.Padding(12, 65, 3, 0)
        Me.lblFirmName.Name = "lblFirmName"
        Me.lblFirmName.Size = New System.Drawing.Size(505, 34)
        Me.lblFirmName.TabIndex = 203
        Me.lblFirmName.Text = "एजेन्सीको नामः-"
        Me.lblFirmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbBillType
        '
        Me.CmbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbBillType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbBillType.FormattingEnabled = True
        Me.CmbBillType.Items.AddRange(New Object() {"साधारण", "दलित/महिला छुट", "अन्य"})
        Me.CmbBillType.Location = New System.Drawing.Point(811, 71)
        Me.CmbBillType.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CmbBillType.Name = "CmbBillType"
        Me.CmbBillType.Size = New System.Drawing.Size(144, 26)
        Me.CmbBillType.TabIndex = 239
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(699, 61)
        Me.Label7.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 45)
        Me.Label7.TabIndex = 243
        Me.Label7.Text = "रसिदको प्रकारः"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRevDate
        '
        Me.TxtRevDate.Font = New System.Drawing.Font("Copas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRevDate.Location = New System.Drawing.Point(580, 71)
        Me.TxtRevDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRevDate.Mask = "0000.00.00"
        Me.TxtRevDate.Name = "TxtRevDate"
        Me.TxtRevDate.Size = New System.Drawing.Size(102, 30)
        Me.TxtRevDate.TabIndex = 238
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(454, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 42)
        Me.Label1.TabIndex = 242
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
        Me.TxtBillNo.Location = New System.Drawing.Point(342, 77)
        Me.TxtBillNo.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtBillNo.Name = "TxtBillNo"
        Me.TxtBillNo.Size = New System.Drawing.Size(91, 19)
        Me.TxtBillNo.TabIndex = 237
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(260, 65)
        Me.Label18.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(179, 40)
        Me.Label18.TabIndex = 241
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
        Me.TxtRevenu.Location = New System.Drawing.Point(108, 77)
        Me.TxtRevenu.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TxtRevenu.Name = "TxtRevenu"
        Me.TxtRevenu.Size = New System.Drawing.Size(126, 19)
        Me.TxtRevenu.TabIndex = 236
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(14, 93, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 39)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "राजश्व रकमः-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(11, 191)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 581)
        Me.Panel1.TabIndex = 244
        '
        'Label44
        '
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label44.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(30, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(138, 30)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Help"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.ButtExport)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ButtExit)
        Me.Panel2.Controls.Add(Me.ButtSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1000, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(198, 773)
        Me.Panel2.TabIndex = 245
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
        Me.ButtExport.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtExport.Location = New System.Drawing.Point(34, 650)
        Me.ButtExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtExport.Name = "ButtExport"
        Me.ButtExport.Size = New System.Drawing.Size(136, 35)
        Me.ButtExport.TabIndex = 87
        Me.ButtExport.Text = "खारेज गर्ने"
        Me.ButtExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtExport.UseVisualStyleBackColor = False
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
        Me.Panel3.Size = New System.Drawing.Size(198, 30)
        Me.Panel3.TabIndex = 84
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnYouTube)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(168, 0)
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
        Me.ButtExit.Location = New System.Drawing.Point(35, 722)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtExit.Name = "ButtExit"
        Me.ButtExit.Size = New System.Drawing.Size(136, 35)
        Me.ButtExit.TabIndex = 2
        Me.ButtExit.Text = "बन्द गर्ने"
        Me.ButtExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtExit.UseVisualStyleBackColor = False
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
        Me.ButtSearch.Location = New System.Drawing.Point(32, 570)
        Me.ButtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtSearch.Name = "ButtSearch"
        Me.ButtSearch.Size = New System.Drawing.Size(136, 35)
        Me.ButtSearch.TabIndex = 0
        Me.ButtSearch.Text = "देखाउने"
        Me.ButtSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtSearch.UseVisualStyleBackColor = False
        '
        'TxtRemarks
        '
        Me.TxtRemarks.BackColor = System.Drawing.Color.White
        Me.TxtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtRemarks.ForeColor = System.Drawing.Color.Blue
        Me.TxtRemarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtRemarks.Location = New System.Drawing.Point(101, 140)
        Me.TxtRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(841, 19)
        Me.TxtRemarks.TabIndex = 246
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(11, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(12, 65, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(944, 41)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "कैफियत :-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 773)
        Me.Controls.Add(Me.TxtRemarks)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.lblFirmName)
        Me.Controls.Add(Me.TxtRegNo)
        Me.Controls.Add(Me.Label11)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRegNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNepName As TextBox
    Friend WithEvents lblFirmName As Label
    Friend WithEvents CmbBillType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRevDate As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBillNo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtRevenu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents BtnYouTube As Button
    Friend WithEvents BtnHlpBook As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtExport As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ButtExit As Button
    Friend WithEvents ButtSearch As Button
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents Label2 As Label
End Class
