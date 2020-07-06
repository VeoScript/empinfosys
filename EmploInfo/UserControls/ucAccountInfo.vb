Public Class ucAccountInfo

    Private Sub btnYourAccount_Click(sender As Object, e As EventArgs) Handles btnYourAccount.Click
        'Bottom Separator Layout Switch
        lineEmployee.Visible = True
        lineUserAccount.Visible = False

        'User Control Switch
        UcYourAccount1.Visible = True
        UcAccountsRegistered1.Visible = False
    End Sub

    Private Sub btnAccountsRegistered_Click(sender As Object, e As EventArgs) Handles btnAccountsRegistered.Click
        'Bottom Separator Layout Switch
        lineEmployee.Visible = False
        lineUserAccount.Visible = True

        'User Control Switch
        UcYourAccount1.Visible = False
        UcAccountsRegistered1.Visible = True
    End Sub
End Class
