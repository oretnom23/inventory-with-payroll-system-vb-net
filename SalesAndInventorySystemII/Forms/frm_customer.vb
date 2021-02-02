Public Class frm_customer
    Dim maxcolumn
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "INSERT INTO tblperson (`SUPLIERCUSTOMERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`)" & _
        " VALUES ('" & txtcustomerid.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "','Customer')"
        create(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)

        sql = "SELECT  `SUPLIERCUSTOMERID` as 'CUSTORMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False


        updateautonumber(1)

        loadautonumber(1, txtcustomerid)

        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblperson SET  `FIRSTNAME`='" & txtfname.Text & "', `LASTNAME`='" & txtlname.Text & _
        "', `ADDRESS`='" & txtaddress.Text & "', `TELEPHONE`='" & txttelephone.Text & "', `MOBILE`='" & txtmobile.Text & "' WHERE `SUPLIERCUSTOMERID`='" & txtcustomerid.Text & "'"
        updates(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)

        sql = "SELECT  `SUPLIERCUSTOMERID` as 'CUSTORMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False


        loadautonumber(1, txtcustomerid)

        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM tblperson WHERE `SUPLIERCUSTOMERID`='" & txtcustomerid.Text & "'"
            deletes(sql, txtcustomerid.Text, txtcustomerid.Text)

            sql = "SELECT `SUPLIERCUSTOMERID` as 'CUSTORMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE ='Customer'"
            reloadDtg(sql, dtglist)

            cleartext(Panel1)

            maxcolumn = dtglist.Columns.Count - 1
            dtglist.Columns(maxcolumn).Visible = False

            loadautonumber(1, txtcustomerid)

            btnsave.Enabled = True
            btnupdate.Enabled = False
            btndelete.Enabled = False
        Catch ex As Exception
            MsgBox("Action is not valid", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `SUPLIERCUSTOMERID` as 'CUSTORMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE ='Customer' AND  SUPLIERCUSTOMERID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        
        loadautonumber(1, txtcustomerid)

    End Sub

    Private Sub frm_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT `SUPLIERCUSTOMERID` as 'CUSTORMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(1, txtcustomerid)

        btnsave.Enabled = True
        btndelete.Enabled = False
        btnupdate.Enabled = False

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click

        sql = "SELECT `SUPLIERCUSTOMERID` as 'CUSTORMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

        loadautonumber(1, txtcustomerid)

        btnsave.Enabled = True
        btnupdate.Enabled = False

    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try

            TabControl1.SelectTab(TabPage2)

            btnsave.Enabled = False
            btnupdate.Enabled = True
            btndelete.Enabled = True

            txtcustomerid.Text = dtglist.CurrentRow.Cells(0).Value
            reloadtxt("SELECT * FROM tblperson WHERE SUPLIERCUSTOMERID ='" & dtglist.CurrentRow.Cells(0).Value & "'")
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
        ftrans.txt_cusid.Text = dtglist.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class