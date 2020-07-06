Public Class ucRegistration

    Private Sub btnEmployeeRegistration_Click(sender As Object, e As EventArgs) Handles btnEmployeeRegistration.Click
        'Bottom Separator Layout Switch
        lineEmployee.Visible = True
        lineUserAccount.Visible = False

        'User Control Switch
        UcRegistrationEmployee1.Visible = True
        UcAccountRegistration1.Visible = False
    End Sub

    Private Sub btnAccountRegistration_Click(sender As Object, e As EventArgs) Handles btnAccountRegistration.Click
        'Bottom Separator Layout Switch
        lineEmployee.Visible = False
        lineUserAccount.Visible = True

        'User Control Switch
        UcRegistrationEmployee1.Visible = False
        UcAccountRegistration1.Visible = True
    End Sub
End Class
