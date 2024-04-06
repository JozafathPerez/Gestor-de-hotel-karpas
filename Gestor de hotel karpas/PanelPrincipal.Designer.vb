<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelPrincipal))
        PictureBox1 = New PictureBox()
        BtCliente = New Button()
        BtReservas = New Button()
        BtPersonal = New Button()
        BtReportería = New Button()
        PanelMenu = New Panel()
        PanelAreaDeTrabajo = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(235, 665)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' BtCliente
        ' 
        BtCliente.BackColor = Color.PapayaWhip
        BtCliente.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtCliente.Location = New Point(28, 206)
        BtCliente.Name = "BtCliente"
        BtCliente.Size = New Size(178, 30)
        BtCliente.TabIndex = 1
        BtCliente.Text = "Gestión de clientes"
        BtCliente.UseVisualStyleBackColor = False
        ' 
        ' BtReservas
        ' 
        BtReservas.BackColor = Color.PapayaWhip
        BtReservas.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtReservas.Location = New Point(28, 260)
        BtReservas.Name = "BtReservas"
        BtReservas.Size = New Size(178, 30)
        BtReservas.TabIndex = 2
        BtReservas.Text = "Gestión de reservas"
        BtReservas.UseVisualStyleBackColor = False
        ' 
        ' BtPersonal
        ' 
        BtPersonal.BackColor = Color.PapayaWhip
        BtPersonal.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtPersonal.Location = New Point(28, 373)
        BtPersonal.Name = "BtPersonal"
        BtPersonal.Size = New Size(178, 30)
        BtPersonal.TabIndex = 3
        BtPersonal.Text = "Gestión de personal"
        BtPersonal.UseVisualStyleBackColor = False
        ' 
        ' BtReportería
        ' 
        BtReportería.BackColor = Color.PapayaWhip
        BtReportería.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtReportería.ForeColor = SystemColors.ControlText
        BtReportería.Location = New Point(28, 316)
        BtReportería.Name = "BtReportería"
        BtReportería.Size = New Size(178, 30)
        BtReportería.TabIndex = 4
        BtReportería.Text = "Gestión de reportería"
        BtReportería.UseVisualStyleBackColor = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Controls.Add(BtPersonal)
        PanelMenu.Controls.Add(BtCliente)
        PanelMenu.Controls.Add(BtReservas)
        PanelMenu.Controls.Add(BtReportería)
        PanelMenu.Controls.Add(PictureBox1)
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(235, 665)
        PanelMenu.TabIndex = 0
        ' 
        ' PanelAreaDeTrabajo
        ' 
        PanelAreaDeTrabajo.Location = New Point(231, 0)
        PanelAreaDeTrabajo.Name = "PanelAreaDeTrabajo"
        PanelAreaDeTrabajo.Size = New Size(1015, 665)
        PanelAreaDeTrabajo.TabIndex = 5
        ' 
        ' PanelPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1246, 664)
        Controls.Add(PanelAreaDeTrabajo)
        Controls.Add(PanelMenu)
        Name = "PanelPrincipal"
        Text = "PanelPrincipal"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtCliente As Button
    Friend WithEvents BtReservas As Button
    Friend WithEvents BtPersonal As Button
    Friend WithEvents BtReportería As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents PanelAreaDeTrabajo As Panel
End Class
