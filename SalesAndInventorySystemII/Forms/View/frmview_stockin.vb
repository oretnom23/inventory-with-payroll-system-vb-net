Public Class frmview_stockin

    Private Sub frmview_stockin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `TRANSACTIONNUMBER`,concat(`FIRSTNAME`, `LASTNAME`) as 'SUPLIER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE` `TRANSACTIONDATE`, i.`QTY`, `TOTALPRICE` FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Suplier'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TRANSACTIONNUMBER`,concat(`FIRSTNAME`, `LASTNAME`) as 'SUPLIER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE` `TRANSACTIONDATE`, i.`QTY`, `TOTALPRICE` FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Suplier'" & _
        " AND (NAME like '%" & txtsearch.Text & "%' OR  TRANSACTIONNUMBER like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub
End Class