Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Dim attempts As Integer
    Public Sub login(ByVal username As Object, ByVal pass As Object)

        Try

            con.Open()
            reloadtxt("SELECT * FROM user WHERE user_name= '" & username & "' and pass = sha1('" & pass & "')")



            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("type") = "Administrator" Then
                    MsgBox("You have successfully logged in as an " & dt.Rows(0).Item("type"))
                    With Form1
                        .Show()
                    End With

                    frm_Login.Hide()

                ElseIf dt.Rows(0).Item("type") = "Staff" Then
                    MsgBox("You have successfully logged in as a " & dt.Rows(0).Item("type"))
                    With Form1
                        .Show()
                        '.btnreports.SetBounds(10, 135, 134, 23)
                        '.btnlogout.SetBounds(10, 164, 134, 23)
                        .ManageUserToolStripMenuItem.Visible = False
                        .SettingsToolStripMenuItem.Visible = False
                        '.btnmanageuser.Visible = False
                        '.btnsettings.Visible = False

                        frm_Login.Hide()
                    End With
                End If

            Else
                attempts = attempts + 1
                MsgBox("Acount doest not exist!", MsgBoxStyle.Information)
                frm_Login.UsernameTextBox.Clear()
                frm_Login.PasswordTextBox.Clear()
                frm_Login.UsernameTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
        If attempts = 3 Then
            MsgBox("Three Attepmt! The Program is Closing...", MsgBoxStyle.Critical)
            Application.Exit()
        End If
    End Sub
    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
End Module
