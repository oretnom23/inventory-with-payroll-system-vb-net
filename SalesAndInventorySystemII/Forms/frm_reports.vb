Public Class frm_reports

    Private Sub btnListStockin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListStockin.Click

        If cbooption.Text = "Daily Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`, (`PRICE` * so.`QTY` ) as 'Total Price', `TRANSACTIONDATE` FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn'  AND DATE(`TRANSACTIONDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`, (`PRICE` * so.`QTY` ) as 'Total Price', `TRANSACTIONDATE` FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn'  AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`, (`PRICE` * so.`QTY` ) as 'Total Price', `TRANSACTIONDATE` FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn'  AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())"
        End If

        reports(sql, "itemlist", CrystalReportViewer1)
    End Sub

    Private Sub btnStockOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockOut.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " & _
                          " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" & _
                          " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND DATE(`TRANSACTIONDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " & _
                " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" & _
                " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " & _
                " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" & _
                " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())"
        End If
        reports(sql, "soldList", CrystalReportViewer1)
    End Sub

    Private Sub btnStockReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockReturn.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer', `STOCKRETURNNUMBER`,`NAME` AS 'Item',DATE( `RETURNDATE`) as 'Date', r.`QTY` as 'Quantity',`TOTALPRICE` as 'Total Price' FROM `tblstock_return` r,`tblitems` i,`tblperson` p WHERE r.`ITEMID`=i.`ITEMID` AND p.`SUPLIERCUSTOMERID`=r.`OWNER_CUS_ID` AND DATE(`RETURNDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer', `STOCKRETURNNUMBER`,`NAME` AS 'Item',DATE( `RETURNDATE`) as 'Date', r.`QTY` as 'Quantity',`TOTALPRICE` as 'Total Price' FROM `tblstock_return` r,`tblitems` i,`tblperson` p WHERE r.`ITEMID`=i.`ITEMID` AND p.`SUPLIERCUSTOMERID`=r.`OWNER_CUS_ID`  AND WEEKDAY(`RETURNDATE`) >=0 AND WEEKDAY(`RETURNDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer', `STOCKRETURNNUMBER`,`NAME` AS 'Item',DATE( `RETURNDATE`) as 'Date', r.`QTY` as 'Quantity',`TOTALPRICE` as 'Total Price' FROM `tblstock_return` r,`tblitems` i,`tblperson` p WHERE r.`ITEMID`=i.`ITEMID` AND p.`SUPLIERCUSTOMERID`=r.`OWNER_CUS_ID`  AND MONTH(`RETURNDATE`)=MONTH(CURDATE())"
        End If
  reports(sql, "returnList", CrystalReportViewer1)
    End Sub

   
    Private Sub dptfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dptfrom.ValueChanged, dtpto.ValueChanged
        sql = "SELECT  `NAME` ,  `DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
                "FROM  `tblitems` i" & _
                " LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` " & _
                " AND REMARKS =  'StockOut' and TRANSACTIONDATE between '" & Format(dptfrom.Value, "yyyy-MM-dd") & "' and '" & Format(dtpto.Value, "yyyy-MM-dd") & "'"
        reports(sql, "inventory", CrystalReportViewer1)
    End Sub
  
   
    Private Sub btnitemlisat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnitemlisat.Click
        sql = "SELECT * FROM `tblitems`"
        reports(sql, "allitems", CrystalReportViewer1)
    End Sub
 
  
    Private Sub btnstats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstats.Click

        If cbooption.Text = "Daily Report" Then
            sql = "SELECT i.ITEMID, `NAME` , `DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
              "FROM  `tblitems` i " & _
              "LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` AND REMARKS='StockOut' AND DATE(`TRANSACTIONDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT i.ITEMID, `NAME` , `DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
              "FROM  `tblitems` i " & _
              "LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` AND REMARKS='StockOut' AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT i.ITEMID, `NAME` , `DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
              "FROM  `tblitems` i " & _
              "LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` AND REMARKS='StockOut' AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())"
        End If
        
        reports(sql, "inventory", CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT i.ITEMID,`NAME` ,`DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
                    " FROM  `tblitems` i" & _
                    " LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` AND REMARKS='StockOut'  AND DATE(`TRANSACTIONDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT i.ITEMID,`NAME` ,`DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
                    " FROM  `tblitems` i" & _
                    " LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` AND REMARKS='StockOut'  AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT i.ITEMID,`NAME` ,`DESCRIPTION` ,  `TYPE` , i.`QTY` AS  'Stock-In',  `UNIT` , o.`QTY` AS  'Stock-Out',  `TRANSACTIONDATE` ,  `REMARKS` " & _
                    " FROM  `tblitems` i" & _
                    " LEFT JOIN  `tblstock_in_out` o ON i.`ITEMID` = o.`ITEMID` AND REMARKS='StockOut'  AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())"
        End If

        reports(sql, "mostpurchased", CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cbooption.Text = "Daily Report" Then
            sql = "SELECT concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer', `STOCKRETURNNUMBER`,`NAME` AS 'Products',`DESCRIPTION`,`PRICE`,DATE( `RETURNDATE`) as 'Date', r.`QTY` as 'Quantity',`TOTALPRICE` as 'Total Price' FROM `tblstock_return` r,`tblitems` i,`tblperson` p WHERE r.`ITEMID`=i.`ITEMID` AND p.`SUPLIERCUSTOMERID`=r.`OWNER_CUS_ID`  AND DATE(`RETURNDATE`)=CURDATE()"
        ElseIf cbooption.Text = "Weekly Report" Then
            sql = "SELECT concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer', `STOCKRETURNNUMBER`,`NAME` AS 'Products',`DESCRIPTION`,`PRICE`,DATE( `RETURNDATE`) as 'Date', r.`QTY` as 'Quantity',`TOTALPRICE` as 'Total Price' FROM `tblstock_return` r,`tblitems` i,`tblperson` p WHERE r.`ITEMID`=i.`ITEMID` AND p.`SUPLIERCUSTOMERID`=r.`OWNER_CUS_ID`   AND WEEKDAY(`RETURNDATE`) >=0 AND WEEKDAY(`RETURNDATE`) <=4"
        ElseIf cbooption.Text = "Monthly Report" Then
            sql = "SELECT concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer', `STOCKRETURNNUMBER`,`NAME` AS 'Products',`DESCRIPTION`,`PRICE`,DATE( `RETURNDATE`) as 'Date', r.`QTY` as 'Quantity',`TOTALPRICE` as 'Total Price' FROM `tblstock_return` r,`tblitems` i,`tblperson` p WHERE r.`ITEMID`=i.`ITEMID` AND p.`SUPLIERCUSTOMERID`=r.`OWNER_CUS_ID`  AND MONTH(`RETURNDATE`)=MONTH(CURDATE())"
        End If
        reports(sql, "damage", CrystalReportViewer1)
    End Sub
End Class