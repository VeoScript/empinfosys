Imports System.Data.SqlClient
Public Class DashboardCount

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim query As String

    Public Sub CountRegularEmployees()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            query = "SELECT COUNT(employementstatus) AS 'EMPLOYEE' FROM Employee WHERE employementstatus='REGULAR/UNION' OR employementstatus='REGULAR/NON-UNION'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblCountRegularEmployees.Text = reader("EMPLOYEE").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountProbationary()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            query = "SELECT COUNT(employementstatus) AS 'EMPLOYEE' FROM Employee WHERE employementstatus='PROBATIONARY'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblCountProbationary.Text = reader("EMPLOYEE").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountAgency()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            query = "SELECT COUNT(employementstatus) AS 'EMPLOYEE' FROM Employee WHERE employementstatus='AGENCY'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblCountAgency.Text = reader("EMPLOYEE").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountUnion()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            query = "SELECT COUNT(employementstatus) AS 'EMPLOYEE' FROM Employee WHERE employementstatus='REGULAR/UNION'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblCountUnion.Text = reader("EMPLOYEE").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountNonUnion()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            query = "SELECT COUNT(employementstatus) AS 'EMPLOYEE' FROM Employee WHERE employementstatus='REGULAR/NON-UNION'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblCountNonUnion.Text = reader("EMPLOYEE").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountTotalEmployees()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            query = "SELECT COUNT(*) AS 'EMPLOYEE' FROM Employee"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                DashBoard.UcDashboard1.lblCountTotalEmployees.Text = reader("EMPLOYEE").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
