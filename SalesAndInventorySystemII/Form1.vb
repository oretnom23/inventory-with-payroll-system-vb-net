Public Class Form1
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frm_stockmaster.Show()
        frm_stockmaster.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ftrans.Show()
        ftrans.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frm_stockreturn.Show()
        frm_stockreturn.Focus()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frm_customer.Show()
        frm_customer.Focus()
    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserToolStripMenuItem.Click
        frm_adduser.Show()
        frm_adduser.Focus()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        frm_settings.Show()
        frm_settings.Focus()
    End Sub

   

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_Login.Show()
        With frm_Login
            .PasswordTextBox.Clear()
            .UsernameTextBox.Clear()
            .UsernameTextBox.Focus()
        End With
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        frm_Employee.Show()
    End Sub

    Private Sub CreatePayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePayrollToolStripMenuItem.Click
        frm_Payroll.Show()
    End Sub

    Private Sub InventoryReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryReportsToolStripMenuItem.Click
        frm_reports.Show()
        frm_reports.Focus()
    End Sub

    Private Sub PayslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayslipToolStripMenuItem.Click
        frmpayslip.Show()
        frmpayslip.Focus()
    End Sub
End Class
