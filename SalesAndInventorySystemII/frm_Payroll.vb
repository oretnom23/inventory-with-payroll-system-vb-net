Public Class frm_Payroll

 

    Private Sub txtPAssignCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPAssignCode.TextChanged
        Try
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " _
                 & " WHERE e.`emp_code`=ew.`emp_code` AND e.emp_code ='" & txtPAssignCode.Text & "'"
            reloadtxt(sql)

            If dt.Rows.Count > 0 Then
                txtPRateperday.Text = dt.Rows(0).Item("d_rate")
                txtPPayPeriod.Text = dt.Rows(0).Item("p_method")
                txtPEmployeeName.Text = dt.Rows(0).Item("emp_fname") _
                & " " & dt.Rows(0).Item("emp_lname") & " " & dt.Rows(0).Item("emp_mname")


            Else
                cleartext(GroupBox1)
                cleartext(GroupBox2)
                cleartext(GroupBox3)
                cleartext(GroupBox4)
                cleartext(GroupBox5)
                cleartext(GroupBox6)
                cleartext(GroupBox7)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtPNoDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPNoDays.TextChanged
        Try
            If Not IsNumeric(txtPNoDays.Text) Then
                txtPNoDays.Clear()

            End If
            txtPrateWage.Text = Double.Parse(txtPRateperday.Text * txtPNoDays.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPRegOtHr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPRegOtHr.TextChanged
        Try
            If Not IsNumeric(txtPRegOtHr.Text) Then
                txtPRegOtHr.Clear()
            End If
            Dim total As Double
            If txtPRegOtHr.Text = "" Then
                txtPregOt.Clear()
            Else
                total = Double.Parse(txtPRateperday.Text / 8)
                txtPregOt.Text = Double.Parse(total * txtPRegOtHr.Text)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrateWage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrateWage.TextChanged
        Try
            txtpgincome.Text = txtPrateWage.Text
        Catch ex As Exception
            '  MsgBox(ex.Message & " txtPrateWage_TextChanged")
        End Try
    End Sub

    Private Sub txtPregOt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPregOt.TextChanged
        Try

            txtpgincome.Text = ((txtPrateWage.Text) + Val(txtPregOt.Text)).ToString("N2")
        Catch ex As Exception
            'MsgBox(ex.Message & " txtPregOt_TextChanged")
        End Try
    End Sub
    Public Sub clearing(ByVal grp As GroupBox)

        For Each txt As Control In grp.Controls
            If txt.GetType Is GetType(TextBox) Then
                If txt.Text = "" Then
                    txtTotaldeduc.Text = ""
                End If
            End If
        Next

    End Sub

    Private Sub txtppagibig_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtTotaldeduc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotaldeduc.TextChanged
        Try
            txtpnetincome.Text = Double.Parse(txtpnetincome.Text - txtTotaldeduc.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtpdeducttot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeducttot.TextChanged
        Try
            txtpnetincome.Text = Double.Parse(txtpgincome.Text - txtpdeducttot.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtpdeduct1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtpgincome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpgincome.TextChanged
        txtpnetincome.Text = txtpgincome.Text
    End Sub
    Private Sub txtPholPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPholPay.TextChanged
        Try

            txtpgincome.Text = txtpgincome.Text + Val(txtPholPay.Text)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPsave.Click
        Try

            Dim transid As String
            reloadtxt("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 4")
            transid = dt.Rows(0).Item(0)

            If txtPNoDays.Text = "" Or txtPregOt.Text = "" Or txtPholPay.Text = "" _
            Then
                MsgBox("Missing data. Please fill up.", MsgBoxStyle.Exclamation)

            Else

                sql = "INSERT INTO `other_deduction` " _
                               & "(`emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, " _
                               & "`ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`,trans_id)" _
                               & " VALUES ('" & txtPAssignCode.Text & "','" & txtpdeductname1.Text & "','" _
                               & txtpdeduct1.Text & "','" & txtpdeductname2.Text & "','" & txtpdeduct2.Text _
                               & "','" & txtpdeductname3.Text & "','" & txtpdeductname3.Text _
                               & "','" & txtpdeductname4.Text & "','" & txtpdeductname4.Text _
                               & "','" & txtpdeducttot.Text & "','" & transid & "')"
                createNoMsg(sql)
                sql = "INSERT INTO  `payroll` " _
                & "(`emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`" _
                & ", `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`,`dateissued`,trans_id)" _
                & " VALUES ('" & txtPAssignCode.Text & "','" & txtPNoDays.Text & "','" _
                & txtPrateWage.Text & "','" & txtPregOt.Text & "','" & txtPholPay.Text _
                & "','" & txtpgincome.Text & "','" & txtpcadvance.Text & "','" & txtbvale.Text _
                & "','" & txtpphic.Text & "','" & txtppagibig.Text & "','" & txtpnetincome.Text _
                & "','" & txtpremarks.Text & "',Now(),'" & transid & "')"
                create(sql, "Payroll has been created successfully.", "No Payroll has been created")

 
                updateautonumber(4)
                txtPAssignCode.Text = ""



            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl3_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl3.Selected


        sql = "SELECT DISTINCT (" & _
            "p.`trans_id`" & _
            "),e.emp_code as 'Assign Code', CONCAT(  `emp_fname` ,  ' ',  `emp_lname` ,  ' ',  `emp_mname` ) AS  'Employee'" & _
            ",  `d_rate` AS 'DailyRate' ,  `num_days` AS 'NumberOfDays' ,  `r_wage` AS 'RateWage', " _
            & " `gross_sal` AS 'GrossIncome', `total_ded` AS 'TotalDeduction',  `net_income` AS 'NetIncome' ,  " & _
            " `position` AS 'Postion',`remarks` AS 'Remarks' ,`dateissued` AS 'DateIssued'    " & _
            "FROM  `employee` e,  `payroll` p,  `employee_workinfo` ew,  `other_deduction` od " & _
            "WHERE e.`emp_code` = p.`emp_code` " & _
            "AND p.`emp_code` = ew.`emp_code` " & _
            "AND p.`trans_id` = od.`trans_id` "
        reloadDtg(sql, dtgParollList)
        dtgParollList.Columns(0).Visible = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtPAssignCode.Text = ""
    End Sub

    Private Sub txtpcadvance_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpphic.Validated, txtppagibig.Validated, txtpdeduct4.Validated, txtpdeduct3.Validated, txtpdeduct2.Validated, txtpdeduct1.Validated, txtpcadvance.Validated, txtbvale.Validated
        Try
            txtpnetincome.Text = txtpgincome.Text
            clearing(GroupBox5)
            clearing(GroupBox6)
            txtpdeducttot.Text = Double.Parse(Val(txtpcadvance.Text) _
                                              + Val(txtbvale.Text) _
                                              + Val(txtpphic.Text) _
                                              + Val(txtppagibig.Text) _
                                               + Val(txtpdeduct1.Text) _
                                              + Val(txtpdeduct2.Text) _
                                              + Val(txtpdeduct3.Text) _
                                              + Val(txtpdeduct4.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtpcadvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpcadvance.TextChanged
        If Not IsNumeric(txtpcadvance.Text) Then
            txtpcadvance.Clear()
        End If
    End Sub

    Private Sub txtbvale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbvale.TextChanged
        If Not IsNumeric(txtbvale.Text) Then
            txtbvale.Clear()
        End If
    End Sub

    Private Sub txtpphic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpphic.TextChanged
        If Not IsNumeric(txtpphic.Text) Then
            txtpphic.Clear()
        End If
    End Sub

    Private Sub txtppagibig_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtppagibig.TextChanged
        If Not IsNumeric(txtppagibig.Text) Then
            txtppagibig.Clear()
        End If
    End Sub
    Private Sub txtPholPayDay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPholPayDay.TextChanged
        Try
            txtPholPay.Text = Double.Parse(txtPRateperday.Text * txtPholPayDay.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtpdeduct1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeduct1.TextChanged
        If Not IsNumeric(txtpdeduct1.Text) Then
            txtpdeduct1.Clear()
        End If
    End Sub

    Private Sub txtpdeduct2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeduct2.TextChanged
        If Not IsNumeric(txtpdeduct2.Text) Then
            txtpdeduct2.Clear()
        End If
    End Sub

    Private Sub txtpdeduct3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeduct3.TextChanged
        If Not IsNumeric(txtpdeduct3.Text) Then
            txtpdeduct3.Clear()
        End If
    End Sub

    Private Sub txtpdeduct4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeduct4.TextChanged
        If Not IsNumeric(txtpdeduct4.Text) Then
            txtpdeduct4.Clear()
        End If
    End Sub
    Private Sub txtpsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpsearch.TextChanged
        sql = "SELECT DISTINCT (" & _
             "p.`trans_id`" & _
             "),e.emp_code as 'Assign Code', CONCAT(  `emp_fname` ,  ' ',  `emp_lname` ,  ' ',  `emp_mname` ) AS  'Employee'" & _
             ",  `d_rate` AS 'DailyRate' ,  `num_days` AS 'NumberOfDays' ,  `r_wage` AS 'RateWage', " _
             & " `gross_sal` AS 'GrossIncome', `total_ded` AS 'TotalDeduction',  `net_income` AS 'NetIncome' ,  " & _
             " `position` AS 'Postion',`remarks` AS 'Remarks' ,`dateissued` AS 'DateIssued'    " & _
             "FROM  `employee` e,  `payroll` p,  `employee_workinfo` ew,  `other_deduction` od " & _
             "WHERE e.`emp_code` = p.`emp_code` " & _
             "AND p.`emp_code` = ew.`emp_code` " & _
             "AND p.`trans_id` = od.`trans_id` " & _
             "AND  (emp_fname  LIKE '%" & txtpsearch.Text & "%'" & _
             "OR  emp_lname  LIKE '%" & txtpsearch.Text & "%'" & _
             "OR e.emp_code LIKE '%" & txtpsearch.Text & "%')"
        reloadDtg(sql, dtgParollList)
        dtgParollList.Columns(0).Visible = False

    End Sub

    'Private Sub weeklypayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnweeklypayroll.Click
    '    reports("SELECT CONCAT(  `emp_lname` ,  ' , ',  `emp_fname` ),`num_days` ,  `d_rate` ,  `r_wage` ,  `overtime` , `hol_pay` ,  `gross_sal` ,  `cash_ad` ,  `bread_vale` ,  `philhealth` ,  `deduct1` ,  `ded_amount1` , `deduct2` ,  `ded_amount2` ,  `deduct3` ,  `ded_amount3` ,  `total_ded` ,  `net_income` ,`dateissued` " _
    '        & "FROM  `employee` e,  `employee_workinfo` we,  `payroll` p,  `other_deduction` od " _
    '        & "WHERE e.`emp_code` = p.`emp_code` " _
    '        & "AND p.`emp_code` = we.`emp_code` " _
    '        & "AND p.`trans_id` = od.`trans_id` ", "weeklypayroll", CrystalReportViewer1)
    'End Sub

    'Private Sub btnPayslip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayslip.Click
    '    sql = "SELECT CONCAT(  `emp_lname` ,  ' , ',  `emp_fname` ) ,`num_days` , `d_rate` ,  `r_wage` " _
    '    & ",  `overtime` , `hol_pay` ,  `gross_sal` ,  `cash_ad` ,  `bread_vale` ,  `philhealth` , " _
    '    & "`pag-ibig`,  `deduct1` ,  `ded_amount1` , `deduct2` ,  `ded_amount2` ,  `deduct3` ,  " _
    '    & "`ded_amount3` ,  `total_ded` ,  `net_income` ,`dateissued`" & _
    '    " FROM  `employee` e,  `employee_workinfo` we,  `payroll` p,  `other_deduction` od " & _
    '    " WHERE e.`emp_code` = p.`emp_code` " & _
    '    " AND p.`emp_code` = we.`emp_code` " & _
    '    " AND p.`trans_id` = od.`trans_id` "
    '    reports(sql, "payslip", CrystalReportViewer1)

    'End Sub

    Private Sub txtPPayPeriod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPPayPeriod.TextChanged

    End Sub

 
    Private Sub dtgParollList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgParollList.CellContentClick

    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub
    Private Sub TabPage9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage9.Click

    End Sub
    Private Sub txttrancode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttrancode.TextChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub txtPEmployeeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPEmployeeName.TextChanged

    End Sub
    Private Sub txtPAssignCode_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPAssignCode.SelectedItemChanged

    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Sub txtPRateperday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPRateperday.TextChanged

    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
    Private Sub txtpnetincome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpnetincome.TextChanged

    End Sub
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
    Private Sub txtpdeductname1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeductname1.TextChanged

    End Sub
    Private Sub txtpdeductname2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeductname2.TextChanged

    End Sub
    Private Sub txtpdeductname3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeductname3.TextChanged

    End Sub
    Private Sub txtpdeductname4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpdeductname4.TextChanged

    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub
    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub
    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub
    Private Sub txtpremarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpremarks.TextChanged

    End Sub
    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage8.Click

    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub TabControl3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl3.SelectedIndexChanged

    End Sub
End Class