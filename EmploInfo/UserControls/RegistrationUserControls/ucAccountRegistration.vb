Imports System.Data.SqlClient
Public Class ucAccountRegistration

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterUserAccount()
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtRePassword.KeyDown, txtPassword.KeyDown, txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            RegisterUserAccount()
        End If
    End Sub

    Private Sub ClearInput()
        cmbPosition.selectedIndex = 0
        txtName.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
    End Sub

    Private Sub RegisterUserAccount()
        If cmbPosition.selectedIndex = -1 Or cmbPosition.selectedIndex = 0 Then
            MsgBox("Kindly select a position first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtName.Text = "" Then
            MsgBox("Kindly input a name first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Kindly input a username first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Kindly input a password first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtRePassword.Text = "" Then
            MsgBox("Kindly re-enter your password first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtPassword.Text <> txtRePassword.Text Then
            MsgBox("Your password does not match! Try again.", MsgBoxStyle.Exclamation, "EmpInfoSys")
            txtPassword.Text = ""
            txtRePassword.Text = ""
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM UserAccount WHERE name='" & txtName.Text & "' OR username='" & txtUsername.Text & "'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("This Account has already registered!", MsgBoxStyle.Critical, "EmpInfoSys")
                    ClearInput()
                Else
                    con.Close()
                    con.Open()
                    Dim insert As String
                    insert = "INSERT UserAccount(position, name, username, password) VALUES('" & cmbPosition.selectedValue & "', '" & txtName.Text & "', '" & txtUsername.Text & "', '" & txtRePassword.Text & "')"
                    cmd = New SqlCommand(insert, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Registered Successfully", MsgBoxStyle.Information, "EmpInfoSys")
                    ClearInput()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
