<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_settings
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btntypedel = New System.Windows.Forms.Button()
        Me.btntypeupdate = New System.Windows.Forms.Button()
        Me.btntypeLoad = New System.Windows.Forms.Button()
        Me.dtgtypelist = New System.Windows.Forms.DataGridView()
        Me.txtitemtype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTypesave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnudelete = New System.Windows.Forms.Button()
        Me.btnuupdate = New System.Windows.Forms.Button()
        Me.btnuload = New System.Windows.Forms.Button()
        Me.dtgulist = New System.Windows.Forms.DataGridView()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnusave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.btntypedel)
        Me.GroupBox1.Controls.Add(Me.btntypeupdate)
        Me.GroupBox1.Controls.Add(Me.btntypeLoad)
        Me.GroupBox1.Controls.Add(Me.dtgtypelist)
        Me.GroupBox1.Controls.Add(Me.txtitemtype)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnTypesave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Category"
        '
        'btntypedel
        '
        Me.btntypedel.BackColor = System.Drawing.Color.White
        Me.btntypedel.ForeColor = System.Drawing.Color.Black
        Me.btntypedel.Location = New System.Drawing.Point(249, 174)
        Me.btntypedel.Name = "btntypedel"
        Me.btntypedel.Size = New System.Drawing.Size(75, 23)
        Me.btntypedel.TabIndex = 8
        Me.btntypedel.Text = "Delete"
        Me.btntypedel.UseVisualStyleBackColor = False
        '
        'btntypeupdate
        '
        Me.btntypeupdate.BackColor = System.Drawing.Color.White
        Me.btntypeupdate.ForeColor = System.Drawing.Color.Black
        Me.btntypeupdate.Location = New System.Drawing.Point(168, 174)
        Me.btntypeupdate.Name = "btntypeupdate"
        Me.btntypeupdate.Size = New System.Drawing.Size(75, 23)
        Me.btntypeupdate.TabIndex = 5
        Me.btntypeupdate.Text = "Update"
        Me.btntypeupdate.UseVisualStyleBackColor = False
        '
        'btntypeLoad
        '
        Me.btntypeLoad.BackColor = System.Drawing.Color.White
        Me.btntypeLoad.ForeColor = System.Drawing.Color.Black
        Me.btntypeLoad.Location = New System.Drawing.Point(87, 174)
        Me.btntypeLoad.Name = "btntypeLoad"
        Me.btntypeLoad.Size = New System.Drawing.Size(75, 23)
        Me.btntypeLoad.TabIndex = 4
        Me.btntypeLoad.Text = "Load"
        Me.btntypeLoad.UseVisualStyleBackColor = False
        '
        'dtgtypelist
        '
        Me.dtgtypelist.AllowUserToAddRows = False
        Me.dtgtypelist.AllowUserToDeleteRows = False
        Me.dtgtypelist.AllowUserToResizeColumns = False
        Me.dtgtypelist.AllowUserToResizeRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgtypelist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgtypelist.Location = New System.Drawing.Point(6, 54)
        Me.dtgtypelist.Name = "dtgtypelist"
        Me.dtgtypelist.RowHeadersVisible = False
        Me.dtgtypelist.Size = New System.Drawing.Size(318, 114)
        Me.dtgtypelist.TabIndex = 3
        '
        'txtitemtype
        '
        Me.txtitemtype.Location = New System.Drawing.Point(77, 28)
        Me.txtitemtype.Name = "txtitemtype"
        Me.txtitemtype.Size = New System.Drawing.Size(247, 20)
        Me.txtitemtype.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category :"
        '
        'btnTypesave
        '
        Me.btnTypesave.BackColor = System.Drawing.Color.White
        Me.btnTypesave.ForeColor = System.Drawing.Color.Black
        Me.btnTypesave.Location = New System.Drawing.Point(6, 174)
        Me.btnTypesave.Name = "btnTypesave"
        Me.btnTypesave.Size = New System.Drawing.Size(75, 23)
        Me.btnTypesave.TabIndex = 0
        Me.btnTypesave.Text = "Save"
        Me.btnTypesave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.btnudelete)
        Me.GroupBox2.Controls.Add(Me.btnuupdate)
        Me.GroupBox2.Controls.Add(Me.btnuload)
        Me.GroupBox2.Controls.Add(Me.dtgulist)
        Me.GroupBox2.Controls.Add(Me.txtunit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnusave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 208)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Item Unit"
        '
        'btnudelete
        '
        Me.btnudelete.BackColor = System.Drawing.Color.White
        Me.btnudelete.ForeColor = System.Drawing.Color.Black
        Me.btnudelete.Location = New System.Drawing.Point(249, 174)
        Me.btnudelete.Name = "btnudelete"
        Me.btnudelete.Size = New System.Drawing.Size(75, 23)
        Me.btnudelete.TabIndex = 7
        Me.btnudelete.Text = "Delete"
        Me.btnudelete.UseVisualStyleBackColor = False
        '
        'btnuupdate
        '
        Me.btnuupdate.BackColor = System.Drawing.Color.White
        Me.btnuupdate.ForeColor = System.Drawing.Color.Black
        Me.btnuupdate.Location = New System.Drawing.Point(168, 174)
        Me.btnuupdate.Name = "btnuupdate"
        Me.btnuupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnuupdate.TabIndex = 5
        Me.btnuupdate.Text = "Update"
        Me.btnuupdate.UseVisualStyleBackColor = False
        '
        'btnuload
        '
        Me.btnuload.BackColor = System.Drawing.Color.White
        Me.btnuload.ForeColor = System.Drawing.Color.Black
        Me.btnuload.Location = New System.Drawing.Point(87, 174)
        Me.btnuload.Name = "btnuload"
        Me.btnuload.Size = New System.Drawing.Size(75, 23)
        Me.btnuload.TabIndex = 4
        Me.btnuload.Text = "Load"
        Me.btnuload.UseVisualStyleBackColor = False
        '
        'dtgulist
        '
        Me.dtgulist.AllowUserToAddRows = False
        Me.dtgulist.AllowUserToDeleteRows = False
        Me.dtgulist.AllowUserToResizeColumns = False
        Me.dtgulist.AllowUserToResizeRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgulist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgulist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgulist.Location = New System.Drawing.Point(6, 54)
        Me.dtgulist.Name = "dtgulist"
        Me.dtgulist.RowHeadersVisible = False
        Me.dtgulist.Size = New System.Drawing.Size(318, 114)
        Me.dtgulist.TabIndex = 3
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(72, 28)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(252, 20)
        Me.txtunit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Unit :"
        '
        'btnusave
        '
        Me.btnusave.BackColor = System.Drawing.Color.White
        Me.btnusave.ForeColor = System.Drawing.Color.Black
        Me.btnusave.Location = New System.Drawing.Point(9, 174)
        Me.btnusave.Name = "btnusave"
        Me.btnusave.Size = New System.Drawing.Size(75, 23)
        Me.btnusave.TabIndex = 0
        Me.btnusave.Text = "Save"
        Me.btnusave.UseVisualStyleBackColor = False
        '
        'frm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(361, 448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgtypelist As System.Windows.Forms.DataGridView
    Friend WithEvents txtitemtype As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTypesave As System.Windows.Forms.Button
    Friend WithEvents btntypeLoad As System.Windows.Forms.Button
    Friend WithEvents btntypeupdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnuupdate As System.Windows.Forms.Button
    Friend WithEvents btnuload As System.Windows.Forms.Button
    Friend WithEvents dtgulist As System.Windows.Forms.DataGridView
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnusave As System.Windows.Forms.Button
    Friend WithEvents btnudelete As System.Windows.Forms.Button
    Friend WithEvents btntypedel As System.Windows.Forms.Button
End Class
