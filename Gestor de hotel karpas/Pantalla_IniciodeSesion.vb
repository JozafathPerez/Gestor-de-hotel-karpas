Public Class Pantalla_IniciodeSesion
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_InicioSesion.Click

    End Sub

    ' Agrega este evento para el TextBox TxCuenta
    Private Sub TxCuenta_GotFocus(sender As Object, e As EventArgs) Handles TxCuenta.GotFocus
        If TxCuenta.Text = "Cuenta" Then
            TxCuenta.Text = ""
        End If
    End Sub
    Private Sub TxCuenta_Leave(sender As Object, e As EventArgs) Handles TxCuenta.Leave
        If String.IsNullOrEmpty(TxCuenta.Text) Then
            TxCuenta.Text = "Cuenta"
        End If
    End Sub

    ' Agrega este evento para el TextBox TxContrasena
    Private Sub TxContrasena_GotFocus(sender As Object, e As EventArgs) Handles TxContrasena.GotFocus
        If TxContrasena.Text = "Contraseña" Then
            TxContrasena.Text = ""
            TxContrasena.PasswordChar = "*"
        End If
    End Sub
    Private Sub TxContrasena_Leave(sender As Object, e As EventArgs) Handles TxContrasena.Leave
        If String.IsNullOrEmpty(TxContrasena.Text) Then
            TxContrasena.Text = "Contraseña"
            TxContrasena.PasswordChar = ""
        End If
    End Sub

    Private Sub BtInicioSesion_Click(sender As Object, e As EventArgs) Handles BtInicioSesion.Click
        ' Oculta el formulario actual
        Me.Hide()

        ' Crea una instancia del formulario "FormularioSecundario"
        Dim formularioSecundario As New PanelPrincipal()

        ' Muestra el formulario secundario
        formularioSecundario.Show()
    End Sub


End Class