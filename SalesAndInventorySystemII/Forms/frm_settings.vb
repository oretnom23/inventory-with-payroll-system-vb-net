Public Class frm_settings
    Dim typeid As Integer = 0
    Dim unitid As Integer = 0
    Private Sub btnTypesave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTypesave.Click
        If txtitemtype.Text = "" Then
            MsgBox("Fields is empty!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtitemtype.Text & "','Category')"
        create(sql, txtitemtype.Text, txtitemtype.Text)

        sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" & _
        " VALUES ('" & txtitemtype.Text.Substring(0, 1) & "0000" & "',1,1,'" & txtitemtype.Text & "')"
        createNoMsg(sql)

        txtitemtype.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
    End Sub

    Private Sub btntypeLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntypeLoad.Click
        sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
        txtitemtype.Clear()
    End Sub
 
    Private Sub dtgtypelist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgtypelist.DoubleClick
        txtitemtype.Text = dtgtypelist.CurrentRow.Cells(1).Value
        typeid = dtgtypelist.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btntypeupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntypeupdate.Click
        If txtitemtype.Text = "" Then
            MsgBox("Fields is empty!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtitemtype.Text & "' WHERE ID ='" & typeid & "'"
        updates(sql, txtitemtype.Text, txtitemtype.Text)
        sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
        txtitemtype.Clear()
    End Sub

    Private Sub btnuload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuload.Click
        sql = "SELECT ID, DESCRIPTION as 'Unit' FROM tblsettings WHERE PARA='Unit'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
        txtunit.Clear()
    End Sub

    Private Sub btnusave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusave.Click
        If txtunit.Text = "" Then
            MsgBox("Fields is empty!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtunit.Text & "','Unit')"
        create(sql, txtunit.Text, txtunit.Text)
        txtunit.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Unit' FROM tblsettings WHERE PARA='Unit'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
    End Sub

    Private Sub btnuupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuupdate.Click
        If txtunit.Text = "" Then
            MsgBox("Fields is empty!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtitemtype.Text & "' WHERE ID ='" & unitid & "'"
        updates(sql, txtunit.Text, txtunit.Text)
        sql = "SELECT ID, DESCRIPTION as 'Unit' FROM tblsettings WHERE PARA='Unit'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
        txtunit.Clear()
    End Sub
 

    Private Sub dtgulist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgulist.DoubleClick
        txtunit.Text = dtgulist.CurrentRow.Cells(1).Value
        unitid = dtgulist.CurrentRow.Cells(0).Value
    End Sub

    Private Sub frm_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Call btntypeLoad_Click(sender, e)
        Call btnuload_Click(sender, e)
        dtgtypelist.DefaultCellStyle.ForeColor = Color.Black
        dtgulist.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub btntypedel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntypedel.Click
        sql = "DELETE FROM `tblsettings` WHERE  `ID`='" & dtgtypelist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtitemtype.Text, txtitemtype.Text)

        Call frm_settings_Load(sender, e)
        
    End Sub

    Private Sub btnudelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnudelete.Click
        sql = "DELETE FROM `tblsettings` WHERE  `ID`='" & dtgulist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtunit.Text, txtunit.Text)

        sql = "DELETE FROM  `tblautonumber` WHERE  `DESCRIPTION` ='" & dtgtypelist.CurrentRow.Cells(1).Value & "'"
        createNoMsg(sql)
        Call frm_settings_Load(sender, e)

    End Sub

    Private Sub txtitemtype_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemtype.TextChanged

    End Sub
End Class