Module Validaciones
    Public Function EmptyTexbox(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    Return True
                End If
            End If
            If TypeOf ctrl Is ComboBox Then
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function
End Module
