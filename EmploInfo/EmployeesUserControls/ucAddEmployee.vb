Imports System.Data.SqlClient
Public Class ucAddEmployee

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim search, insert As String

    Private Sub txtEmployeeNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text = "" Then
                MsgBox("Kindly input the Employee ID Number first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
            Else
                SearchRecords()
            End If
        End If
    End Sub

    Private Sub txtPosition_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSalary.KeyDown, txtPosition.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbEmploymentStatus.selectedIndex = -1 Or cmbEmploymentStatus.selectedIndex = 0 Then
                MsgBox("Select Employement Status first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
            ElseIf txtPosition.Text = "" Then
                MsgBox("Kindly input the position first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
            ElseIf txtSalary.Text = "" Then
                MsgBox("Kindly input the Salary Details first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
            Else
                HiredEmployee()
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbEmploymentStatus.selectedIndex = -1 Or cmbEmploymentStatus.selectedIndex = 0 Then
            MsgBox("Select Employement Status first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtPosition.Text = "" Then
            MsgBox("Kindly input the position first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtSalary.Text = "" Then
            MsgBox("Kindly input the Salary Details first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        Else
            HiredEmployee()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbEmploymentStatus.selectedIndex = -1 Or cmbEmploymentStatus.selectedIndex = 0 Then
            MsgBox("Select Employement Status first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtPosition.Text = "" Then
            MsgBox("Kindly input the position first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        ElseIf txtSalary.Text = "" Then
            MsgBox("Kindly input the Salary Details first!", MsgBoxStyle.Exclamation, "EmpInfoSys")
        Else
            'Code for UPDATE
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub SearchRecords()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            search = "SELECT idnumber, lastname, firstname, middlename, gender FROM RegisteredEmployee WHERE idnumber='" & txtSearch.Text & "'"
            cmd = New SqlCommand(search, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                txtIdNumber.Text = reader("idnumber").ToString
                txtLastname.Text = reader("lastname").ToString
                txtFirstname.Text = reader("firstname").ToString
                txtMiddlename.Text = reader("middlename").ToString
                txtGender.Text = reader("gender").ToString
                reader.Close()
            Else
                MsgBox("No record found! Try Again.", MsgBoxStyle.Critical, "EmpInfoSys")
                txtSearch.Text = ""
                txtSearch.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HiredEmployee()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            search = "SELECT * FROM Employee WHERE idnumber='" & txtIdNumber.Text & "'"
            cmd = New SqlCommand(search, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                MsgBox("This Employee has a records and already hired", MsgBoxStyle.Critical, "EmpInfoSys")
                ClearInput()
            Else
                con.Close()
                con.Open()
                insert = "INSERT Employee(idnumber, employementstatus, position, salarydetails, datehired) VALUES('" & txtIdNumber.Text & "', '" & cmbEmploymentStatus.selectedValue & "', '" & txtPosition.Text & "', '" & txtSalary.Text & "', '" & txtDateHired.Text & "')"
                cmd = New SqlCommand(insert, con)
                cmd.ExecuteNonQuery()
                MsgBox("Employees Recored Successfully Saved!", MsgBoxStyle.Information, "EmpInfoSys")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearInput()
        txtSearch.Text = ""
        txtIdNumber.Text = ""
        txtGender.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        cmbEmploymentStatus.selectedIndex = 0
        txtPosition.Text = ""
        txtSalary.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDateHired.Text = DateString
    End Sub

    Private Sub ucAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class
