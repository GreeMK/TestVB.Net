Imports TestVB.Net.Persona
Module SearchPerson
    Public Function SearchPersonWanted(list As List(Of Persona), dniWanted As String) As Persona
        For Each p As Persona In list
            If p.DNI = dniWanted Then
                Return p
            End If
        Next
        Return Nothing
    End Function
End Module
