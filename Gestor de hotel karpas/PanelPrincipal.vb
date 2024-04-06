Public Class PanelPrincipal
    ' Variable para almacenar el último botón presionado
    Private ultimoBoton As Button = Nothing

    ' Función para cambiar el color del botón y restaurar el color del último botón presionado
    Private Sub CambiarColorBoton(botonPresionado As Button)
        If Not ultimoBoton Is Nothing Then
            ultimoBoton.BackColor = Color.PapayaWhip ' Restaurar color del último botón
        End If

        botonPresionado.BackColor = Color.Orange ' Cambiar color del botón presionado
        ultimoBoton = botonPresionado ' Actualizar el último botón presionado
    End Sub
    ' Evento al hacer clic en el botón Cliente
    Private Sub BtCliente_Click(sender As Object, e As EventArgs) Handles BtCliente.Click
        CambiarColorBoton(BtCliente)
        ' Limpiar cualquier control existente en el PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Clear()

        ' Crear un nuevo control de texto con el mensaje
        Dim mensaje As New Label()
        mensaje.Text = "Botón seleccionado: Cliente"
        mensaje.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        mensaje.AutoSize = True
        mensaje.Location = New Point(20, 20)

        ' Agregar el mensaje al PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Add(mensaje)
    End Sub

    ' Evento al hacer clic en el botón Reservas
    Private Sub BtReservas_Click(sender As Object, e As EventArgs) Handles BtReservas.Click
        CambiarColorBoton(BtReservas)
        ' Limpiar cualquier control existente en el PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Clear()

        ' Crear un nuevo control de texto con el mensaje
        Dim mensaje As New Label()
        mensaje.Text = "Botón seleccionado: Reservas"
        mensaje.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        mensaje.AutoSize = True
        mensaje.Location = New Point(20, 20)

        ' Agregar el mensaje al PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Add(mensaje)
    End Sub

    ' Evento al hacer clic en el botón Personal
    Private Sub BtPersonal_Click(sender As Object, e As EventArgs) Handles BtPersonal.Click
        CambiarColorBoton(BtPersonal)
        ' Limpiar cualquier control existente en el PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Clear()

        ' Crear un nuevo control de texto con el mensaje
        Dim mensaje As New Label()
        mensaje.Text = "Botón seleccionado: Personal"
        mensaje.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        mensaje.AutoSize = True
        mensaje.Location = New Point(20, 20)

        ' Agregar el mensaje al PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Add(mensaje)
    End Sub

    ' Evento al hacer clic en el botón Reportería
    Private Sub BtReportería_Click(sender As Object, e As EventArgs) Handles BtReportería.Click
        CambiarColorBoton(BtReportería)
        ' Limpiar cualquier control existente en el PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Clear()

        ' Crear un nuevo control de texto con el mensaje
        Dim mensaje As New Label()
        mensaje.Text = "Botón seleccionado: Reportería"
        mensaje.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        mensaje.AutoSize = True
        mensaje.Location = New Point(20, 20)

        ' Agregar el mensaje al PanelAreaDeTrabajo
        PanelAreaDeTrabajo.Controls.Add(mensaje)
    End Sub
End Class