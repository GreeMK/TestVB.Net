Imports TestVB.Net.Persona, TestVB.Net.SearchPerson, TestVB.Net.Validaciones

Public Class Form1
    ' Declaracion de variables

    Dim listPersonas As New List(Of Persona)     ' Lista de tipo Persona (clase)
    Private personaFound As Persona = Nothing


    Sub RefreshList()

        ListBox1.Items.Clear()
        For Each p As Persona In listPersonas
            ListBox1.Items.Add(p.DNI)
        Next

    End Sub ' Subrutina para mantener actualizado el listbox

    Sub ClearInputs()
        tbDNI.Text = ""
        tbName.Text = ""
        tbSurname.Text = ""
        tbAge.Text = ""
        tbOccupation.Text = ""
        cbMaritalStatus.SelectedIndex = -1
    End Sub ' Subrutina para limpiar inputs

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If EmptyTexbox(gbData) Then
            MsgBox("Faltan datos por completar")
            Exit Sub
        Else
            Dim nuevaPersona As New Persona With {      ' Instancia de la clase Persona
            .DNI = tbDNI.Text.Trim(),
            .Name = tbName.Text.Trim(),                    ' Accedo a cada una de sus propiedades
            .Surname = tbSurname.Text.Trim(),              ' y les asigno el valor que ingresa el usuario
            .Age = tbAge.Text.Trim(),
            .Occupation = tbOccupation.Text.Trim(),
            .MaritalStatus = cbMaritalStatus.SelectedItem.ToString()
            }

            listPersonas.Add(nuevaPersona)       ' Agrego la instancia a la lista
            MsgBox("Persona agregada correctamente")

            ClearInputs()
        End If

        RefreshList()
    End Sub ' Boton Agregar

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        ' Seleccionar un item del listbox y mostrar sus datos

        Dim index As Integer = ListBox1.SelectedIndex

        If index >= 0 AndAlso index < listPersonas.Count Then
            Dim selectedPerson As Persona = listPersonas(index)

            tbDNI.Text = selectedPerson.DNI
            tbName.Text = selectedPerson.Name
            tbSurname.Text = selectedPerson.Surname
            tbAge.Text = selectedPerson.Age
            tbOccupation.Text = selectedPerson.Occupation
            cbMaritalStatus.SelectedItem = selectedPerson.MaritalStatus

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim dniIngresado As String = tbDNI.Text.Trim()

        If String.IsNullOrWhiteSpace(dniIngresado) Then
            MsgBox("Ingrese el DNI para buscar")
            Exit Sub
        End If

        personaFound = SearchPersonWanted(listPersonas, dniIngresado)

        ' Al llamar una funcion que está dentro de un modulo, y la función se llama igual al modulo
        ' genera un error, pues el compilador se confunde y piensa que se esta usando el modulo.
        ' Solución: Llamar al modulo.funcion o cambiar el nombre de la funcion

        If personaFound IsNot Nothing Then
            tbName.Text = personaFound.Name
            tbSurname.Text = personaFound.Surname
            tbOccupation.Text = personaFound.Occupation
            tbAge.Text = personaFound.Age
            cbMaritalStatus.SelectedItem = personaFound.MaritalStatus

        Else
            MsgBox("No se a encontrado")
        End If
    End Sub ' Boton Buscar

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        ' Seleccion de listbox



        Dim answer = MessageBox.Show("¿Estas seguro de eliminar a este elemento?", "Confirmar", MessageBoxButtons.YesNo)

        ' Borrar por seleccion
        If answer = DialogResult.No Then
            Exit Sub
        Else
            If ListBox1.SelectedIndex >= 0 Then
                Dim index As Integer = ListBox1.SelectedIndex
                listPersonas.RemoveAt(Index)
                ListBox1.Items.RemoveAt(Index)
                RefreshList()
                ClearInputs()
                personaFound = Nothing
            End If

        End If

        ' Borrar por busqueda
        If answer = DialogResult.No Then
            Exit Sub
        Else
            If personaFound IsNot Nothing Then
                Dim indexFound = listPersonas.IndexOf(personaFound)
                If indexFound >= 0 Then
                    listPersonas.RemoveAt(indexFound)
                    ListBox1.Items.RemoveAt(indexFound)
                    RefreshList()
                    ClearInputs()
                    personaFound = Nothing
                Else
                    MsgBox("La persona no se encuentra en la lista")
                End If
            Else
                MsgBox("No hay ninguna persona seleccionada ni buscada para eliminar")
            End If
        End If


    End Sub ' Boton Eliminar

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

        ' control de que no haya campos vacios
        If EmptyTexbox(gbData) Then
            MsgBox("Seleccione o busque un elemento")
            Exit Sub
        End If

        ' Control para saber si se modificara por seleccion o busqueda
        If ListBox1.SelectedIndex >= 0 Then
            personaFound = listPersonas(ListBox1.SelectedIndex)
        Else
            personaFound = listPersonas.Find(Function(p) p.DNI = tbDNI.Text.Trim())
        End If

        ' si se encontro la persona, se modifican sus datos
        If personaFound IsNot Nothing AndAlso ListBox1.SelectedIndex >= 0 Then
            personaFound.DNI = tbDNI.Text.Trim()
            personaFound.Name = tbName.Text.Trim()
            personaFound.Surname = tbSurname.Text.Trim()
            personaFound.Age = tbAge.Text.Trim()
            personaFound.Occupation = tbOccupation.Text.Trim()
            personaFound.MaritalStatus = cbMaritalStatus.SelectedItem
            RefreshList()
            ClearInputs()
        End If

    End Sub ' Boton Modificar

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        ClearInputs()
    End Sub ' Boton Limpiar
End Class
