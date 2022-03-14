Public Class Form1
    Private Sub Bttcalcular_Click(sender As Object, e As EventArgs) Handles Bttcalcular.Click

        If indice < 8 Then
            matriz(0, indice) = TxtCarne.Text
            matriz(1, indice) = TxtNombre.Text
            matriz(2, indice) = Cbidiomas.SelectedItem
            matriz(3, indice) = Dtfecha.Value
            matriz(5, indice) = Txthoras.Text

            If Cbsabado.Checked Then
                matriz(4, indice) = Cbsabado.Text
            ElseIf Cbviernes.Checked Then
                matriz(4, indice) = Cbviernes.Text
            End If

            If Rbefectivo.Checked Then
                matriz(6, indice) = Rbefectivo.Text
            ElseIf Rbcheque.Checked Then
                matriz(6, indice) = Rbcheque.Text
            End If

            If Cbidiomas.SelectedItem = "Inglés" Then
                pagoparcialingles = pagoingles * Txthoras.Text
                matriz(7, indice) = pagoparcialingles
            End If
            If Cbidiomas.SelectedItem = "Portugués" Then
                pagoparcialportugues = pagoportugues * Txthoras.Text
                matriz(7, indice) = pagoparcialportugues
            End If
            If Cbidiomas.SelectedItem = "Francés" Then
                pagoparcialfrances = pagofrances * Txthoras.Text
                matriz(7, indice) = pagoparcialfrances
            End If

            If Cbsabado.Checked = True And Cbviernes.Checked = True Then
                descuentodías = pagoparcialingles * descuento2
                matriz(9, indice) = descuentodías
            End If

            If Cbsabado.Checked = True And Cbviernes.Checked = True Then
                descuentodías = pagoparcialfrances * descuento2
                matriz(9, indice) = descuentodías
            End If

            If Cbsabado.Checked = True And Cbviernes.Checked = True Then
                descuentodías = pagoparcialportugues * descuento2
                matriz(9, indice) = descuentodías
            End If


            If Rbefectivo.Checked = True Then
                descuentopago = pagoparcialingles * descuentoefectivo
                matriz(8, indice) = descuentopago
            End If

            If Rbefectivo.Checked = True Then
                descuentopago = pagoparcialfrances * descuentoefectivo
                matriz(8, indice) = descuentopago

                If Rbefectivo.Checked = True Then
                    descuentopago = pagoparcialportugues * descuentoefectivo
                    matriz(8, indice) = descuentopago
                End If

            End If
            If Rbcheque.Checked = True Then
                descuentopago = pagoparcialingles * descuentocheque
                matriz(8, indice) = descuentopago
            End If

            If Rbcheque.Checked = True Then
                descuentopago = pagoparcialfrances * descuentocheque
                matriz(8, indice) = descuentopago
            End If

            If Rbcheque.Checked = True Then
                descuentopago = pagoparcialportugues * descuentocheque
                matriz(8, indice) = descuentopago
            End If

            pagofinal = pagoparcialingles - (descuentopago + descuento2)
            matriz(10, indice) = pagofinal

            pagofinal = pagoparcialportugues - (descuentopago + descuento2)
            matriz(10, indice) = pagofinal

            pagofinal = pagoparcialfrances - (descuentopago + descuento2)
            matriz(10, indice) = pagofinal

            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), matriz(8, indice), matriz(9, indice), matriz(10, indice))
            indice = indice + 1
            Else
                MessageBox.Show("Ya llego al límite")
            End If
    End Sub

    Private Sub Btsalir_Click(sender As Object, e As EventArgs) Handles Btsalir.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub Btlimpiar_Click(sender As Object, e As EventArgs) Handles Btlimpiar.Click
        Cbidiomas.SelectedIndex = False
        Cbsabado.Checked = False
        Cbviernes.Checked = False
        TxtCarne.Text = ""
        Txthoras.Text = ""
        TxtNombre.Text = ""
        Rbcheque.Checked = False
        Rbefectivo.Checked = False
        DataGridView1.Rows.Clear()

    End Sub
End Class
