Imports System.Data.SqlClient
Public Class DashBoard

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim query As String
    Dim dashboardcount As New DashboardCount

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
        Home.Show()
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashBoard.BackColor = Color.FromArgb(56, 151, 244)

        'Para ni sa pag Count sa tanang Empleyado (Regular, Probationary, Union, Non-Union, ug Agency)
        dashboardcount.CountRegularEmployees()
        dashboardcount.CountUnion()
        dashboardcount.CountNonUnion()
        dashboardcount.CountProbationary()
        dashboardcount.CountAgency()
        dashboardcount.CountTotalEmployees()
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        'Switch for User Controls
        UcDashboard1.Visible = True
        UcRegistration1.Visible = False
        UcEmployees1.Visible = False
        UcRecords1.Visible = False
        UcAccountInfo1.Visible = False

        'Switch for Button Active
        btnDashBoard.BackColor = Color.FromArgb(56, 151, 244)
        btnRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnEmployees.BackColor = Color.FromArgb(24, 65, 120)
        btnRecords.BackColor = Color.FromArgb(24, 65, 120)
        btnAccountInfo.BackColor = Color.FromArgb(24, 65, 120)
        btnSettings.BackColor = Color.FromArgb(24, 65, 120)

        'Sa Record na Page pag Visible False sa tanang controls
        UcRecords1.VisibleFalse()
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        'Switch for User Controls
        UcDashboard1.Visible = False
        UcRegistration1.Visible = True
        UcEmployees1.Visible = False
        UcRecords1.Visible = False
        UcAccountInfo1.Visible = False

        'Switch for Button Active
        btnDashBoard.BackColor = Color.FromArgb(24, 65, 120)
        btnRegistration.BackColor = Color.FromArgb(56, 151, 244)
        btnEmployees.BackColor = Color.FromArgb(24, 65, 120)
        btnRecords.BackColor = Color.FromArgb(24, 65, 120)
        btnAccountInfo.BackColor = Color.FromArgb(24, 65, 120)
        btnSettings.BackColor = Color.FromArgb(24, 65, 120)

        'Sa Record na Page pag Visible False sa tanang controls
        UcRecords1.VisibleFalse()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        'Switch for User Controls
        UcDashboard1.Visible = False
        UcRegistration1.Visible = False
        UcEmployees1.Visible = True
        UcRecords1.Visible = False
        UcAccountInfo1.Visible = False

        'Switch for Button Active
        btnDashBoard.BackColor = Color.FromArgb(24, 65, 120)
        btnRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnEmployees.BackColor = Color.FromArgb(56, 151, 244)
        btnRecords.BackColor = Color.FromArgb(24, 65, 120)
        btnAccountInfo.BackColor = Color.FromArgb(24, 65, 120)
        btnSettings.BackColor = Color.FromArgb(24, 65, 120)

        'Sa Record na Page pag Visible False sa tanang controls
        UcRecords1.VisibleFalse()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        'Switch for User Controls
        UcDashboard1.Visible = False
        UcRegistration1.Visible = False
        UcEmployees1.Visible = False
        UcRecords1.Visible = True
        UcAccountInfo1.Visible = False

        'Switch for Button Active
        btnDashBoard.BackColor = Color.FromArgb(24, 65, 120)
        btnRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnEmployees.BackColor = Color.FromArgb(24, 65, 120)
        btnRecords.BackColor = Color.FromArgb(56, 151, 244)
        btnAccountInfo.BackColor = Color.FromArgb(24, 65, 120)
        btnSettings.BackColor = Color.FromArgb(24, 65, 120)

        'Sa Record na Page pag Visible False sa tanang controls
        UcRecords1.VisibleFalse()
    End Sub

    Private Sub btnAccountInfo_Click(sender As Object, e As EventArgs) Handles btnAccountInfo.Click
        'Switch for User Controls
        UcDashboard1.Visible = False
        UcRegistration1.Visible = False
        UcEmployees1.Visible = False
        UcRecords1.Visible = False
        UcAccountInfo1.Visible = True

        'Switch for Button Active
        btnDashBoard.BackColor = Color.FromArgb(24, 65, 120)
        btnRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnEmployees.BackColor = Color.FromArgb(24, 65, 120)
        btnRecords.BackColor = Color.FromArgb(24, 65, 120)
        btnAccountInfo.BackColor = Color.FromArgb(56, 151, 244)
        btnSettings.BackColor = Color.FromArgb(24, 65, 120)

        'Sa Record na Page pag Visible False sa tanang controls
        UcRecords1.VisibleFalse()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        'Switch for Button Active
        btnDashBoard.BackColor = Color.FromArgb(24, 65, 120)
        btnRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnEmployees.BackColor = Color.FromArgb(24, 65, 120)
        btnRecords.BackColor = Color.FromArgb(24, 65, 120)
        btnAccountInfo.BackColor = Color.FromArgb(24, 65, 120)
        btnSettings.BackColor = Color.FromArgb(56, 151, 244)

        'Sa Record na Page pag Visible False sa tanang controls
        UcRecords1.VisibleFalse()
    End Sub
End Class