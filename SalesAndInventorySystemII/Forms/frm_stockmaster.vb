Public Class frm_stockmaster
    Dim itemid As String
    Dim maxcolumn As Integer
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        For Each txt As Control In pnl_stockmaster.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MsgBox("Filled up all the empty fields are required", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
            If TypeOf txt Is ComboBox Then
                If txt.Text = "" Or txt.Text = "----Select-----" Then
                    MsgBox("----Select----- is not valid.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Next

        Dim stockinID As String
        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 4")
        stockinID = dt.Rows(0).Item(0)

        sql = "SELECT * FROM tblitems WHERE ITEMID ='" & txtitemid.Text & "'"
        reloadtxt(sql)
        If dt.Rows.Count > 0 Then
            sql = "UPDATE tblitems SET `QTY`=`QTY` + " & Val(txtquantity.Text) & " WHERE `ITEMID`='" & txtitemid.Text & "'"
            create(sql, txtname.Text, txtname.Text)

        Else
            sql = "insert into tblitems  (ITEMID,`NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`,`UNIT`)" & _
                       "VALUES ('" & txtitemid.Text & "','" & txtname.Text & "','" & txtdescription.Text & "','" & cbotype.Text _
                       & "','" & txtprice.Text & "','" & txtquantity.Text & "','" & cbounit.Text & "')"
            create(sql, txtname.Text, txtname.Text)
        End If
       


        sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS)" & _
        " VALUES ('" & stockinID & "','" & txtitemid.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & txtquantity.Text & _
        "','" & txtprice.Text & "','0000000','StockIn')"
        createNoMsg(sql)  

        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" & _
        " VALUES ('" & stockinID & "','" & Format(Now, "yyyy-MM-dd") & "','StockIn','0000000')"
        createNoMsg(sql)

        updateautonumbercateg(cbotype.Text)
        loadautonumbercateg(cbotype.Text, txtitemid)
        updateautonumber(4)

        sql = "SELECT  `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems` "
        reloadDtg(sql, dtglist)
      
        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False

     
    End Sub

    Private Sub frm_stockmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

 
        sql = "SELECT   `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems` "
        reloadDtg(sql, dtglist)


        btnadd.Visible = False

        sql = "SELECT * FROM tblsettings WHERE PARA = 'Category'"
        fillcbo(sql, cbotype)
        sql = "SELECT * FROM tblsettings WHERE PARA = 'Unit'"
        fillcbo(sql, cbounit)

        cleartext(pnl_stockmaster)

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM tblitems WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            deletes(sql, "Item", "Item")

            sql = "SELECT   `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems` "
            reloadDtg(sql, dtglist)

            cleartext(pnl_stockmaster)

        Catch ex As Exception
            MsgBox("Action is invalid.", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        For Each txt As Control In pnl_stockmaster.Controls
            If TypeOf txt Is TextBox Then
                If txt.Text = "" Then
                    MsgBox("Filled up all the empty fields are required", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Next
        sql = "UPDATE tblitems SET `NAME`='" & txtname.Text & "', `DESCRIPTION`='" & txtdescription.Text & "', `TYPE`='" & cbotype.Text & "', `PRICE`='" & txtprice.Text & "',`UNIT`='" & cbounit.Text & "'" & _
            " WHERE ITEMID='" & txtitemid.Text & "'"
        updates(sql, txtname.Text, txtname.Text)

        sql = "SELECT  `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems`  "
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)

    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        sql = "SELECT   `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems` "
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)

    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
        
            Dim itemid As String
            itemid = dtglist.CurrentRow.Cells(0).Value
            sql = "SELECT  * FROM `tblitems` WHERE ITEMID='" & itemid & "'"
            reloadtxt(sql)
            txtitemid.Text = dt.Rows(0).Item(0)
            txtname.Text = dt.Rows(0).Item(1)
            txtdescription.Text = dt.Rows(0).Item(2)
            txtprice.Text = dt.Rows(0).Item(4)
            cbotype.Text = dt.Rows(0).Item(3)
            cbounit.Text = dt.Rows(0).Item("UNIT")
            txtquantity.Text = dt.Rows(0).Item("QTY")

            TabControl1.SelectTab(TabPage2)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems` WHERE ITEMID LIKE '%" & txtsearch.Text & "%' OR NAME LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)

        maxcolumn = dtglist.Columns.Count - 1


    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        frm_transaction.txtSup_itemid.Text = dtglist.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        sql = "SELECT   `ITEMID` as 'ITEMCODE', `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY` as 'QUANTITY', `UNIT` FROM `tblitems`"
        reloadDtg(sql, dtglist)

    End Sub

    Private Sub cbotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotype.SelectedIndexChanged
        Try
            If cbotype.SelectedIndex = 0 And cbotype.Text.ToString() = "System.Data.DataRowView" Then
                Return
            Else
                loadautonumbercateg(cbotype.Text, txtitemid)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtquantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantity.KeyPress

        Try
            If e.KeyChar <> ChrW(Keys.Back) Then
                If Char.IsNumber(e.KeyChar) Then
                Else
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress
        Try
            If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then 

                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class