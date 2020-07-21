Imports System.Data.SqlClient
Public Class ucRegistrationEmployee

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim insert, search As String

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterEmployee()
    End Sub

    Private Sub txtEmployeeNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIN.KeyDown, txtSSS.KeyDown, txtPhilhealth.KeyDown, txtPagIbig.KeyDown, txtNoDependents.KeyDown, txtMiddlename.KeyDown, txtLastname.KeyDown, txtHomeAddress.KeyDown, txtFirstname.KeyDown, txtEmployeeNo.KeyDown, txtEmailAddress.KeyDown, txtContactNo.KeyDown, txtBirthdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            RegisterEmployee()
        End If
    End Sub

    Private Sub ClearInput()
        txtEmployeeNo.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        cmbGender.selectedIndex = 0
        cmbMaritalStatus.selectedIndex = 0
        txtBirthdate.Text = ""
        txtContactNo.Text = ""
        txtNoDependents.Text = ""
        txtEmailAddress.Text = ""
        txtHomeAddress.Text = ""
        txtPhilhealth.Text = ""
        txtSSS.Text = ""
        txtPagIbig.Text = ""
        txtTIN.Text = ""
        txtEmployeeNo.Focus()
    End Sub

    Private Sub RegisterEmployee()
        If txtEmployeeNo.Text = "" Then
            MsgBox("Kindly input Employee Number first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtLastname.Text = "" Then
            MsgBox("Kindly input Last Name first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtFirstname.Text = "" Then
            MsgBox("Kindly input First Name first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtMiddlename.Text = "" Then
            MsgBox("Kindly input Middle Name first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf cmbGender.selectedIndex = -1 Or cmbGender.selectedIndex = 0 Then
            MsgBox("Kindly select Gender first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf cmbMaritalStatus.selectedIndex = -1 Or cmbMaritalStatus.selectedIndex = 0 Then
            MsgBox("Kindly select Marital Status first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtBirthdate.Text = "" Then
            MsgBox("Kindly input Birthdate first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtContactNo.Text = "" Then
            MsgBox("Kindly input Contact Number first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtNoDependents.Text = "" Then
            MsgBox("Kindly input Number of Dependents first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtEmailAddress.Text = "" Then
            MsgBox("Kindly input Email first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtHomeAddress.Text = "" Then
            MsgBox("Kindly input Home Address first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtPhilhealth.Text = "" Then
            MsgBox("Kindly input PHILHEALTH first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtSSS.Text = "" Then
            MsgBox("Kindly input SSS first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtPagIbig.Text = "" Then
            MsgBox("Kindly input PAG-IBIG first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtMiddlename.Text = "" Then
            MsgBox("Kindly input TIN Number first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                search = "SELECT * FROM RegisteredEmployee WHERE (lastname='" & txtLastname.Text & "' AND firstname='" & txtFirstname.Text & "') OR philhealth='" & txtPhilhealth.Text & "' OR sss='" & txtSSS.Text & "' OR pagibig='" & txtPagIbig.Text & "' OR tin='" & txtTIN.Text & "'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MsgBox("This record has already registered! Maybe the same Lastname, Firstname, Philhealth, SSS, Pagibig and TIN No.", MsgBoxStyle.Critical, "EmpInfoSys")
                Else
                    con.Close()
                    con.Open()
                    insert = "INSERT RegisteredEmployee(idnumber, lastname, firstname, middlename, gender, maritalstatus, birthdate, contact, dependents, email, address, philhealth, sss, pagibig, tin) VALUES('" & txtEmployeeNo.Text & "', '" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtMiddlename.Text & "', '" & cmbGender.selectedValue & "', '" & cmbMaritalStatus.selectedValue & "', '" & txtBirthdate.Text & "', '" & txtContactNo.Text & "', '" & txtNoDependents.Text & "', '" & txtEmailAddress.Text & "', '" & txtHomeAddress.Text & "', '" & txtPhilhealth.Text & "', '" & txtSSS.Text & "', '" & txtPagIbig.Text & "', '" & txtTIN.Text & "')"
                    cmd = New SqlCommand(insert, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Registered Successfully!", MsgBoxStyle.Information, "EmpInfoSys")
                    ClearInput()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
