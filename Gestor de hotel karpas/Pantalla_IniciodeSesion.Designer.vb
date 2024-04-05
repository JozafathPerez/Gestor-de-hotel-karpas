<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pantalla_IniciodeSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_IniciodeSesion))
        Label_InicioSesion = New Label()
        LogoPrincipal = New PictureBox()
        TxCuenta = New TextBox()
        TxContrasena = New TextBox()
        BtInicioSesion = New Button()
        CType(LogoPrincipal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_InicioSesion
        ' 
        Label_InicioSesion.AutoSize = True
        Label_InicioSesion.Font = New Font("Segoe UI", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_InicioSesion.Location = New Point(468, 290)
        Label_InicioSesion.Name = "Label_InicioSesion"
        Label_InicioSesion.Size = New Size(359, 65)
        Label_InicioSesion.TabIndex = 0
        Label_InicioSesion.Text = "Inicio de Sesión"
        ' 
        ' LogoPrincipal
        ' 
        LogoPrincipal.ErrorImage = CType(resources.GetObject("LogoPrincipal.ErrorImage"), Image)
        LogoPrincipal.Image = CType(resources.GetObject("LogoPrincipal.Image"), Image)
        LogoPrincipal.Location = New Point(497, 0)
        LogoPrincipal.Name = "LogoPrincipal"
        LogoPrincipal.Size = New Size(282, 303)
        LogoPrincipal.TabIndex = 1
        LogoPrincipal.TabStop = False
        ' 
        ' TxCuenta
        ' 
        TxCuenta.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxCuenta.Location = New Point(524, 380)
        TxCuenta.Name = "TxCuenta"
        TxCuenta.Size = New Size(255, 29)
        TxCuenta.TabIndex = 2
        ' 
        ' TxContrasena
        ' 
        TxContrasena.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxContrasena.Location = New Point(524, 442)
        TxContrasena.Name = "TxContrasena"
        TxContrasena.Size = New Size(255, 29)
        TxContrasena.TabIndex = 3
        ' 
        ' BtInicioSesion
        ' 
        BtInicioSesion.BackColor = Color.Orange
        BtInicioSesion.ForeColor = SystemColors.ActiveCaptionText
        BtInicioSesion.Location = New Point(573, 501)
        BtInicioSesion.Name = "BtInicioSesion"
        BtInicioSesion.Size = New Size(165, 42)
        BtInicioSesion.TabIndex = 4
        BtInicioSesion.Text = "Iniciar Sesión"
        BtInicioSesion.UseVisualStyleBackColor = False
        ' 
        ' Pantalla_IniciodeSesion
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1284, 861)
        Controls.Add(BtInicioSesion)
        Controls.Add(TxContrasena)
        Controls.Add(TxCuenta)
        Controls.Add(LogoPrincipal)
        Controls.Add(Label_InicioSesion)
        Name = "Pantalla_IniciodeSesion"
        Text = "Pantalla_IniciodeSesion"
        CType(LogoPrincipal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_InicioSesion As Label
    Friend WithEvents LogoPrincipal As PictureBox
    Friend WithEvents TxCuenta As TextBox
    Friend WithEvents TxContrasena As TextBox
    Friend WithEvents BtInicioSesion As Button

End Class
