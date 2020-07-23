Imports System.Data.SqlClient
Public Class ucRecords

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim query, search, f_name, l_name, m_name As String

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text = "" Then
                MsgBox("Kindly input the Employee ID Number first in searchbox!", MsgBoxStyle.Exclamation, "EmpInfoSys")
                VisibleFalse()
            Else
                SearchEmployee()
            End If
        End If
    End Sub

    Private Sub SearchEmployee()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            search = "SELECT Employee.idnumber AS 'IDNUMBER', Employee.lastname AS 'LASTNAME', Employee.firstname AS 'FIRSTNAME', Employee.middlename AS 'MIDDLENAME', Employee.Position AS 'POSITION', Employee.employementstatus AS 'EMPSTATUS', Employee.datehired AS 'DATEHIRED', RegisteredEmployee.gender AS 'GENDER', RegisteredEmployee.address AS 'ADDRESS', RegisteredEmployee.contact AS 'CONTACT', RegisteredEmployee.email AS 'EMAIL', RegisteredEmployee.birthdate AS 'BIRTHDATE',RegisteredEmployee.maritalstatus AS 'MARITAL', RegisteredEmployee.dependents AS 'DEPENDENTS', RegisteredEmployee.philhealth AS 'PHILHEALTH', RegisteredEmployee.sss AS 'SSS', RegisteredEmployee.pagibig AS 'PAGIBIG', RegisteredEmployee.tin AS 'TIN' FROM RegisteredEmployee INNER JOIN Employee ON RegisteredEmployee.idnumber = '" & txtSearch.Text & "' AND Employee.idnumber = '" & txtSearch.Text & "'"
            cmd = New SqlCommand(search, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()

                f_name = reader("FIRSTNAME").ToString
                l_name = reader("LASTNAME").ToString
                m_name = reader("MIDDLENAME").ToString

                lblEmployeeName.Text = l_name + ", " + f_name + " " + m_name
                lblEmployeeNo.Text = reader("IDNUMBER").ToString
                lblEmploymentStatus.Text = reader("EMPSTATUS").ToString
                lblDateHired.Text = reader("DATEHIRED").ToString
                lblPosition.Text = reader("POSITION").ToString
                lblGender.Text = reader("GENDER").ToString
                lblAddress.Text = reader("ADDRESS").ToString
                lblContact.Text = reader("CONTACT").ToString
                lblEmail.Text = reader("EMAIL").ToString
                txtBirthdate.Text = reader("BIRTHDATE").ToString
                txtMaritalStatus.Text = reader("MARITAL").ToString
                txtDependents.Text = reader("DEPENDENTS").ToString
                txtPHILHEALTH.Text = reader("PHILHEALTH").ToString
                txtSSS.Text = reader("SSS").ToString
                txtPAGIBIG.Text = reader("PAGIBIG").ToString
                txtTIN.Text = reader("TIN").ToString

                reader.Close()

                VisibleTrue()
            Else
                VisibleFalse()
                MsgBox("No record found!", MsgBoxStyle.Critical, "EmpInfoSys")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub VisibleTrue()
        lblEmploymentStatus.Visible = True
        lblDateHired.Visible = True
        Label11.Visible = True
        lblEmployeeName.Visible = True
        lblPosition.Visible = True
        lblGender.Visible = True
        lblAddress.Visible = True
        lblContact.Visible = True
        lblEmail.Visible = True
        panelOthers.Visible = True
    End Sub

    Public Sub VisibleFalse()
        lblEmploymentStatus.Visible = False
        lblDateHired.Visible = False
        Label11.Visible = False
        lblEmployeeName.Visible = False
        lblPosition.Visible = False
        lblGender.Visible = False
        lblAddress.Visible = False
        lblContact.Visible = False
        lblEmail.Visible = False
        panelOthers.Visible = False
        lblEmployeeNo.Text = "-------"
        txtSearch.Text = ""
    End Sub
End Class
