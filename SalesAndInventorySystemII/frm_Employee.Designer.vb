<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Employee
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnempupdate = New System.Windows.Forms.Button()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtworkstatus = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.txtdrate = New System.Windows.Forms.TextBox()
        Me.dtpdhired = New System.Windows.Forms.DateTimePicker()
        Me.txtpmethod = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtbplace = New System.Windows.Forms.RichTextBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpdbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.txtemerg = New System.Windows.Forms.TextBox()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnempnew = New System.Windows.Forms.Button()
        Me.btnempsave = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(856, 430)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage6.Controls.Add(Me.btnempupdate)
        Me.TabPage6.Controls.Add(Me.txtcode)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.GroupBox10)
        Me.TabPage6.Controls.Add(Me.GroupBox9)
        Me.TabPage6.Controls.Add(Me.btnempnew)
        Me.TabPage6.Controls.Add(Me.btnempsave)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(848, 404)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Information"
        '
        'btnempupdate
        '
        Me.btnempupdate.Location = New System.Drawing.Point(460, 359)
        Me.btnempupdate.Name = "btnempupdate"
        Me.btnempupdate.Size = New System.Drawing.Size(75, 32)
        Me.btnempupdate.TabIndex = 21
        Me.btnempupdate.Text = "Update"
        Me.btnempupdate.UseVisualStyleBackColor = True
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(89, 21)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(200, 20)
        Me.txtcode.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Assign code :"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtworkstatus)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.txtposition)
        Me.GroupBox10.Controls.Add(Me.txtdrate)
        Me.GroupBox10.Controls.Add(Me.dtpdhired)
        Me.GroupBox10.Controls.Add(Me.txtpmethod)
        Me.GroupBox10.Location = New System.Drawing.Point(4, 242)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(785, 111)
        Me.GroupBox10.TabIndex = 19
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Work Information"
        '
        'txtworkstatus
        '
        Me.txtworkstatus.FormattingEnabled = True
        Me.txtworkstatus.Items.AddRange(New Object() {"Active", "Resigned", "Retired"})
        Me.txtworkstatus.Location = New System.Drawing.Point(349, 45)
        Me.txtworkstatus.Name = "txtworkstatus"
        Me.txtworkstatus.Size = New System.Drawing.Size(154, 21)
        Me.txtworkstatus.TabIndex = 8
        Me.txtworkstatus.Text = "Active"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(22, 22)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(62, 13)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Daily Rate :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(293, 22)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(50, 13)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Position :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(300, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Status :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(14, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(70, 13)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Pay Method :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(531, 21)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Date Hired :"
        '
        'txtposition
        '
        Me.txtposition.Location = New System.Drawing.Point(347, 19)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(156, 20)
        Me.txtposition.TabIndex = 2
        '
        'txtdrate
        '
        Me.txtdrate.Location = New System.Drawing.Point(90, 19)
        Me.txtdrate.MaxLength = 3
        Me.txtdrate.Name = "txtdrate"
        Me.txtdrate.Size = New System.Drawing.Size(154, 20)
        Me.txtdrate.TabIndex = 2
        '
        'dtpdhired
        '
        Me.dtpdhired.CustomFormat = "yyyy-MM-dd"
        Me.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdhired.Location = New System.Drawing.Point(601, 19)
        Me.dtpdhired.Name = "dtpdhired"
        Me.dtpdhired.Size = New System.Drawing.Size(154, 20)
        Me.dtpdhired.TabIndex = 1
        '
        'txtpmethod
        '
        Me.txtpmethod.FormattingEnabled = True
        Me.txtpmethod.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.txtpmethod.Location = New System.Drawing.Point(90, 48)
        Me.txtpmethod.Name = "txtpmethod"
        Me.txtpmethod.Size = New System.Drawing.Size(154, 21)
        Me.txtpmethod.TabIndex = 0
        Me.txtpmethod.Text = "Weekly"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox9.Controls.Add(Me.txtbplace)
        Me.GroupBox9.Controls.Add(Me.txtaddress)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.dtpdbirth)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Controls.Add(Me.txtlname)
        Me.GroupBox9.Controls.Add(Me.Label23)
        Me.GroupBox9.Controls.Add(Me.txtcontact)
        Me.GroupBox9.Controls.Add(Me.txtage)
        Me.GroupBox9.Controls.Add(Me.txtfname)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.txtmname)
        Me.GroupBox9.Controls.Add(Me.rdofemale)
        Me.GroupBox9.Controls.Add(Me.txtemerg)
        Me.GroupBox9.Controls.Add(Me.rdomale)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.txtstatus)
        Me.GroupBox9.Controls.Add(Me.Label28)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Location = New System.Drawing.Point(4, 47)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(791, 189)
        Me.GroupBox9.TabIndex = 18
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Personal Information"
        '
        'txtbplace
        '
        Me.txtbplace.Location = New System.Drawing.Point(85, 127)
        Me.txtbplace.Name = "txtbplace"
        Me.txtbplace.Size = New System.Drawing.Size(166, 54)
        Me.txtbplace.TabIndex = 17
        Me.txtbplace.Text = ""
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(85, 61)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(166, 54)
        Me.txtaddress.TabIndex = 17
        Me.txtaddress.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Place of Birth"
        '
        'dtpdbirth
        '
        Me.dtpdbirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdbirth.Location = New System.Drawing.Point(626, 95)
        Me.dtpdbirth.Name = "dtpdbirth"
        Me.dtpdbirth.Size = New System.Drawing.Size(121, 20)
        Me.dtpdbirth.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(551, 100)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Date of Birth"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(353, 32)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(178, 20)
        Me.txtlname.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(321, 135)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Age"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(353, 59)
        Me.txtcontact.MaxLength = 11
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(178, 20)
        Me.txtcontact.TabIndex = 0
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(353, 131)
        Me.txtage.MaxLength = 2
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(58, 20)
        Me.txtage.TabIndex = 8
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(85, 32)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(170, 20)
        Me.txtfname.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(321, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Sex"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(626, 32)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(156, 20)
        Me.txtmname.TabIndex = 0
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Location = New System.Drawing.Point(406, 98)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(59, 17)
        Me.rdofemale.TabIndex = 6
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'txtemerg
        '
        Me.txtemerg.Location = New System.Drawing.Point(626, 131)
        Me.txtemerg.MaxLength = 11
        Me.txtemerg.Name = "txtemerg"
        Me.txtemerg.Size = New System.Drawing.Size(155, 20)
        Me.txtemerg.TabIndex = 0
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Location = New System.Drawing.Point(352, 98)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(48, 17)
        Me.rdomale.TabIndex = 6
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(263, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Contact Number"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "First Name"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(583, 61)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Status"
        '
        'txtstatus
        '
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"Married", "Single", "Widow"})
        Me.txtstatus.Location = New System.Drawing.Point(626, 58)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(121, 21)
        Me.txtstatus.TabIndex = 2
        Me.txtstatus.Text = "Single"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(289, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Last Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(34, 61)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Address"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(453, 135)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(167, 13)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Contact no. [ case of emergency ]"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(551, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(69, 13)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Middle Name"
        '
        'btnempnew
        '
        Me.btnempnew.Location = New System.Drawing.Point(379, 359)
        Me.btnempnew.Name = "btnempnew"
        Me.btnempnew.Size = New System.Drawing.Size(75, 32)
        Me.btnempnew.TabIndex = 15
        Me.btnempnew.Text = "New"
        Me.btnempnew.UseVisualStyleBackColor = True
        '
        'btnempsave
        '
        Me.btnempsave.Location = New System.Drawing.Point(298, 359)
        Me.btnempsave.Name = "btnempsave"
        Me.btnempsave.Size = New System.Drawing.Size(75, 32)
        Me.btnempsave.TabIndex = 16
        Me.btnempsave.Text = "Save"
        Me.btnempsave.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage7.Controls.Add(Me.btndelete)
        Me.TabPage7.Controls.Add(Me.Label46)
        Me.TabPage7.Controls.Add(Me.txtempsearch)
        Me.TabPage7.Controls.Add(Me.dtgemplist)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(848, 404)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Employee's List"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(707, 369)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(129, 23)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(625, 58)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(47, 13)
        Me.Label46.TabIndex = 3
        Me.Label46.Text = "Search :"
        '
        'txtempsearch
        '
        Me.txtempsearch.Location = New System.Drawing.Point(673, 54)
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(163, 20)
        Me.txtempsearch.TabIndex = 2
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgemplist.Location = New System.Drawing.Point(3, 80)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowHeadersVisible = False
        Me.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgemplist.ShowCellToolTips = False
        Me.dtgemplist.Size = New System.Drawing.Size(836, 283)
        Me.dtgemplist.TabIndex = 0
        '
        'frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(856, 430)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "frm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btnempupdate As System.Windows.Forms.Button
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtworkstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtposition As System.Windows.Forms.TextBox
    Friend WithEvents txtdrate As System.Windows.Forms.TextBox
    Friend WithEvents dtpdhired As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpmethod As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbplace As System.Windows.Forms.RichTextBox
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpdbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtemerg As System.Windows.Forms.TextBox
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnempnew As System.Windows.Forms.Button
    Friend WithEvents btnempsave As System.Windows.Forms.Button
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtempsearch As System.Windows.Forms.TextBox
    Friend WithEvents dtgemplist As System.Windows.Forms.DataGridView
End Class
