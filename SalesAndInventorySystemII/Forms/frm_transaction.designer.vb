<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transaction
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnStaockin_list = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.dtgSup_cartlist = New System.Windows.Forms.DataGridView
        Me.aa = New System.Windows.Forms.Button
        Me.btnSup_edit = New System.Windows.Forms.Button
        Me.btnSup_save = New System.Windows.Forms.Button
        Me.btnSup_addtocart = New System.Windows.Forms.Button
        Me.pnl_stockmaster = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSup_qty = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtSup_totprice = New System.Windows.Forms.TextBox
        Me.txtSup_price = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSup_itemSearch = New System.Windows.Forms.Button
        Me.txtSup_description = New System.Windows.Forms.RichTextBox
        Me.txtSup_itemid = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtSup_itemName = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txSup_lname = New System.Windows.Forms.TextBox
        Me.btnSup_supSearch = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_suplierId = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSup_fname = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnviewStockout = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btncus_search = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_cusid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCus_lname = New System.Windows.Forms.TextBox
        Me.txtCus_fname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCus_clear = New System.Windows.Forms.Button
        Me.btnCus_Remove = New System.Windows.Forms.Button
        Me.btnCus_save = New System.Windows.Forms.Button
        Me.btnCus_add = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dtCus_addedlist = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtgCus_itemlist = New System.Windows.Forms.DataGridView
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnvewlreturn = New System.Windows.Forms.Button
        Me.btnreturn_clear = New System.Windows.Forms.Button
        Me.btnreturn_remove = New System.Windows.Forms.Button
        Me.btnreturn_save = New System.Windows.Forms.Button
        Me.btnreturnadd = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.dtgreturn_cart = New System.Windows.Forms.DataGridView
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnreturn_Search = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.dtgreturn_itemlist = New System.Windows.Forms.DataGridView
        Me.txttransactionid = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtreturn_address = New System.Windows.Forms.TextBox
        Me.txtreturn_name = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dtgSup_cartlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_stockmaster.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtCus_addedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgCus_itemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dtgreturn_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.dtgreturn_itemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(642, 481)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.btnStaockin_list)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.aa)
        Me.TabPage1.Controls.Add(Me.btnSup_edit)
        Me.TabPage1.Controls.Add(Me.btnSup_save)
        Me.TabPage1.Controls.Add(Me.btnSup_addtocart)
        Me.TabPage1.Controls.Add(Me.pnl_stockmaster)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(634, 455)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stock In"
        '
        'btnStaockin_list
        '
        Me.btnStaockin_list.Location = New System.Drawing.Point(288, 423)
        Me.btnStaockin_list.Name = "btnStaockin_list"
        Me.btnStaockin_list.Size = New System.Drawing.Size(88, 26)
        Me.btnStaockin_list.TabIndex = 15
        Me.btnStaockin_list.Text = "View List"
        Me.btnStaockin_list.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(214, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 24)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "List of Added Items"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.dtgSup_cartlist)
        Me.Panel5.Location = New System.Drawing.Point(6, 315)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(615, 102)
        Me.Panel5.TabIndex = 8
        '
        'dtgSup_cartlist
        '
        Me.dtgSup_cartlist.AllowUserToAddRows = False
        Me.dtgSup_cartlist.AllowUserToDeleteRows = False
        Me.dtgSup_cartlist.AllowUserToResizeColumns = False
        Me.dtgSup_cartlist.AllowUserToResizeRows = False
        Me.dtgSup_cartlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSup_cartlist.Location = New System.Drawing.Point(6, 3)
        Me.dtgSup_cartlist.Name = "dtgSup_cartlist"
        Me.dtgSup_cartlist.Size = New System.Drawing.Size(602, 94)
        Me.dtgSup_cartlist.TabIndex = 9
        '
        'aa
        '
        Me.aa.Location = New System.Drawing.Point(194, 423)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(88, 26)
        Me.aa.TabIndex = 12
        Me.aa.Text = "Clear"
        Me.aa.UseVisualStyleBackColor = True
        '
        'btnSup_edit
        '
        Me.btnSup_edit.Location = New System.Drawing.Point(100, 423)
        Me.btnSup_edit.Name = "btnSup_edit"
        Me.btnSup_edit.Size = New System.Drawing.Size(88, 26)
        Me.btnSup_edit.TabIndex = 11
        Me.btnSup_edit.Text = "Remove"
        Me.btnSup_edit.UseVisualStyleBackColor = True
        '
        'btnSup_save
        '
        Me.btnSup_save.Location = New System.Drawing.Point(6, 423)
        Me.btnSup_save.Name = "btnSup_save"
        Me.btnSup_save.Size = New System.Drawing.Size(88, 26)
        Me.btnSup_save.TabIndex = 10
        Me.btnSup_save.Text = "Save"
        Me.btnSup_save.UseVisualStyleBackColor = True
        '
        'btnSup_addtocart
        '
        Me.btnSup_addtocart.Location = New System.Drawing.Point(6, 285)
        Me.btnSup_addtocart.Name = "btnSup_addtocart"
        Me.btnSup_addtocart.Size = New System.Drawing.Size(106, 24)
        Me.btnSup_addtocart.TabIndex = 7
        Me.btnSup_addtocart.Text = "Add"
        Me.btnSup_addtocart.UseVisualStyleBackColor = True
        '
        'pnl_stockmaster
        '
        Me.pnl_stockmaster.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnl_stockmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_stockmaster.Controls.Add(Me.GroupBox1)
        Me.pnl_stockmaster.Controls.Add(Me.Label20)
        Me.pnl_stockmaster.Controls.Add(Me.GroupBox2)
        Me.pnl_stockmaster.Location = New System.Drawing.Point(6, 108)
        Me.pnl_stockmaster.Name = "pnl_stockmaster"
        Me.pnl_stockmaster.Size = New System.Drawing.Size(615, 171)
        Me.pnl_stockmaster.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSup_qty)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtSup_totprice)
        Me.GroupBox1.Controls.Add(Me.txtSup_price)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(347, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 110)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "6"
        Me.GroupBox1.Text = "Summary"
        '
        'txtSup_qty
        '
        Me.txtSup_qty.Location = New System.Drawing.Point(78, 51)
        Me.txtSup_qty.Name = "txtSup_qty"
        Me.txtSup_qty.Size = New System.Drawing.Size(157, 20)
        Me.txtSup_qty.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Total Price :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Quantity :"
        '
        'txtSup_totprice
        '
        Me.txtSup_totprice.Enabled = False
        Me.txtSup_totprice.Location = New System.Drawing.Point(78, 77)
        Me.txtSup_totprice.Name = "txtSup_totprice"
        Me.txtSup_totprice.Size = New System.Drawing.Size(157, 20)
        Me.txtSup_totprice.TabIndex = 0
        '
        'txtSup_price
        '
        Me.txtSup_price.Enabled = False
        Me.txtSup_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSup_price.Location = New System.Drawing.Point(78, 22)
        Me.txtSup_price.Name = "txtSup_price"
        Me.txtSup_price.Size = New System.Drawing.Size(157, 20)
        Me.txtSup_price.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Price ::"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 24)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Items"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnSup_itemSearch)
        Me.GroupBox2.Controls.Add(Me.txtSup_description)
        Me.GroupBox2.Controls.Add(Me.txtSup_itemid)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtSup_itemName)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 128)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Id :"
        '
        'btnSup_itemSearch
        '
        Me.btnSup_itemSearch.Location = New System.Drawing.Point(238, 14)
        Me.btnSup_itemSearch.Name = "btnSup_itemSearch"
        Me.btnSup_itemSearch.Size = New System.Drawing.Size(76, 23)
        Me.btnSup_itemSearch.TabIndex = 5
        Me.btnSup_itemSearch.Text = "Find"
        Me.btnSup_itemSearch.UseVisualStyleBackColor = True
        '
        'txtSup_description
        '
        Me.txtSup_description.Enabled = False
        Me.txtSup_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSup_description.Location = New System.Drawing.Point(81, 76)
        Me.txtSup_description.Name = "txtSup_description"
        Me.txtSup_description.Size = New System.Drawing.Size(211, 35)
        Me.txtSup_description.TabIndex = 0
        Me.txtSup_description.Text = ""
        '
        'txtSup_itemid
        '
        Me.txtSup_itemid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSup_itemid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSup_itemid.Location = New System.Drawing.Point(81, 16)
        Me.txtSup_itemid.Name = "txtSup_itemid"
        Me.txtSup_itemid.Size = New System.Drawing.Size(154, 20)
        Me.txtSup_itemid.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Description :"
        '
        'txtSup_itemName
        '
        Me.txtSup_itemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSup_itemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSup_itemName.Enabled = False
        Me.txtSup_itemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSup_itemName.Location = New System.Drawing.Point(81, 49)
        Me.txtSup_itemName.Name = "txtSup_itemName"
        Me.txtSup_itemName.Size = New System.Drawing.Size(211, 20)
        Me.txtSup_itemName.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Name :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txSup_lname)
        Me.Panel4.Controls.Add(Me.btnSup_supSearch)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txt_suplierId)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.txtSup_fname)
        Me.Panel4.Location = New System.Drawing.Point(6, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(615, 96)
        Me.Panel4.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last Name :"
        '
        'txSup_lname
        '
        Me.txSup_lname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txSup_lname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txSup_lname.Enabled = False
        Me.txSup_lname.Location = New System.Drawing.Point(370, 62)
        Me.txSup_lname.Name = "txSup_lname"
        Me.txSup_lname.Size = New System.Drawing.Size(205, 20)
        Me.txSup_lname.TabIndex = 0
        '
        'btnSup_supSearch
        '
        Me.btnSup_supSearch.Location = New System.Drawing.Point(292, 30)
        Me.btnSup_supSearch.Name = "btnSup_supSearch"
        Me.btnSup_supSearch.Size = New System.Drawing.Size(93, 23)
        Me.btnSup_supSearch.TabIndex = 2
        Me.btnSup_supSearch.Text = "Find"
        Me.btnSup_supSearch.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Suplier Id :"
        '
        'txt_suplierId
        '
        Me.txt_suplierId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_suplierId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_suplierId.Location = New System.Drawing.Point(84, 33)
        Me.txt_suplierId.Name = "txt_suplierId"
        Me.txt_suplierId.Size = New System.Drawing.Size(205, 20)
        Me.txt_suplierId.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 24)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Supplier"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "First Name :"
        '
        'txtSup_fname
        '
        Me.txtSup_fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSup_fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSup_fname.Enabled = False
        Me.txtSup_fname.Location = New System.Drawing.Point(84, 62)
        Me.txtSup_fname.Name = "txtSup_fname"
        Me.txtSup_fname.Size = New System.Drawing.Size(205, 20)
        Me.txtSup_fname.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnviewStockout)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnCus_clear)
        Me.TabPage2.Controls.Add(Me.btnCus_Remove)
        Me.TabPage2.Controls.Add(Me.btnCus_save)
        Me.TabPage2.Controls.Add(Me.btnCus_add)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(634, 455)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock Out"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnviewStockout
        '
        Me.btnviewStockout.Location = New System.Drawing.Point(290, 421)
        Me.btnviewStockout.Name = "btnviewStockout"
        Me.btnviewStockout.Size = New System.Drawing.Size(88, 26)
        Me.btnviewStockout.TabIndex = 16
        Me.btnviewStockout.Text = "View List"
        Me.btnviewStockout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btncus_search)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_cusid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtCus_lname)
        Me.Panel1.Controls.Add(Me.txtCus_fname)
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 88)
        Me.Panel1.TabIndex = 11
        '
        'btncus_search
        '
        Me.btncus_search.Location = New System.Drawing.Point(290, 23)
        Me.btncus_search.Name = "btncus_search"
        Me.btncus_search.Size = New System.Drawing.Size(93, 26)
        Me.btncus_search.TabIndex = 9
        Me.btncus_search.Text = "Find"
        Me.btncus_search.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(290, 23)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(93, 23)
        Me.Button14.TabIndex = 9
        Me.Button14.Text = "Search"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Customer Id :"
        '
        'txt_cusid
        '
        Me.txt_cusid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cusid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cusid.Location = New System.Drawing.Point(79, 27)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(205, 20)
        Me.txt_cusid.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Last Name :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "First Name :"
        '
        'txtCus_lname
        '
        Me.txtCus_lname.Enabled = False
        Me.txtCus_lname.Location = New System.Drawing.Point(375, 53)
        Me.txtCus_lname.Name = "txtCus_lname"
        Me.txtCus_lname.Size = New System.Drawing.Size(220, 20)
        Me.txtCus_lname.TabIndex = 0
        '
        'txtCus_fname
        '
        Me.txtCus_fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCus_fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCus_fname.Enabled = False
        Me.txtCus_fname.Location = New System.Drawing.Point(79, 53)
        Me.txtCus_fname.Name = "txtCus_fname"
        Me.txtCus_fname.Size = New System.Drawing.Size(205, 20)
        Me.txtCus_fname.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "List of Added Items"
        '
        'btnCus_clear
        '
        Me.btnCus_clear.Location = New System.Drawing.Point(194, 421)
        Me.btnCus_clear.Name = "btnCus_clear"
        Me.btnCus_clear.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_clear.TabIndex = 7
        Me.btnCus_clear.Text = "Clear"
        Me.btnCus_clear.UseVisualStyleBackColor = True
        '
        'btnCus_Remove
        '
        Me.btnCus_Remove.Location = New System.Drawing.Point(100, 421)
        Me.btnCus_Remove.Name = "btnCus_Remove"
        Me.btnCus_Remove.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_Remove.TabIndex = 8
        Me.btnCus_Remove.Text = "Remove"
        Me.btnCus_Remove.UseVisualStyleBackColor = True
        '
        'btnCus_save
        '
        Me.btnCus_save.Location = New System.Drawing.Point(6, 421)
        Me.btnCus_save.Name = "btnCus_save"
        Me.btnCus_save.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_save.TabIndex = 9
        Me.btnCus_save.Text = "Save"
        Me.btnCus_save.UseVisualStyleBackColor = True
        '
        'btnCus_add
        '
        Me.btnCus_add.Location = New System.Drawing.Point(6, 276)
        Me.btnCus_add.Name = "btnCus_add"
        Me.btnCus_add.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_add.TabIndex = 6
        Me.btnCus_add.Text = "Add Item"
        Me.btnCus_add.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dtCus_addedlist)
        Me.Panel3.Location = New System.Drawing.Point(6, 308)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(615, 107)
        Me.Panel3.TabIndex = 3
        '
        'dtCus_addedlist
        '
        Me.dtCus_addedlist.AllowUserToAddRows = False
        Me.dtCus_addedlist.AllowUserToDeleteRows = False
        Me.dtCus_addedlist.AllowUserToResizeColumns = False
        Me.dtCus_addedlist.AllowUserToResizeRows = False
        Me.dtCus_addedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCus_addedlist.Location = New System.Drawing.Point(3, 3)
        Me.dtCus_addedlist.Name = "dtCus_addedlist"
        Me.dtCus_addedlist.Size = New System.Drawing.Size(606, 98)
        Me.dtCus_addedlist.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtgCus_itemlist)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(6, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 168)
        Me.Panel2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "List of Products"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Search :"
        '
        'dtgCus_itemlist
        '
        Me.dtgCus_itemlist.AllowUserToAddRows = False
        Me.dtgCus_itemlist.AllowUserToDeleteRows = False
        Me.dtgCus_itemlist.AllowUserToResizeColumns = False
        Me.dtgCus_itemlist.AllowUserToResizeRows = False
        Me.dtgCus_itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCus_itemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCus_itemlist.Location = New System.Drawing.Point(3, 29)
        Me.dtgCus_itemlist.Name = "dtgCus_itemlist"
        Me.dtgCus_itemlist.Size = New System.Drawing.Size(607, 131)
        Me.dtgCus_itemlist.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch.Location = New System.Drawing.Point(388, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(220, 20)
        Me.txtsearch.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnvewlreturn)
        Me.TabPage3.Controls.Add(Me.btnreturn_clear)
        Me.TabPage3.Controls.Add(Me.btnreturn_remove)
        Me.TabPage3.Controls.Add(Me.btnreturn_save)
        Me.TabPage3.Controls.Add(Me.btnreturnadd)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.Panel6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(634, 455)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stock Return"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnvewlreturn
        '
        Me.btnvewlreturn.Location = New System.Drawing.Point(256, 412)
        Me.btnvewlreturn.Name = "btnvewlreturn"
        Me.btnvewlreturn.Size = New System.Drawing.Size(88, 26)
        Me.btnvewlreturn.TabIndex = 17
        Me.btnvewlreturn.Text = "View List"
        Me.btnvewlreturn.UseVisualStyleBackColor = True
        '
        'btnreturn_clear
        '
        Me.btnreturn_clear.Location = New System.Drawing.Point(175, 414)
        Me.btnreturn_clear.Name = "btnreturn_clear"
        Me.btnreturn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btnreturn_clear.TabIndex = 2
        Me.btnreturn_clear.Text = "Clear"
        Me.btnreturn_clear.UseVisualStyleBackColor = True
        '
        'btnreturn_remove
        '
        Me.btnreturn_remove.Location = New System.Drawing.Point(94, 414)
        Me.btnreturn_remove.Name = "btnreturn_remove"
        Me.btnreturn_remove.Size = New System.Drawing.Size(75, 23)
        Me.btnreturn_remove.TabIndex = 2
        Me.btnreturn_remove.Text = "Remove"
        Me.btnreturn_remove.UseVisualStyleBackColor = True
        '
        'btnreturn_save
        '
        Me.btnreturn_save.Location = New System.Drawing.Point(13, 414)
        Me.btnreturn_save.Name = "btnreturn_save"
        Me.btnreturn_save.Size = New System.Drawing.Size(75, 23)
        Me.btnreturn_save.TabIndex = 2
        Me.btnreturn_save.Text = "Save"
        Me.btnreturn_save.UseVisualStyleBackColor = True
        '
        'btnreturnadd
        '
        Me.btnreturnadd.Location = New System.Drawing.Point(8, 248)
        Me.btnreturnadd.Name = "btnreturnadd"
        Me.btnreturnadd.Size = New System.Drawing.Size(78, 25)
        Me.btnreturnadd.TabIndex = 1
        Me.btnreturnadd.Text = "Add"
        Me.btnreturnadd.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.dtgreturn_cart)
        Me.Panel7.Location = New System.Drawing.Point(8, 279)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(613, 129)
        Me.Panel7.TabIndex = 0
        '
        'dtgreturn_cart
        '
        Me.dtgreturn_cart.AllowUserToAddRows = False
        Me.dtgreturn_cart.AllowUserToDeleteRows = False
        Me.dtgreturn_cart.AllowUserToResizeColumns = False
        Me.dtgreturn_cart.AllowUserToResizeRows = False
        Me.dtgreturn_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgreturn_cart.Location = New System.Drawing.Point(3, 3)
        Me.dtgreturn_cart.Name = "dtgreturn_cart"
        Me.dtgreturn_cart.Size = New System.Drawing.Size(605, 120)
        Me.dtgreturn_cart.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnreturn_Search)
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Controls.Add(Me.dtgreturn_itemlist)
        Me.Panel6.Controls.Add(Me.txttransactionid)
        Me.Panel6.Controls.Add(Me.GroupBox3)
        Me.Panel6.Location = New System.Drawing.Point(8, 11)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(613, 231)
        Me.Panel6.TabIndex = 0
        '
        'btnreturn_Search
        '
        Me.btnreturn_Search.Location = New System.Drawing.Point(269, 14)
        Me.btnreturn_Search.Name = "btnreturn_Search"
        Me.btnreturn_Search.Size = New System.Drawing.Size(75, 23)
        Me.btnreturn_Search.TabIndex = 3
        Me.btnreturn_Search.Text = "Search"
        Me.btnreturn_Search.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(10, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Transaction Id :"
        '
        'dtgreturn_itemlist
        '
        Me.dtgreturn_itemlist.AllowUserToAddRows = False
        Me.dtgreturn_itemlist.AllowUserToDeleteRows = False
        Me.dtgreturn_itemlist.AllowUserToResizeColumns = False
        Me.dtgreturn_itemlist.AllowUserToResizeRows = False
        Me.dtgreturn_itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgreturn_itemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgreturn_itemlist.Location = New System.Drawing.Point(13, 124)
        Me.dtgreturn_itemlist.Name = "dtgreturn_itemlist"
        Me.dtgreturn_itemlist.Size = New System.Drawing.Size(589, 92)
        Me.dtgreturn_itemlist.TabIndex = 1
        '
        'txttransactionid
        '
        Me.txttransactionid.Location = New System.Drawing.Point(97, 16)
        Me.txttransactionid.Name = "txttransactionid"
        Me.txttransactionid.Size = New System.Drawing.Size(166, 20)
        Me.txttransactionid.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtreturn_address)
        Me.GroupBox3.Controls.Add(Me.txtreturn_name)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(589, 63)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Or Suplier Details"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(266, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Address :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Name :"
        '
        'txtreturn_address
        '
        Me.txtreturn_address.Enabled = False
        Me.txtreturn_address.Location = New System.Drawing.Point(323, 24)
        Me.txtreturn_address.Name = "txtreturn_address"
        Me.txtreturn_address.Size = New System.Drawing.Size(249, 20)
        Me.txtreturn_address.TabIndex = 0
        '
        'txtreturn_name
        '
        Me.txtreturn_name.Enabled = False
        Me.txtreturn_name.Location = New System.Drawing.Point(53, 24)
        Me.txtreturn_name.Name = "txtreturn_name"
        Me.txtreturn_name.Size = New System.Drawing.Size(186, 20)
        Me.txtreturn_name.TabIndex = 0
        '
        'frm_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dtgSup_cartlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_stockmaster.ResumeLayout(False)
        Me.pnl_stockmaster.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dtCus_addedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgCus_itemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.dtgreturn_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dtgreturn_itemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnCus_clear As System.Windows.Forms.Button
    Friend WithEvents btnCus_Remove As System.Windows.Forms.Button
    Friend WithEvents btnCus_save As System.Windows.Forms.Button
    Friend WithEvents btnCus_add As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtCus_addedlist As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgCus_itemlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCus_lname As System.Windows.Forms.TextBox
    Friend WithEvents txtCus_fname As System.Windows.Forms.TextBox
    Friend WithEvents pnl_stockmaster As System.Windows.Forms.Panel
    Friend WithEvents txtSup_description As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSup_itemName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSup_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSup_totprice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents aa As System.Windows.Forms.Button
    Friend WithEvents btnSup_edit As System.Windows.Forms.Button
    Friend WithEvents btnSup_save As System.Windows.Forms.Button
    Friend WithEvents btnSup_addtocart As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dtgSup_cartlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnreturnadd As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnreturn_clear As System.Windows.Forms.Button
    Friend WithEvents btnreturn_remove As System.Windows.Forms.Button
    Friend WithEvents btnreturn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgreturn_cart As System.Windows.Forms.DataGridView
    Friend WithEvents dtgreturn_itemlist As System.Windows.Forms.DataGridView
    Friend WithEvents txtreturn_address As System.Windows.Forms.TextBox
    Friend WithEvents txtreturn_name As System.Windows.Forms.TextBox
    Friend WithEvents txttransactionid As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSup_price As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSup_fname As System.Windows.Forms.TextBox
    Friend WithEvents btnSup_supSearch As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_suplierId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSup_itemid As System.Windows.Forms.TextBox
    Friend WithEvents btnSup_itemSearch As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cusid As System.Windows.Forms.TextBox
    Friend WithEvents btncus_search As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txSup_lname As System.Windows.Forms.TextBox
    Friend WithEvents btnreturn_Search As System.Windows.Forms.Button
    Friend WithEvents btnStaockin_list As System.Windows.Forms.Button
    Friend WithEvents btnviewStockout As System.Windows.Forms.Button
    Friend WithEvents btnvewlreturn As System.Windows.Forms.Button
End Class
