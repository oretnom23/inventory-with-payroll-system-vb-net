Public Class frm_suplier  
    Dim maxcolumn
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "INSERT INTO tblperson (`SUPLIERCUSTOMERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`)" & _
        " VALUES ('" & txtsuplierid.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "','SUPLIER')"
        create(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)

        sql = "SELECT `SUPLIERCUSTOMERID` as 'SUPLIERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        updateautonumber(3)

        loadautonumber(3, txtsuplierid)

        btndelete.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblperson SET  `FIRSTNAME`='" & txtfname.Text & "', `LASTNAME`='" & txtlname.Text & _
        "', `ADDRESS`='" & txtaddress.Text & "', `TELEPHONE`='" & txttelephone.Text & "', `MOBILE`='" & txtmobile.Text & "' WHERE `SUPLIERCUSTOMERID`='" & txtsuplierid.Text & "'"
        updates(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)

        sql = "SELECT `SUPLIERCUSTOMERID` as 'SUPLIERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(3, txtsuplierid)

        btndelete.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "DELETE FROM tblperson WHERE `SUPLIERCUSTOMERID`='" & txtsuplierid.Text & "'"
        deletes(sql, txtsuplierid.Text, txtsuplierid.Text)

        sql = "SELECT `SUPLIERCUSTOMERID` as 'SUPLIERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE = 'SUPLIER'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(3, txtsuplierid)

        btndelete.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `SUPLIERCUSTOMERID` as 'SUPLIERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE='SUPLIER' AND SUPLIERCUSTOMERID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(3, txtsuplierid)
    End Sub

    Private Sub frm_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT `SUPLIERCUSTOMERID` as 'SUPLIERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(3, txtsuplierid)

        btndelete.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click

        sql = "SELECT `SUPLIERCUSTOMERID` as 'SUPLIERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(3, txtsuplierid)

        btndelete.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            TabControl1.SelectTab(TabPage2)

            btndelete.Enabled = True
            btnupdate.Enabled = True
            btnsave.Enabled = False
            txtsuplierid.Text = dtglist.CurrentRow.Cells(0).Value
            reloadtxt("SELECT * FROM tblperson WHERE TYPE='SUPLIER' AND SUPLIERCUSTOMERID ='" & txtsuplierid.Text & "'")
            txtfname.Text = dt.Rows(0).Item("FIRSTNAME")
            txtlname.Text = dt.Rows(0).Item("LASTNAME")
            txtaddress.Text = dt.Rows(0).Item("ADDRESS")
            txttelephone.Text = dt.Rows(0).Item("TELEPHONE")
            txtmobile.Text = dt.Rows(0).Item("MOBILE")
        Catch ex As Exception
            MsgBox("Action is not valid.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        frm_transaction.txt_suplierId.Text = dtglist.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub dtglist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class