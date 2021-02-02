Public Class ftrans 
    Dim stockoutID As Integer = 0
    Dim itemID As String = ""

    Private Sub frm_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID=5")
        lblreceipt.Text = dt.Rows(0).Item(0).ToString()

        sql = "SELECT `ITEMID` as 'ITEMCODE', `NAME`  FROM `tblitems`  "
        reloadDtg(sql, dtglist)

    End Sub








    Private Sub txt_cusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cusid.TextChanged
        Try
            sql = "SELECT * FROM `tblperson` WHERE `SUPLIERCUSTOMERID`='" & txt_cusid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtCus_fname.Text = dt.Rows(0).Item("FIRSTNAME") & "  " & dt.Rows(0).Item("LASTNAME")

            Else
                txtCus_fname.Clear()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `ITEMID`, `NAME` FROM `tblitems` WHERE  `NAME` like '%" & txtsearch.Text & "%' or `ITEMID` = '" & txtsearch.Text & "'"
        reloadDtg(sql, dtglist)
    End Sub


    Private Sub btncus_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncus_search.Click
        frm_customer.Show()
        frm_customer.btnadd.Visible = True
    End Sub

    Private Sub btnCus_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_add.Click
        Try
            For Each ctr As Control In Me.Controls
                If TypeOf ctr Is Panel Then
                    For Each txt As Control In ctr.Controls
                        If TypeOf txt Is TextBox Then
                            If txt.Text = "" Then
                                MsgBox("There are empty fields to be filled up.", MsgBoxStyle.Exclamation)
                                Exit Sub
                            End If
                        End If
                    Next
                End If
            Next



            If dtCus_addedlist.RowCount = 0 Then

                dtCus_addedlist.ColumnCount = 6
                dtCus_addedlist.Columns(0).Name = "Item Id"
                dtCus_addedlist.Columns(1).Name = "Item Name"
                dtCus_addedlist.Columns(2).Name = "Description"
                dtCus_addedlist.Columns(3).Name = "Price"
                dtCus_addedlist.Columns(4).Name = "Quantity"
                dtCus_addedlist.Columns(5).Name = "Total Price"

                Dim tot As Integer = Val(txtprice.Text) * Val(txtqty.Text)

                Dim row As String() = New String() {txtitemid.Text, _
                                               txtitemname.Text, _
                                               txtdesc.Text, _
                                               txtprice.Text, _
                                               txtqty.Text, _
                                               tot}
                dtCus_addedlist.Rows.Add(row)

                cleartext(Panel3)
            Else
                If dtCus_addedlist.CurrentRow.Cells(0).Value <> txtitemid.Text Then
                    dtCus_addedlist.ColumnCount = 6
                    dtCus_addedlist.Columns(0).Name = "Item Id"
                    dtCus_addedlist.Columns(1).Name = "Item Name"
                    dtCus_addedlist.Columns(2).Name = "Description"
                    dtCus_addedlist.Columns(3).Name = "Price"
                    dtCus_addedlist.Columns(4).Name = "Quantity"
                    dtCus_addedlist.Columns(5).Name = "Total Price"

                    Dim tot As Integer = Val(txtprice.Text) * Val(txtqty.Text)

                    Dim row As String() = New String() {txtitemid.Text, _
                                                   txtitemname.Text, _
                                                   txtdesc.Text, _
                                                   txtprice.Text, _
                                                   txtqty.Text, _
                                                   tot}
                    dtCus_addedlist.Rows.Add(row)

                    cleartext(Panel3)

                Else
                    MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCus_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_Remove.Click
        Try
            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCus_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_clear.Click
        dtCus_addedlist.Rows.Clear()
    End Sub

    Private Sub btnCus_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_save.Click

        If dtCus_addedlist.Rows.Count = 0 Then
            MsgBox("Cart is empty. Required to add the item in the cart.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'autoreceipt("receiptid", lblreceipt)

        For Each r As DataGridViewRow In dtCus_addedlist.Rows
            sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS,`OFFICIALRECEIPT`)" &
            " VALUES ('" & lblreceipt.Text & "','" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & txt_cusid.Text & "','StockOut','" & lblreceipt.Text & "')"
            createNoMsg(sql)

            sql = "UPDATE `tblitems`  SET `QTY`= QTY - '" & r.Cells(4).Value & "' WHERE ITEMID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)
        Next

        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" &
       " VALUES ('" & lblreceipt.Text & "','" & Format(Now, "yyyy-MM-dd") & "','StockOut','" & txt_cusid.Text & "')"
        createNoMsg(sql)

        createNoMsg("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5")

        variableautonum(5, lblreceipt.Text)
        'reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5")
        'stockoutID = dt.Rows(0).Item(0)

        MsgBox("Item(s) has been saved in the database.")

        cleartext(Panel3)
        cleartext(Panel2)
        dtCus_addedlist.Rows.Clear()
        sql = "SELECT `TRANSACTIONNUMBER`,concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',`ADDRESS`,`NAME`, `TRANSACTIONDATE`, s.`QTY`, `TOTALPRICE`,`OFFICIALRECEIPT`  FROM `tblstock_in_out` s, `tblitems` i,`tblperson` p  WHERE  i.`ITEMID`=s.`ITEMID`   AND p.`SUPLIERCUSTOMERID`=s.`SUPLIERCUSTOMERID` AND OFFICIALRECEIPT ='" & lblreceipt.Text & "'"
        reports(sql, "receipt", frm_receipt.CrystalReportViewer1)
        frm_receipt.Show()
        frm_receipt.Focus()
        reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID=5")
        lblreceipt.Text = dt.Rows(0).Item(0).ToString()
        'autoreceiptupdate("receiptid")



    End Sub



    Private Sub btnviewStockout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewStockout.Click
        frmview_stockout.Show()
        frmview_stockout.Focus()
    End Sub
    Private Sub dtglist_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglist.CellClick
        Try
            sql = "SELECT * FROM tblitems WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtitemid.Text = dt.Rows(0).Item("ITEMID")
                txtitemname.Text = dt.Rows(0).Item("NAME")
                txtdesc.Text = dt.Rows(0).Item("DESCRIPTION")
                txtavailQty.Text = dt.Rows(0).Item("QTY")
                txtprice.Text = dt.Rows(0).Item("PRICE")
                txtunit.Text = dt.Rows(0).Item("UNIT")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        Try
            If Val(txtavailQty.Text) < Val(txtqty.Text) Then
                MsgBox("The quantity is greater than the available quantity of the items.", MsgBoxStyle.Exclamation)
                txtqty.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick

    End Sub
End Class