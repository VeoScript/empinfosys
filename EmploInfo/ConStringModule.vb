Module ConStringModule

    Public DataSouceString As String
    Public DatabaseString As String

    Public Function ConString() As String
        ConString = "Data Source=(localdb)\Projects;Initial Catalog=EIS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    End Function

End Module