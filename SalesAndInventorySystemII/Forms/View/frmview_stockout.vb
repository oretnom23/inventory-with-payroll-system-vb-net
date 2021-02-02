Public Class frmview_stockout

    Private Sub frmview_stockout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `TRANSACTIONNUMBER` As 'Transaction Number',concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',`NAME` as 'Item Name', `Description`, `PRICE`  as 'Price',`TRANSACTIONDATE` As 'Date', o.`QTY` as 'Quantity', `TOTALPRICE` as 'Total Price' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'"
        reloadDtg(sql, dtglist)
    End Sub
    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
       
    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click

        If ComboBox1.Text = "Items" Then
            sql = "SELECT  `TRANSACTIONNUMBER` As 'Transaction Number',concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',`NAME` as 'Item Name', `Description`, `PRICE`  as 'Price',`TRANSACTIONDATE` As 'Date', o.`QTY` as 'Quantity', `TOTALPRICE` as 'Total Price' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" & _
               " AND (NAME like '%" & txtsearch.Text & "%' OR  i.ITEMID like '%" & txtsearch.Text & "%')"
            reloadDtg(sql, dtglist)
        ElseIf ComboBox1.Text = "Customer" Then
            sql = "SELECT  `TRANSACTIONNUMBER` As 'Transaction Number',concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',`NAME` as 'Item Name', `Description`, `PRICE`  as 'Price',`TRANSACTIONDATE` As 'Date', o.`QTY` as 'Quantity', `TOTALPRICE` as 'Total Price' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" & _
            " AND (`FIRSTNAME` like '%" & txtsearch.Text & "%' OR  i.CUSTOMERID like '%" & txtsearch.Text & "%' OR `LASTNAME` like '%" & txtsearch.Text & "%' )"
        ElseIf ComboBox1.Text = "Transaction Number" Then
            sql = "SELECT   `TRANSACTIONNUMBER` As 'Transaction Number',concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',`NAME` as 'Item Name', `Description`, `PRICE`  as 'Price',`TRANSACTIONDATE` As 'Date', o.`QTY` as 'Quantity', `TOTALPRICE` as 'Total Price' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" & _
                " AND (NAME like '%" & txtsearch.Text & "%' OR  TRANSACTIONNUMBER like '%" & txtsearch.Text & "%')"
            reloadDtg(sql, dtglist)
        End If
       
    End Sub
End Class