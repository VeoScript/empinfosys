Public Class ucEmployees

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        'Switch for Button Active
        btnAddEmployee.BackColor = Color.FromArgb(24, 65, 120)
        btnListEmployees.BackColor = Color.FromArgb(199, 203, 224)
        btnAddEmployee.ForeColor = Color.FromArgb(255, 255, 255)
        btnListEmployees.ForeColor = Color.FromArgb(17, 46, 85)

        'User Control Switch
        UcAddEmployee1.Visible = True
        UcListEmployee1.Visible = False
    End Sub

    Private Sub btnListEmployees_Click(sender As Object, e As EventArgs) Handles btnListEmployees.Click
        'Switch for Button Active
        btnAddEmployee.BackColor = Color.FromArgb(199, 203, 224)
        btnListEmployees.BackColor = Color.FromArgb(24, 65, 120)
        btnAddEmployee.ForeColor = Color.FromArgb(17, 46, 85)
        btnListEmployees.ForeColor = Color.FromArgb(255, 255, 255)

        'User Control Switch
        UcAddEmployee1.Visible = False
        UcListEmployee1.Visible = True
    End Sub
End Class
