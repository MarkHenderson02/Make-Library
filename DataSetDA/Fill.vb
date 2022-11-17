Namespace DataSetDA
    Friend Class Fill
        Inherits DataSet

        Private dS As DataSet
        Private v As String

        Public Sub New(dS As DataSet, v As String)
            Me.dS = dS
            Me.v = v
        End Sub
    End Class
End Namespace
