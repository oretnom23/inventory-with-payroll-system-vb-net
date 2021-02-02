Public Class frm_viewTransaction

    Private Sub frm_viewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " SELECT `TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `FIRSTNAME`, `LASTNAME`  FROM `tbltransaction` t,`tblperson` c WHERE  c.`SUPLIERCUSTOMERID`=t.`SUPLIERCUSTOMERID`"
        reloadDtg(sql, dtglist)
    End Sub
 
    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            frm_transaction.txttransactionid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class