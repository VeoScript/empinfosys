Public Class ucRegistration

    Private Sub btnEmployeeRegistration_Click(sender As Object, e As EventArgs) Handles btnEmployeeRegistration.Click
        'Switch for Button Active
        btnEmployeeRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnAccountRegistration.BackColor = Color.FromArgb(199, 203, 224)
        btnEmployeeRegistration.ForeColor = Color.FromArgb(255, 255, 255)
        btnAccountRegistration.ForeColor = Color.FromArgb(17, 46, 85)

        'User Control Switch
        UcRegistrationEmployee1.Visible = True
        UcAccountRegistration1.Visible = False
    End Sub

    Private Sub btnAccountRegistration_Click(sender As Object, e As EventArgs) Handles btnAccountRegistration.Click
        'Switch for Button Active
        btnEmployeeRegistration.BackColor = Color.FromArgb(199, 203, 224)
        btnAccountRegistration.BackColor = Color.FromArgb(24, 65, 120)
        btnEmployeeRegistration.ForeColor = Color.FromArgb(17, 46, 85)
        btnAccountRegistration.ForeColor = Color.FromArgb(255, 255, 255)

        'User Control Switch
        UcRegistrationEmployee1.Visible = False
        UcAccountRegistration1.Visible = True
    End Sub
End Class
