Public Class frm_stockreturn
    Dim stockreturnID As String
    Dim returnid As String
    Dim transid As String
    Dim cusid As String
   
    Private Sub dtglist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist.CellClick
        Try
            sql = "SELECT p.SUPLIERCUSTOMERID, `FIRSTNAME`, `LASTNAME` ,`ADDRESS` FROM  `tbltransaction` t, `tblperson`  p  WHERE t.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND `TRANSACTIONNUMBER`='" & dtglist.CurrentRow.Cells(0).Value & "'"
            reloadtxt(sql)
            txttranid.Text = dtglist.CurrentRow.Cells(0).Value
            txtcusid.Text = dt.Rows(0).Item("SUPLIERCUSTOMERID")
            txtreturn_name.Text = dt.Rows(0).Item("FIRSTNAME") & " " & dt.Rows(0).Item("LASTNAME")
            txtreturn_address.Text = dt.Rows(0).Item("ADDRESS")

            sql = "SELECT   i.`ITEMID`, `NAME`, `DESCRIPTION`, `PRICE`,`TRANSACTIONDATE`, o.`QTY` AS 'QUANTITY', `TOTALPRICE`,`STOCKOUTID`  FROM  `tblitems` i , `tblstock_in_out` o WHERE i.`ITEMID`=o.`ITEMID` AND `TRANSACTIONNUMBER`='" & dtglist.CurrentRow.Cells(0).Value & "'"
            reloadDtg(sql, dtgreturn_itemlist)
            dtgreturn_itemlist.Columns(7).Visible = False
        Catch ex As Exception

        End Try

       
    End Sub

    Private Sub frm_stockreturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = " SELECT `TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `FIRSTNAME`, `LASTNAME`  FROM `tbltransaction` t,`tblperson` c WHERE t.`TYPE`='StockOut' AND  c.`SUPLIERCUSTOMERID`=t.`SUPLIERCUSTOMERID`"
            reloadDtg(sql, dtglist)

            reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
            stockreturnID = dt.Rows(0).Item(0)

            sql = "SELECT concat(`FIRSTNAME`, ' ',`LASTNAME`) as 'Name', `ADDRESS`,`NAME` as 'ITEM', `RETURNDATE` as 'DATE RETURNED', r.`QTY` AS 'QUANTITY', `TOTALPRICE` AS 'TOTAL PRICE',r_REMARKS as 'REMARKS' FROM `tblstock_return` r, `tblitems` i, `tblperson` p WHERE `OWNER_CUS_ID`=`SUPLIERCUSTOMERID` AND i.`ITEMID`=r.`ITEMID`"
            reloadDtg(sql, dtglistreturn)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtgreturn_itemlist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgreturn_itemlist.CellClick
        Try
            With dtgreturn_itemlist.CurrentRow
                If .Cells(5).Value = 0 Then
                  
                    MsgBox("Action cannot be perform because the Quantity of the item is less than 1.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                txtitemid.Text = .Cells(0).Value
                txtiname.Text = .Cells(1).Value
                txtdesc.Text = .Cells(2).Value
                txtiprice.Text = .Cells(3).Value
                txtsqty.Text = .Cells(5).Value
            End With

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtrqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrqty.TextChanged
        Try
            If txtrqty.Text = "" Then
                txtsqty.Text = dtgreturn_itemlist.CurrentRow.Cells(5).Value
                txtrprice.Clear()
            Else
                If Val(txtsqty.Text) < Val(txtrqty.Text) Then
                    MsgBox("out of range quantity", MsgBoxStyle.Exclamation)
                    txtrqty.Clear()
                    txtrprice.Clear()
                Else 
                    txtrprice.Text = Val(txtiprice.Text) * Val(txtrqty.Text) 
                End If
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreturn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_save.Click
        Try
            If dtgreturn_itemlist.Rows.Count = 0 Or txtcusid.Text = "" Or txtrqty.Text = "" Then
                MsgBox("Required to fill up all the empty fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            sql = "INSERT INTO `tblstock_return` (  `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`,r_REMARKS)" & _
       " VALUES ('" & stockreturnID & "','" & txtitemid.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & txtrqty.Text & _
       "','" & txtrprice.Text & "','" & txtcusid.Text & "','" & txtremarks.Text & "')"
            createNoMsg(sql)
            sql = "UPDATE `tblitems`  SET `QTY`=`QTY` + '" & txtrqty.Text & "' WHERE ITEMID='" & txtitemid.Text & "'"
            createNoMsg(sql)

            sql = "UPDATE `tblstock_in_out`  SET  QTY =QTY-'" & txtrqty.Text & "',`TOTALPRICE`=`TOTALPRICE`-'" & txtrprice.Text & "' WHERE `STOCKOUTID` ='" & dtgreturn_itemlist.CurrentRow.Cells(7).Value & "'"
            createNoMsg(sql)



            sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" & _
           " VALUES ('" & txttranid.Text & "','" & Format(Now, "yyyy-MM-dd") & "','Returned','" & txtcusid.Text & "')"
            createNoMsg(sql)

            createNoMsg("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 6")

            reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 6")
            stockreturnID = dt.Rows(0).Item(0)

            MsgBox("Item(s) has been returned.")

            cleartext(GroupBox4)

            sql = "SELECT concat(`FIRSTNAME`, ' ',`LASTNAME`) as 'Name', `ADDRESS`,`NAME` as 'ITEM', `RETURNDATE` as 'DATE RETURNED', r.`QTY` AS 'QUANTITY', `TOTALPRICE` AS 'TOTAL PRICE',r_REMARKS as 'REMARKS' FROM `tblstock_return` r, `tblitems` i, `tblperson` p WHERE `OWNER_CUS_ID`=`SUPLIERCUSTOMERID` AND i.`ITEMID`=r.`ITEMID`"
            reloadDtg(sql, dtglistreturn)

        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            sql = " SELECT `TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `FIRSTNAME`, `LASTNAME`  FROM `tbltransaction` t,`tblperson` c WHERE t.`TYPE`='StockOut' AND  c.`SUPLIERCUSTOMERID`=t.`SUPLIERCUSTOMERID` AND TRANSACTIONNUMBER Like '%" & txtsearch.Text & "%'"
            reloadDtg(sql, dtglist)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnvewlreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvewlreturn.Click
        Me.Close()
    End Sub

    Private Sub btnreturn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_clear.Click
        Try
            cleartext(GroupBox4)
        Catch ex As Exception

        End Try
    End Sub
End Class