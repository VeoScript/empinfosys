Imports System.Data.SqlClient
Public Class Home

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim query As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Kindly input username and password first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                query = "SELECT * FROM UserAccount WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader

                If reader.HasRows Then
                    DashboardInfo()
                    ClearInput()
                    Hide()
                    DashBoard.Show()
                Else
                    ClearInput()
                    MsgBox("Incorrect Username or Password! Try Again.", MsgBoxStyle.Critical, "EmpInfoSys")
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub DashboardInfo()
        'Displaying Account Name and Position in DASHBOARD PAGE!
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Close()
            con.Open()
            query = "SELECT name, position FROM UserAccount WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblAccountName.Text = reader("name").ToString
                DashBoard.UcDashboard1.lblPosition.Text = reader("position").ToString
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'END
    End Sub

    Private Sub ClearInput()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub
End Class
