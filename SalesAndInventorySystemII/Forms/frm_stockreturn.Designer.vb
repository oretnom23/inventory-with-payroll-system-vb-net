<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stockreturn
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
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvewlreturn = New System.Windows.Forms.Button()
        Me.btnreturn_clear = New System.Windows.Forms.Button()
        Me.dtgreturn_itemlist = New System.Windows.Forms.DataGridView()
        Me.btnreturn_save = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtreturn_address = New System.Windows.Forms.TextBox()
        Me.txtreturn_name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtiprice = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.RichTextBox()
        Me.txtrprice = New System.Windows.Forms.TextBox()
        Me.txtrqty = New System.Windows.Forms.TextBox()
        Me.txtsqty = New System.Windows.Forms.TextBox()
        Me.txtiname = New System.Windows.Forms.TextBox()
        Me.dtglistreturn = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.txttranid = New System.Windows.Forms.TextBox()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgreturn_itemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtglistreturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(6, 17)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(215, 20)
        Me.txtsearch.TabIndex = 10
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(6, 115)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.Size = New System.Drawing.Size(232, 370)
        Me.dtglist.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "List of Transaction"
        '
        'btnvewlreturn
        '
        Me.btnvewlreturn.BackColor = System.Drawing.Color.White
        Me.btnvewlreturn.ForeColor = System.Drawing.Color.Black
        Me.btnvewlreturn.Location = New System.Drawing.Point(484, 127)
        Me.btnvewlreturn.Name = "btnvewlreturn"
        Me.btnvewlreturn.Size = New System.Drawing.Size(88, 22)
        Me.btnvewlreturn.TabIndex = 25
        Me.btnvewlreturn.Text = "Close"
        Me.btnvewlreturn.UseVisualStyleBackColor = False
        '
        'btnreturn_clear
        '
        Me.btnreturn_clear.BackColor = System.Drawing.Color.White
        Me.btnreturn_clear.ForeColor = System.Drawing.Color.Black
        Me.btnreturn_clear.Location = New System.Drawing.Point(404, 127)
        Me.btnreturn_clear.Name = "btnreturn_clear"
        Me.btnreturn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btnreturn_clear.TabIndex = 23
        Me.btnreturn_clear.Text = "Clear"
        Me.btnreturn_clear.UseVisualStyleBackColor = False
        '
        'dtgreturn_itemlist
        '
        Me.dtgreturn_itemlist.AllowUserToAddRows = False
        Me.dtgreturn_itemlist.AllowUserToDeleteRows = False
        Me.dtgreturn_itemlist.AllowUserToResizeColumns = False
        Me.dtgreturn_itemlist.AllowUserToResizeRows = False
        Me.dtgreturn_itemlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgreturn_itemlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgreturn_itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgreturn_itemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgreturn_itemlist.Location = New System.Drawing.Point(251, 81)
        Me.dtgreturn_itemlist.Name = "dtgreturn_itemlist"
        Me.dtgreturn_itemlist.Size = New System.Drawing.Size(589, 87)
        Me.dtgreturn_itemlist.TabIndex = 20
        '
        'btnreturn_save
        '
        Me.btnreturn_save.BackColor = System.Drawing.Color.White
        Me.btnreturn_save.ForeColor = System.Drawing.Color.Black
        Me.btnreturn_save.Location = New System.Drawing.Point(323, 127)
        Me.btnreturn_save.Name = "btnreturn_save"
        Me.btnreturn_save.Size = New System.Drawing.Size(75, 23)
        Me.btnreturn_save.TabIndex = 21
        Me.btnreturn_save.Text = "Return"
        Me.btnreturn_save.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtreturn_address)
        Me.GroupBox3.Controls.Add(Me.txtreturn_name)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(251, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(589, 63)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Or Suplier Details"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(266, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Address :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 13)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtglist)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 491)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtsearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(8, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 51)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtremarks)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtiprice)
        Me.GroupBox4.Controls.Add(Me.txtdesc)
        Me.GroupBox4.Controls.Add(Me.txtrprice)
        Me.GroupBox4.Controls.Add(Me.txtrqty)
        Me.GroupBox4.Controls.Add(Me.txtsqty)
        Me.GroupBox4.Controls.Add(Me.txtiname)
        Me.GroupBox4.Controls.Add(Me.btnreturn_save)
        Me.GroupBox4.Controls.Add(Me.btnreturn_clear)
        Me.GroupBox4.Controls.Add(Me.btnvewlreturn)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(251, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 155)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Remarks :"
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(386, 97)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(186, 20)
        Me.txtremarks.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(266, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Return Price :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(278, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Return Quantity :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sold Quantity :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Price :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Decription :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name :"
        '
        'txtiprice
        '
        Me.txtiprice.Enabled = False
        Me.txtiprice.Location = New System.Drawing.Point(85, 104)
        Me.txtiprice.Name = "txtiprice"
        Me.txtiprice.Size = New System.Drawing.Size(171, 20)
        Me.txtiprice.TabIndex = 28
        '
        'txtdesc
        '
        Me.txtdesc.Enabled = False
        Me.txtdesc.Location = New System.Drawing.Point(85, 45)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(172, 53)
        Me.txtdesc.TabIndex = 27
        Me.txtdesc.Text = ""
        '
        'txtrprice
        '
        Me.txtrprice.Enabled = False
        Me.txtrprice.Location = New System.Drawing.Point(386, 71)
        Me.txtrprice.Name = "txtrprice"
        Me.txtrprice.Size = New System.Drawing.Size(186, 20)
        Me.txtrprice.TabIndex = 26
        '
        'txtrqty
        '
        Me.txtrqty.Location = New System.Drawing.Point(386, 45)
        Me.txtrqty.Name = "txtrqty"
        Me.txtrqty.Size = New System.Drawing.Size(186, 20)
        Me.txtrqty.TabIndex = 26
        '
        'txtsqty
        '
        Me.txtsqty.Enabled = False
        Me.txtsqty.Location = New System.Drawing.Point(386, 19)
        Me.txtsqty.Name = "txtsqty"
        Me.txtsqty.Size = New System.Drawing.Size(186, 20)
        Me.txtsqty.TabIndex = 26
        '
        'txtiname
        '
        Me.txtiname.Enabled = False
        Me.txtiname.Location = New System.Drawing.Point(85, 19)
        Me.txtiname.Name = "txtiname"
        Me.txtiname.Size = New System.Drawing.Size(171, 20)
        Me.txtiname.TabIndex = 26
        '
        'dtglistreturn
        '
        Me.dtglistreturn.AllowUserToAddRows = False
        Me.dtglistreturn.AllowUserToDeleteRows = False
        Me.dtglistreturn.AllowUserToResizeColumns = False
        Me.dtglistreturn.AllowUserToResizeRows = False
        Me.dtglistreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistreturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglistreturn.Location = New System.Drawing.Point(248, 360)
        Me.dtglistreturn.Name = "dtglistreturn"
        Me.dtglistreturn.Size = New System.Drawing.Size(592, 134)
        Me.dtglistreturn.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(255, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "List of Returned Items"
        '
        'txtitemid
        '
        Me.txtitemid.Location = New System.Drawing.Point(260, 81)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(100, 20)
        Me.txtitemid.TabIndex = 29
        '
        'txtcusid
        '
        Me.txtcusid.Location = New System.Drawing.Point(260, 107)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(100, 20)
        Me.txtcusid.TabIndex = 29
        '
        'txttranid
        '
        Me.txttranid.Location = New System.Drawing.Point(260, 133)
        Me.txttranid.Name = "txttranid"
        Me.txttranid.Size = New System.Drawing.Size(100, 20)
        Me.txttranid.TabIndex = 29
        '
        'frm_stockreturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(844, 500)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtglistreturn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgreturn_itemlist)
        Me.Controls.Add(Me.txttranid)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.txtitemid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_stockreturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return"
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgreturn_itemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtglistreturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents dtglist As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnvewlreturn As System.Windows.Forms.Button
    Friend WithEvents btnreturn_clear As System.Windows.Forms.Button
    Friend WithEvents dtgreturn_itemlist As System.Windows.Forms.DataGridView
    Friend WithEvents btnreturn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtreturn_address As System.Windows.Forms.TextBox
    Friend WithEvents txtreturn_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtglistreturn As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.RichTextBox
    Friend WithEvents txtiname As System.Windows.Forms.TextBox
    Friend WithEvents txtiprice As System.Windows.Forms.TextBox
    Friend WithEvents txtrprice As System.Windows.Forms.TextBox
    Friend WithEvents txtrqty As System.Windows.Forms.TextBox
    Friend WithEvents txtsqty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
    Friend WithEvents txtcusid As System.Windows.Forms.TextBox
    Friend WithEvents txttranid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
End Class
