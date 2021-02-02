<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ftrans
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
        Me.btnviewStockout = New System.Windows.Forms.Button()
        Me.btnCus_clear = New System.Windows.Forms.Button()
        Me.btnCus_Remove = New System.Windows.Forms.Button()
        Me.btnCus_save = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtCus_addedlist = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncus_search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCus_fname = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtavailQty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbotrans = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.btnCus_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblreceipt = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.txtamounttendered = New System.Windows.Forms.TextBox()
        Me.txttotamount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtCus_addedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnviewStockout
        '
        Me.btnviewStockout.BackColor = System.Drawing.Color.White
        Me.btnviewStockout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewStockout.ForeColor = System.Drawing.Color.Black
        Me.btnviewStockout.Location = New System.Drawing.Point(538, 476)
        Me.btnviewStockout.Name = "btnviewStockout"
        Me.btnviewStockout.Size = New System.Drawing.Size(88, 26)
        Me.btnviewStockout.TabIndex = 25
        Me.btnviewStockout.Text = "View List"
        Me.btnviewStockout.UseVisualStyleBackColor = False
        '
        'btnCus_clear
        '
        Me.btnCus_clear.BackColor = System.Drawing.Color.White
        Me.btnCus_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCus_clear.ForeColor = System.Drawing.Color.Black
        Me.btnCus_clear.Location = New System.Drawing.Point(444, 476)
        Me.btnCus_clear.Name = "btnCus_clear"
        Me.btnCus_clear.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_clear.TabIndex = 20
        Me.btnCus_clear.Text = "Clear"
        Me.btnCus_clear.UseVisualStyleBackColor = False
        '
        'btnCus_Remove
        '
        Me.btnCus_Remove.BackColor = System.Drawing.Color.White
        Me.btnCus_Remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCus_Remove.ForeColor = System.Drawing.Color.Black
        Me.btnCus_Remove.Location = New System.Drawing.Point(350, 476)
        Me.btnCus_Remove.Name = "btnCus_Remove"
        Me.btnCus_Remove.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_Remove.TabIndex = 21
        Me.btnCus_Remove.Text = "Remove"
        Me.btnCus_Remove.UseVisualStyleBackColor = False
        '
        'btnCus_save
        '
        Me.btnCus_save.BackColor = System.Drawing.Color.White
        Me.btnCus_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCus_save.ForeColor = System.Drawing.Color.Black
        Me.btnCus_save.Location = New System.Drawing.Point(256, 476)
        Me.btnCus_save.Name = "btnCus_save"
        Me.btnCus_save.Size = New System.Drawing.Size(88, 26)
        Me.btnCus_save.TabIndex = 22
        Me.btnCus_save.Text = "Save"
        Me.btnCus_save.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dtglist)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(5, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 459)
        Me.Panel2.TabIndex = 18
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(3, 93)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.RowHeadersVisible = False
        Me.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtglist.Size = New System.Drawing.Size(228, 358)
        Me.dtglist.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 48)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch.Location = New System.Drawing.Point(9, 19)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(207, 20)
        Me.txtsearch.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "List of Products"
        '
        'dtCus_addedlist
        '
        Me.dtCus_addedlist.AllowUserToAddRows = False
        Me.dtCus_addedlist.AllowUserToDeleteRows = False
        Me.dtCus_addedlist.AllowUserToResizeColumns = False
        Me.dtCus_addedlist.AllowUserToResizeRows = False
        Me.dtCus_addedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtCus_addedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtCus_addedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCus_addedlist.Location = New System.Drawing.Point(251, 350)
        Me.dtCus_addedlist.Name = "dtCus_addedlist"
        Me.dtCus_addedlist.RowHeadersVisible = False
        Me.dtCus_addedlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCus_addedlist.Size = New System.Drawing.Size(502, 108)
        Me.dtCus_addedlist.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(260, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cart List"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(14, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 24)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Purchase Order"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btncus_search)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_cusid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtCus_fname)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(256, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 88)
        Me.Panel1.TabIndex = 24
        '
        'btncus_search
        '
        Me.btncus_search.BackColor = System.Drawing.Color.White
        Me.btncus_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncus_search.ForeColor = System.Drawing.Color.Black
        Me.btncus_search.Location = New System.Drawing.Point(318, 24)
        Me.btncus_search.Name = "btncus_search"
        Me.btncus_search.Size = New System.Drawing.Size(93, 26)
        Me.btncus_search.TabIndex = 9
        Me.btncus_search.Text = "Find"
        Me.btncus_search.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Customer Id :"
        '
        'txt_cusid
        '
        Me.txt_cusid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_cusid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_cusid.Location = New System.Drawing.Point(93, 28)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(219, 20)
        Me.txt_cusid.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Name :"
        '
        'txtCus_fname
        '
        Me.txtCus_fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCus_fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCus_fname.Enabled = False
        Me.txtCus_fname.Location = New System.Drawing.Point(93, 54)
        Me.txtCus_fname.Name = "txtCus_fname"
        Me.txtCus_fname.Size = New System.Drawing.Size(359, 20)
        Me.txtCus_fname.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Honeydew
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtunit)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtdesc)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtavailQty)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtprice)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbotrans)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtqty)
        Me.Panel3.Controls.Add(Me.btnCus_add)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtitemname)
        Me.Panel3.Controls.Add(Me.txtitemid)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(256, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(497, 182)
        Me.Panel3.TabIndex = 28
        '
        'txtunit
        '
        Me.txtunit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtunit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtunit.Enabled = False
        Me.txtunit.Location = New System.Drawing.Point(349, 109)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(103, 20)
        Me.txtunit.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 24)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Item Details"
        '
        'txtdesc
        '
        Me.txtdesc.Enabled = False
        Me.txtdesc.Location = New System.Drawing.Point(88, 57)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(190, 69)
        Me.txtdesc.TabIndex = 42
        Me.txtdesc.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 26)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Available" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Quantity"
        '
        'txtavailQty
        '
        Me.txtavailQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtavailQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtavailQty.Enabled = False
        Me.txtavailQty.Location = New System.Drawing.Point(349, 30)
        Me.txtavailQty.Name = "txtavailQty"
        Me.txtavailQty.Size = New System.Drawing.Size(103, 20)
        Me.txtavailQty.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(458, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "php"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(302, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Price :"
        '
        'txtprice
        '
        Me.txtprice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtprice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtprice.Enabled = False
        Me.txtprice.Location = New System.Drawing.Point(349, 57)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(103, 20)
        Me.txtprice.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Unit :"
        '
        'cbotrans
        '
        Me.cbotrans.FormattingEnabled = True
        Me.cbotrans.Location = New System.Drawing.Point(351, 109)
        Me.cbotrans.Name = "cbotrans"
        Me.cbotrans.Size = New System.Drawing.Size(100, 21)
        Me.cbotrans.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(286, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Quantity :"
        '
        'txtqty
        '
        Me.txtqty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtqty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtqty.Location = New System.Drawing.Point(349, 83)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(103, 20)
        Me.txtqty.TabIndex = 32
        '
        'btnCus_add
        '
        Me.btnCus_add.BackColor = System.Drawing.Color.White
        Me.btnCus_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCus_add.ForeColor = System.Drawing.Color.Black
        Me.btnCus_add.Location = New System.Drawing.Point(349, 135)
        Me.btnCus_add.Name = "btnCus_add"
        Me.btnCus_add.Size = New System.Drawing.Size(101, 26)
        Me.btnCus_add.TabIndex = 34
        Me.btnCus_add.Text = "Add to cart"
        Me.btnCus_add.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Item Name :"
        '
        'txtitemname
        '
        Me.txtitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtitemname.Enabled = False
        Me.txtitemname.Location = New System.Drawing.Point(88, 30)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(190, 20)
        Me.txtitemname.TabIndex = 29
        '
        'txtitemid
        '
        Me.txtitemid.Location = New System.Drawing.Point(91, 30)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(100, 20)
        Me.txtitemid.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(632, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 26)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblreceipt
        '
        Me.lblreceipt.AutoSize = True
        Me.lblreceipt.Location = New System.Drawing.Point(707, 9)
        Me.lblreceipt.Name = "lblreceipt"
        Me.lblreceipt.Size = New System.Drawing.Size(49, 13)
        Me.lblreceipt.TabIndex = 30
        Me.lblreceipt.Text = "lblreceipt"
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(719, 387)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(21, 20)
        Me.txtchange.TabIndex = 31
        '
        'txtamounttendered
        '
        Me.txtamounttendered.Location = New System.Drawing.Point(595, 368)
        Me.txtamounttendered.Name = "txtamounttendered"
        Me.txtamounttendered.Size = New System.Drawing.Size(95, 20)
        Me.txtamounttendered.TabIndex = 31
        '
        'txttotamount
        '
        Me.txttotamount.Location = New System.Drawing.Point(365, 368)
        Me.txttotamount.Name = "txttotamount"
        Me.txttotamount.Size = New System.Drawing.Size(95, 20)
        Me.txttotamount.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(261, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Total Amount : :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(466, 371)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Amount Tendered : :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(644, 387)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Change : :"
        '
        'ftrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(768, 507)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtCus_addedlist)
        Me.Controls.Add(Me.btnviewStockout)
        Me.Controls.Add(Me.btnCus_clear)
        Me.Controls.Add(Me.lblreceipt)
        Me.Controls.Add(Me.btnCus_Remove)
        Me.Controls.Add(Me.btnCus_save)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txttotamount)
        Me.Controls.Add(Me.txtamounttendered)
        Me.Controls.Add(Me.txtchange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ftrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtCus_addedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnviewStockout As System.Windows.Forms.Button
    Friend WithEvents btnCus_clear As System.Windows.Forms.Button
    Friend WithEvents btnCus_Remove As System.Windows.Forms.Button
    Friend WithEvents btnCus_save As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents dtCus_addedlist As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtglist As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncus_search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cusid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCus_fname As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtdesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtavailQty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbotrans As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnCus_add As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents lblreceipt As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents txtamounttendered As System.Windows.Forms.TextBox
    Friend WithEvents txttotamount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
