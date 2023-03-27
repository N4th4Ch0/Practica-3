<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.cmdBoton = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruccion.ForeColor = System.Drawing.Color.DimGray
        Me.lblInstruccion.Location = New System.Drawing.Point(287, 51)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(164, 32)
        Me.lblInstruccion.TabIndex = 0
        Me.lblInstruccion.Text = "Escriba un mensaje"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(227, 103)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(278, 23)
        Me.txtMensaje.TabIndex = 1
        '
        'cmdBoton
        '
        Me.cmdBoton.Font = New System.Drawing.Font("Dubai", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmdBoton.Location = New System.Drawing.Point(300, 151)
        Me.cmdBoton.Name = "cmdBoton"
        Me.cmdBoton.Size = New System.Drawing.Size(127, 63)
        Me.cmdBoton.TabIndex = 2
        Me.cmdBoton.Text = "Mostrar mensaje"
        Me.cmdBoton.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Dubai", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(227, 262)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 27)
        Me.lblMensaje.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 327)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.cmdBoton)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.lblInstruccion)
        Me.Name = "Form1"
        Me.Text = "Practica3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruccion As Label
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents cmdBoton As Button
    Friend WithEvents lblMensaje As Label
End Class
