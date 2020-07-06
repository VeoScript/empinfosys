Public Class ucEmployees

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        'Bottom Separator Layout Switch
        lineEmployee.Visible = True
        lineUserAccount.Visible = False

        'User Control Switch
        UcAddEmployee1.Visible = True
        UcListEmployee1.Visible = False
    End Sub

    Private Sub btnListEmployees_Click(sender As Object, e As EventArgs) Handles btnListEmployees.Click
        'Bottom Separator Layout Switch
        lineEmployee.Visible = False
        lineUserAccount.Visible = True

        'User Control Switch
        UcAddEmployee1.Visible = False
        UcListEmployee1.Visible = True
    End Sub
End Class
